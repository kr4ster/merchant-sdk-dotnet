using System;
using System.Collections.Generic;
using System.Web;
using System.Collections.Specialized;
using PayPal.PayPalAPIInterfaceService;
using PayPal.PayPalAPIInterfaceService.Model;
using System.Configuration;
using PayPal.Permissions.Model;

namespace PayPalAPISample.UseCaseSamples
{
    /// <summary>
    /// Summary description for Payments
    /// </summary>
    public class Payments : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string strCall = context.Request.Params["SetExpressCheckoutBtn"];

            if (strCall.Equals("RecurringPay"))
            {
                RecurringPay(context);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Handles Recurring Pay API calls
        /// </summary>
        /// <param name="context"></param>
        private void RecurringPay(HttpContext context)
        {
            NameValueCollection parameters = context.Request.Params;

            // Configuration map containing signature credentials and other required configuration.
            // For a full list of configuration parameters refer at 
            // [https://github.com/paypal/merchant-sdk-dotnet/wiki/SDK-Configuration-Parameters]
            Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

            // Create the PayPalAPIInterfaceServiceService service object to make the API call
            PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(configurationMap);

            SetExpressCheckoutRequestType setExpressCheckoutReq = new SetExpressCheckoutRequestType();
            SetExpressCheckoutRequestDetailsType details = new SetExpressCheckoutRequestDetailsType();

            string requestUrl = ConfigurationManager.AppSettings["HOSTING_ENDPOINT"].ToString();

            // (Required) URL to which the buyer's browser is returned after choosing to pay with PayPal. For digital goods, you must add JavaScript to this page to close the in-context experience.
            // Note:
            // PayPal recommends that the value be the final review page on which the buyer confirms the order and payment or billing agreement.
            UriBuilder uriBuilder = new UriBuilder(requestUrl);
            uriBuilder.Path = context.Request.ApplicationPath
                + (context.Request.ApplicationPath.EndsWith("/") ? string.Empty : "/")
                + "UseCaseSamples/SetExpressCheckoutForRecurringPayments.aspx";
            string returnUrl = uriBuilder.Uri.ToString();

            //(Required) URL to which the buyer is returned if the buyer does not approve the use of PayPal to pay you. For digital goods, you must add JavaScript to this page to close the in-context experience.
            // Note:
            // PayPal recommends that the value be the original page on which the buyer chose to pay with PayPal or establish a billing agreement.
            uriBuilder = new UriBuilder(requestUrl);
            uriBuilder.Path = context.Request.ApplicationPath
                + (context.Request.ApplicationPath.EndsWith("/") ? string.Empty : "/")
                + "UseCaseSamples/SetExpressCheckoutForRecurringPayments.aspx";
            string cancelUrl = uriBuilder.Uri.ToString();

            /*
             *  (Required) URL to which the buyer's browser is returned after choosing 
             *  to pay with PayPal. For digital goods, you must add JavaScript to this 
             *  page to close the in-context experience.
              Note:
                PayPal recommends that the value be the final review page on which the buyer 
                confirms the order and payment or billing agreement.
                Character length and limitations: 2048 single-byte characters
             */
            details.ReturnURL = returnUrl + "?currencyCodeType=" + parameters["currencyCode"];

            details.CancelURL = cancelUrl;

            /*
             *  (Optional) Email address of the buyer as entered during checkout.
             *  PayPal uses this value to pre-fill the PayPal membership sign-up portion on the PayPal pages.
             *	Character length and limitations: 127 single-byte alphanumeric characters
             */
            details.BuyerEmail = parameters["buyerMail"];

            decimal itemTotal = 0.0M;
            decimal orderTotal = 0.0M;
            // populate line item details
            //Cost of item. This field is required when you pass a value for ItemCategory.
            string amountItems = parameters["itemAmount"];
            /*
             * Item quantity. This field is required when you pass a value for ItemCategory. 
             * For digital goods (ItemCategory=Digital), this field is required.
               Character length and limitations: Any positive integer
               This field is introduced in version 53.0. 
             */
            string qtyItems = parameters["itemQuantity"];
            /*
             * Item name. This field is required when you pass a value for ItemCategory.
                Character length and limitations: 127 single-byte characters
                This field is introduced in version 53.0. 
             */
            string names = parameters["itemName"];

            List<PaymentDetailsItemType> lineItems = new List<PaymentDetailsItemType>();
            PaymentDetailsItemType item = new PaymentDetailsItemType();
            BasicAmountType amt = new BasicAmountType();

            //PayPal uses 3-character ISO-4217 codes for specifying currencies in fields and variables. 
            amt.currencyID = (CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]);
            amt.value = amountItems;
            item.Quantity = Convert.ToInt32(qtyItems);
            item.Name = names;
            item.Amount = amt;

            /*
             * Indicates whether an item is digital or physical. For digital goods, this field is required and must be set to Digital. It is one of the following values:
                1.Digital
                2.Physical
               This field is available since version 65.1. 
             */
            item.ItemCategory = (ItemCategoryType)Enum.Parse(typeof(ItemCategoryType), parameters["itemCategory"]);

            /*
             *  (Optional) Item description.
                Character length and limitations: 127 single-byte characters
                This field is introduced in version 53.0. 
             */
            item.Description = parameters["itemDescription"];
            lineItems.Add(item);

            /*
             * (Optional) Item sales tax.
                Note: You must set the currencyID attribute to one of 
                the 3-character currency codes for any of the supported PayPal currencies.
                Character length and limitations: Value is a positive number which cannot exceed $10,000 USD in any currency.
                It includes no currency symbol. It must have 2 decimal places, the decimal separator must be a period (.), 
                and the optional thousands separator must be a comma (,).
             */
            if (parameters["salesTax"] != string.Empty)
            {
                item.Tax = new BasicAmountType((CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]), parameters["salesTax"]);
            }

            itemTotal += Convert.ToDecimal(qtyItems) * Convert.ToDecimal(amountItems);
            orderTotal += itemTotal;

            List<PaymentDetailsType> payDetails = new List<PaymentDetailsType>();
            PaymentDetailsType paydtl = new PaymentDetailsType();
            /*
             * How you want to obtain payment. When implementing parallel payments, 
             * this field is required and must be set to Order.
             *  When implementing digital goods, this field is required and must be set to Sale.
             *   If the transaction does not include a one-time purchase, this field is ignored. 
             *   It is one of the following values:

                Sale – This is a final sale for which you are requesting payment (default).
                Authorization – This payment is a basic authorization subject to settlement with PayPal Authorization and Capture.
                Order – This payment is an order authorization subject to settlement with PayPal Authorization and Capture.
             */
            paydtl.PaymentAction = (PaymentActionCodeType)Enum.Parse(typeof(PaymentActionCodeType), parameters["paymentType"]);

            /*
             *  (Optional) Total shipping costs for this order.
                Note:
                You must set the currencyID attribute to one of the 3-character currency codes 
                for any of the supported PayPal currencies.
                Character length and limitations: 
                Value is a positive number which cannot exceed $10,000 USD in any currency.
                It includes no currency symbol. 
                It must have 2 decimal places, the decimal separator must be a period (.), 
                and the optional thousands separator must be a comma (,)
             */
            if (parameters["shippingTotal"] != string.Empty)
            {
                BasicAmountType shippingTotal = new BasicAmountType();
                shippingTotal.value = parameters["shippingTotal"];
                shippingTotal.currencyID = (CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]);
                orderTotal += Convert.ToDecimal(parameters["shippingTotal"]);
                paydtl.ShippingTotal = shippingTotal;
            }

            /*
             *  (Optional) Total shipping insurance costs for this order. 
             *  The value must be a non-negative currency amount or null if you offer insurance options.
                 Note:
                 You must set the currencyID attribute to one of the 3-character currency 
                 codes for any of the supported PayPal currencies.
                 Character length and limitations: 
                 Value is a positive number which cannot exceed $10,000 USD in any currency. 
                 It includes no currency symbol. It must have 2 decimal places,
                 the decimal separator must be a period (.), 
                 and the optional thousands separator must be a comma (,).
                 InsuranceTotal is available since version 53.0.
             */
            if (parameters["insuranceTotal"] != string.Empty)
            {
                paydtl.InsuranceTotal = new BasicAmountType((CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]), parameters["insuranceTotal"]);
                paydtl.InsuranceOptionOffered = "true";
                orderTotal += Convert.ToDecimal(parameters["insuranceTotal"]);
            }

            /*
             *  (Optional) Total handling costs for this order.
                 Note:
                 You must set the currencyID attribute to one of the 3-character currency codes 
                 for any of the supported PayPal currencies.
                 Character length and limitations: Value is a positive number which 
                 cannot exceed $10,000 USD in any currency.
                 It includes no currency symbol. It must have 2 decimal places, 
                 the decimal separator must be a period (.), and the optional 
                 thousands separator must be a comma (,). 
             */
            if (parameters["handlingTotal"] != string.Empty)
            {
                paydtl.HandlingTotal = new BasicAmountType((CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]), parameters["handlingTotal"]);
                orderTotal += Convert.ToDecimal(parameters["handlingTotal"]);
            }

            /*
             *  (Optional) Sum of tax for all items in this order.
                 Note:
                 You must set the currencyID attribute to one of the 3-character currency codes
                 for any of the supported PayPal currencies.
                 Character length and limitations: Value is a positive number which 
                 cannot exceed $10,000 USD in any currency. It includes no currency symbol.
                 It must have 2 decimal places, the decimal separator must be a period (.),
                 and the optional thousands separator must be a comma (,).
             */
            if (parameters["taxTotal"] != string.Empty)
            {
                paydtl.TaxTotal = new BasicAmountType((CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]), parameters["taxTotal"]);
                orderTotal += Convert.ToDecimal(parameters["taxTotal"]);
            }

            /*
             *  (Optional) Description of items the buyer is purchasing.
                 Note:
                 The value you specify is available only if the transaction includes a purchase.
                 This field is ignored if you set up a billing agreement for a recurring payment 
                 that is not immediately charged.
                 Character length and limitations: 127 single-byte alphanumeric characters
             */
            if (parameters["orderDescription"] != string.Empty)
            {
                paydtl.OrderDescription = parameters["orderDescription"];
            }


            BasicAmountType itemsTotal = new BasicAmountType();
            itemsTotal.value = Convert.ToString(itemTotal);

            //PayPal uses 3-character ISO-4217 codes for specifying currencies in fields and variables. 
            itemsTotal.currencyID = (CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]);

            paydtl.OrderTotal = new BasicAmountType((CurrencyCodeType)Enum.Parse(typeof(CurrencyCodeType), parameters["currencyCode"]), Convert.ToString(orderTotal));
            paydtl.PaymentDetailsItem = lineItems;

            paydtl.ItemTotal = itemsTotal;
            /*
             *  (Optional) Your URL for receiving Instant Payment Notification (IPN) 
             *  about this transaction. If you do not specify this value in the request, 
             *  the notification URL from your Merchant Profile is used, if one exists.
                Important:
                The notify URL applies only to DoExpressCheckoutPayment. 
                This value is ignored when set in SetExpressCheckout or GetExpressCheckoutDetails.
                Character length and limitations: 2,048 single-byte alphanumeric characters
             */
            paydtl.NotifyURL = parameters["notifyURL"];

            payDetails.Add(paydtl);
            details.PaymentDetails = payDetails;

            if (parameters["billingAgreementText"] != string.Empty)
            {
                /*
                 *  (Required) Type of billing agreement. For recurring payments,
                 *   this field must be set to RecurringPayments. 
                 *   In this case, you can specify up to ten billing agreements. 
                 *   Other defined values are not valid.
                     Type of billing agreement for reference transactions. 
                     You must have permission from PayPal to use this field. 
                     This field must be set to one of the following values:
                        1. MerchantInitiatedBilling - PayPal creates a billing agreement 
                           for each transaction associated with buyer.You must specify 
                           version 54.0 or higher to use this option.
                        2. MerchantInitiatedBillingSingleAgreement - PayPal creates a 
                           single billing agreement for all transactions associated with buyer.
                           Use this value unless you need per-transaction billing agreements. 
                           You must specify version 58.0 or higher to use this option.

                 */
                BillingAgreementDetailsType billingAgreement = new BillingAgreementDetailsType((BillingCodeType)Enum.Parse(typeof(BillingCodeType), parameters["billingType"]));

                /*
                 * Description of goods or services associated with the billing agreement. 
                 * This field is required for each recurring payment billing agreement.
                 *  PayPal recommends that the description contain a brief summary of 
                 *  the billing agreement terms and conditions. For example,
                 *   buyer is billed at "9.99 per month for 2 years".
                   Character length and limitations: 127 single-byte alphanumeric characters
                 */
                billingAgreement.BillingAgreementDescription = parameters["billingAgreementText"];
                List<BillingAgreementDetailsType> billList = new List<BillingAgreementDetailsType>();
                billList.Add(billingAgreement);
                details.BillingAgreementDetails = billList;
            }

            setExpressCheckoutReq.SetExpressCheckoutRequestDetails = details;
            SetExpressCheckoutReq expressCheckoutReq = new SetExpressCheckoutReq();
            expressCheckoutReq.SetExpressCheckoutRequest = setExpressCheckoutReq;

            SetExpressCheckoutResponseType resp = null;
            try
            {
                resp = service.SetExpressCheckout(expressCheckoutReq);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.StackTrace);
                return;
            }


            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.Ack.Equals(AckCode.FAILURE) && !(resp.Ack.Equals(AckCode.FAILUREWITHWARNING))))
            {
                redirectUrl = ConfigurationManager.AppSettings["PAYPAL_REDIRECT_URL"].ToString() + "_express-checkout&token=" + resp.Token;
                keyResponseParams.Add("Acknowledgement", resp.Ack.ToString());
            }
            displayResponse(context, "RecurringPay", keyResponseParams, service.getLastRequest(), service.getLastResponse(), resp.Errors, redirectUrl);
        }
        
        /// <summary>
        /// Utility method for displaying API response
        /// </summary>
        /// <param name="context"></param>
        /// <param name="apiName"></param>
        /// <param name="responseValues"></param>
        /// <param name="requestPayload"></param>
        /// <param name="responsePayload"></param>
        /// <param name="errorMessages"></param>
        /// <param name="redirectUrl"></param>
        private void displayResponse(HttpContext context, string apiName, Dictionary<string, string> responseValues,
            string requestPayload, string responsePayload, List<ErrorType> errorMessages, string redirectUrl)
        {

            context.Response.Write("<html><head><title>");
            context.Response.Write("PayPal Adaptive Payments - " + apiName);
            context.Response.Write("</title><link rel='stylesheet' href='../APICalls/sdk.css' type='text/css'/></head><body>");
            context.Response.Write("<h3>" + apiName + " response</h3>");
            if (errorMessages != null && errorMessages.Count > 0)
            {
                context.Response.Write("<div class='section_header'>Error messages</div>");
                context.Response.Write("<div class='note'>Investigate the response object for further error information</div><ul>");
                foreach (ErrorType error in errorMessages)
                {
                    context.Response.Write("<li>" + error.LongMessage + "</li>");
                }
                context.Response.Write("</ul>");
            }
            if (redirectUrl != null)
            {
                string red = "<div>This API involves a web flow. You must now redirect your user to " + redirectUrl;
                red = red + "<br />Please click <a href='" + redirectUrl + "' target='_self'>here</a> to try the flow.</div><br/>";
                context.Response.Write(red);
            }
            context.Response.Write("<div class='section_header'>Key values from response</div>");
            context.Response.Write("<div class='note'>Consult response object and reference doc for complete list of response values.</div><table>");

            /*
            foreach (KeyValuePair<string, string> entry in responseValues) {
                context.Response.Write("<tr><td class='label'>");
                context.Response.Write(entry.Key);
                context.Response.Write(": </td><td>");
                context.Response.Write(entry.Value);
                context.Response.Write("</td></tr>");
            }
            */

            //Selenium Test Case            
            foreach (KeyValuePair<string, string> entry in responseValues)
            {

                context.Response.Write("<tr><td class='label'>");
                context.Response.Write(entry.Key);
                context.Response.Write(": </td><td>");

                if (entry.Key == "Redirect To PayPal")
                {
                    context.Response.Write("<a id='");
                    context.Response.Write(entry.Key);
                    context.Response.Write("' href=");
                    context.Response.Write(entry.Value);
                    context.Response.Write(">Redirect To PayPal</a>");
                }
                else
                {
                    context.Response.Write("<div id='");
                    context.Response.Write(entry.Key);
                    context.Response.Write("'>");
                    context.Response.Write(entry.Value);
                }

                context.Response.Write("</td></tr>");
            }

            context.Response.Write("</table><h4>Request:</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(requestPayload);
            context.Response.Write("</textarea><br/><h4>Response</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(responsePayload);
            context.Response.Write("</textarea>");
            context.Response.Write("<br/><br/><a href='Default.aspx'>Home<a><br/><br/></body></html>");
        }
    }
}
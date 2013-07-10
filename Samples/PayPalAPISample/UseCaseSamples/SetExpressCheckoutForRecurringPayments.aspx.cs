using System;
using System.Collections.Generic;
using System.Web;
using PayPal.PayPalAPIInterfaceService.Model;
using PayPal.PayPalAPIInterfaceService;

namespace PayPalAPISample.UseCaseSamples
{
    public partial class SetExpressCheckoutForRecurringPayments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            // Create request object
            SetExpressCheckoutRequestType request = new SetExpressCheckoutRequestType();
            //populateRequestObject(request);

            // Invoke the API
            SetExpressCheckoutReq wrapper = new SetExpressCheckoutReq();
            wrapper.SetExpressCheckoutRequest = request;

            // Configuration map containing signature credentials and other required configuration.
            // For a full list of configuration parameters refer at 
            // [https://github.com/paypal/merchant-sdk-dotnet/wiki/SDK-Configuration-Parameters]
            Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

            // Create the PayPalAPIInterfaceServiceService service object to make the API call
            PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(configurationMap);

            // # API call 
            // Invoke the SetExpressCheckout method in service wrapper object  
            SetExpressCheckoutResponseType setECResponse = service.SetExpressCheckout(wrapper);

            // Check for API return status
            HttpContext CurrContext = HttpContext.Current;
            CurrContext.Items.Add("paymentDetails", request.SetExpressCheckoutRequestDetails.PaymentDetails);
            //setKeyResponseObjects(service, setECResponse);
        }
    }
}
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetExpressCheckoutPaymentOrder.aspx.cs"
    Inherits="PayPalAPISample.UseCaseSamples.SetExpressCheckoutPaymentOrder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PayPal Merchant SDK - SetExpressCheckoutPaymentOrder</title>
</head>
<body>
    <img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <div id="wrapper">
        <div id="header">
            <h3>SetExpressCheckoutPaymentOrder</h3>
            <div id="apidetails">
                <p>Set the details for express checkout. Payment Type should be set to <b>Order</b> to create Payment Order and Authorized using <b>DoAuthorize</b> API, before it can be captured using <b>DoCapture</b> API.</p>
            </div>
        </div>
        <br />
        <form id="form1" runat="server" method="post">
        <div id="request_form">
            <div class="param_name">
                <b>BuyerMail</b>
            </div>
            <div class="param_value">
                <input type="text" name="buyerMail" value="platfo_1255077030_biz@gmail.com" size="50"
                    maxlength="260" />
            </div>
        </div>
        <br />
        <div class="section_header">
            <b><u>Payment Details:</u> </b>
        </div>
        <br />
        <div class="params">
            <div class="param_name">
                Total Shipping costs</div>
            <div class="param_value">
                <input type="text" name="shippingTotal" id="shippingTotal" value="0.50" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">
                Total insurance cost</div>
            <div class="param_value">
                <input type="text" name="insuranceTotal" id="insuranceTotal" value="" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">
                Total handling cost</div>
            <div class="param_value">
                <input type="text" name="handlingTotal" id="handlingTotal" value="" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">Total Tax</div>
            <div class="param_value">
                <input type="text" name="taxTotal" id="taxTotal" value="" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">Order description</div>
            <div class="param_value">
                <textarea cols="40" rows="5" name="orderDescription"></textarea>
            </div>
        </div>
        <div class="params">
            <div class="param_name">CurrencyCode</div>
            <div class="param_value">
                <input type="text" name="currencyCode" value="USD" size="50" maxlength="260" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">PaymentType</div>
            <div class="param_value">
                <select name="paymentType">
                    <option disabled="disabled" value="AUTHORIZATION">Authorization</option>
                    <option disabled="disabled" value="SALE">Sale</option>
                    <option value="ORDER" selected="selected">Order</option>
                </select>
            </div>
        </div>
        <div class="param_name">
            Item Details</div>
        <table class="params">
            <tr>
                <th class="param_name">
                    Name
                </th>
                <th class="param_name">
                    Cost
                </th>
                <th class="param_name">
                    Quantity
                </th>
                <th class="param_name">
                    Sales tax
                </th>
                <th class="param_name">
                    Item Category
                </th>
                <th class="param_name">
                    Description (optional)
                </th>
            </tr>
            <tr>
                <td>
                    <div class="param_value">
                        <input type="text" name="itemName" id="itemName" value="Item Name" />
                    </div>
                </td>
                <td>
                    <div class="param_value">
                        <input type="text" name="itemAmount" id="itemAmount" value="5.27" />
                    </div>
                </td>
                <td>
                    <div class="param_value">
                        <input type="text" name="itemQuantity" id="itemQuantity" value="2" />
                    </div>
                </td>
                <td>
                    <div class="param_value">
                        <input type="text" name="salesTax" id="salesTax" value="" />
                    </div>
                </td>
                <td>
                    <div class="param_value">
                        <select name="itemCategory">
                            <option value="PHYSICAL">Physical</option>
                            <option value="DIGITAL">Digital</option>
                        </select>
                    </div>
                </td>
                <td>
                    <div class="param_value">
                        <input type="text" name="itemDescription" id="itemDescription" value="" />
                    </div>
                </td>
            </tr>
        </table>
        <div class="params">
            <div class="param_name">
                IPN Notification Url (Receive IPN call back from PayPal)</div>
            <div class="param_value">
                <input type="text" size="50" name="notifyURL" />
            </div>
        </div>
        <br />
        <div class="submit">
            <asp:Button ID="ButtonPayments" Text="SetExpressCheckoutPaymentOrder" runat="server"
                PostBackUrl="~/UseCaseSamples/Payments.ashx" />
        </div>
        <br />
        <a href="../Default.aspx">Home</a>
        </form>
    </div>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoExpressCheckout.aspx.cs"
    Inherits="PayPalAPISample.UseCaseSamples.DoExpressCheckout" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PayPal Merchant SDK - DoExpressCheckout</title>
</head>
<body>
    <img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <div id="wrapper">
        <div id="header">
            <h3>DoExpressCheckout</h3>
            <div id="apidetails">Used to make ExpressCheckout payment. Please select the appropriate Payment Type to be set in SetExpressCheckout.</div>
        </div>
        <br />
        <form id="form1" runat="server" method="post">
        <div id="request_form">
            <div class="params">
                <div class="param_name">Token*(Get Token via SetExpressCheckout)</div>
                <div class="param_value">
                    <input type="text" name="token" value="<%= Token %>" size="50" maxlength="260" readonly="readonly" />
                </div>
            </div>
            <div class="params">
                <div class="param_name">Payer ID*</div>
                <div class="param_value">
                    <input type="text" name="payerID" value="<%= PayerId %>" size="50" maxlength="260"
                        readonly="readonly" />
                </div>
            </div>
            <div class="params">
                <div class="param_name">Payment Type</div>
                <div class="param_value">
                    <select name="paymentType" id="paymentType" runat="server">
                        <option value="AUTHORIZATION">Authorization</option>
                        <option value="SALE">Sale</option>
                        <option value="ORDER">Order</option>
                    </select>
                </div>
            </div>
            <div class="section_header">Payment Details*</div>
            <table class="params">
                <tr>
                    <th class="param_name">
                        Name
                    </th>
                    <th class="param_name">
                        Cost
                    </th>
                    <th class="param_name">
                        Currency Code
                    </th>
                    <th class="param_name">
                        Quantity
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
                            <input type="text" name="amt" id="amt" value="5.27" />
                        </div>
                    </td>
                    <td>
                        <div class="param_value">
                            <input type="text" name="currencyCode" id="currencyCode" value="USD" runat="server"
                                readonly="readonly" />
                        </div>
                    </td>
                    <td>
                        <div class="param_value">
                            <input type="text" name="itemQuantity" id="itemQuantity" value="2" />
                        </div>
                    </td>
                </tr>
            </table>
            <div class="params">
                <div class="param_name">IPN Notification Url (Receive IPN call back from PayPal)</div>
                <div class="param_value">
                    <input type="text" size="50" name="notifyURL" />
                </div>
            </div>
        </div>
        <br />
        <div class="submit">
            <asp:Button ID="ButtonPayments" Text="DoExpressCheckout" runat="server" PostBackUrl="~/UseCaseSamples/Payments.ashx" />
        </div>
        <br />
        <a href="../Default.aspx">Home</a>
        </form>
    </div>
</body>
</html>

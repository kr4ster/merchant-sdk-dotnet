<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParallelPayment.aspx.cs"
    Inherits="PayPalAPISample.UseCaseSamples.ParallelPayment" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <div id="wrapper">
        <div id="header">
            <h3>
                SetExpressCheckout</h3>
            <div id="apidetails">
                Use ExpressCheckout for making payments to multiple receivers</div>
        </div>
        <br />
        <form id="form1" runat="server" method="post">
        <div id="request_form">
            <div class="param_name">
                Buyer email (Email address of the buyer as entered during checkout. PayPal uses
                this value to pre-fill the PayPal membership sign-up portion of the PayPal login
                page)</div>
            <div class="param_value">
                <input type="text" name="buyerEmail" value="platfo_1255077030_biz@gmail.com" size="50"
                    maxlength="260" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">
                Payment Type</div>
            <div class="param_value">
                <select name="paymentType">
                    <option value="Sale">Sale</option>
                    <option value="Authorization">Authorization</option>
                    <option value="Order">Order</option>
                </select>
            </div>
        </div>
        <div class="section_header">
            Payment Details</div>
        <div class="params">
        </div>
        <div class="params">
            <div class="param_name">
                CurrencyCode</div>
            <div class="param_value">
                <input type="text" name="currencyCode" value="USD" size="50" maxlength="260" />
            </div>
        </div>
        <div class="params">
            <div class="param_name">
                Order Total</div>
            <div class="param_value">
                <input type="text" name="orderTotal" id="orderTotal" value="1.00" />
            </div>
        </div>
        <br />
        <div class="param_name">
            Receiver emails.</div>
        <div class="param_value">
            1.<input type="text" name="receiverEmail_0" value="platfo_1255170694_biz@gmail.com"
                size="50" maxlength="260" />
        </div>
        <div class="param_value">
            2.<input type="text" name="receiverEmail_1" value="platfo_1255611349_biz@gmail.com"
                size="50" maxlength="260" />
        </div>
        <br />
        <div class="submit">
            <asp:Button ID="ButtonPayments" Text="ParallelPayment" runat="server" PostBackUrl="~/UseCaseSamples/Payments.ashx" />
        </div>
        <br />
        <a href="../Default.aspx">Home</a>        
        </form>
    </div>
</body>
</html>

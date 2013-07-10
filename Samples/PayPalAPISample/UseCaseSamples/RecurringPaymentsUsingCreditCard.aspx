<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecurringPaymentsUsingCreditCard.aspx.cs" Inherits="PayPalAPISample.UseCaseSamples.RecurringPaymentsUsingCreditCard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <div id="wrapper">
        <div id="header">
            <h3>CreateRecurringPaymentsProfile Using Credit Card</h3>
			<div id="apidetails">
				<p>The CreateRecurringPaymentsProfile API operation creates a
					recurring payments profile. You can directly use Credit Card for
					creating a profile</p>
			</div>
        </div>
        <br />
        <form id="form1" runat="server" method="post">
            <div id="request_form">
               <div class="params">
					<div class="param_name">
						<b><span style="text-decoration: underline">Credit Card * <</span>
						</b>
					</div>
				</div>
				<br />
				<table class="params">
					<tr>
						<th class="param_name">Credit Card number</th>
						<th class="param_name">Expiry date</th>
						<th class="param_name">Buyer Email Id</th>
						<th class="param_name">Credit Card type</th>
						<th class="param_name">CVV</th>
					</tr>
					<tr>
						<td><div class="param_value">
								<input type="text" name="creditCardNumber" id="creditCardNumber"
									value="4917760970795152" />
							</div>
						</td>
						<td><div class="param_value">
								<select name="expMonth">
									<option value="1">Jan</option>
									<option value="2">Feb</option>
									<option value="3">Mar</option>
									<option value="4">Apr</option>
									<option value="5">May</option>
									<option value="6">Jun</option>
									<option value="7">Jul</option>
									<option value="8">Aug</option>
									<option value="9">Sep</option>
									<option value="10">Oct</option>
									<option value="11">Nov</option>
									<option value="12">Dec</option>
								</select> <select name="expYear">
									<option value="2011">2011</option>
									<option value="2012">2012</option>
									<option value="2013">2013</option>
									<option value="2014" selected="selected">2014</option>
									<option value="2015">2015</option>
									<option value="2016">2016</option>
								</select>
							</div>
						</td>
						<td><div class="param_value">
								<input type="text" name="BuyerEmailId" id="BuyerEmailId"
									value="" />
							</div>
						</td>
						<td><div class="param_value">
								<select name="creditCardType">
									<option value="VISA">Visa</option>
									<option value="MASTERCARD">MasterCard</option>
									<option value="DISCOVER">Discover</option>
									<option value="AMEX">Amex</option>
                                    <option value="SWITCH">Switch</option>
									<option value="SOLO">Solo</option>
									<option value="MAESTRO">Maestro</option>

								</select>
							</div>
						</td>
						<td><div class="param_value">
								<input type="text" name="cvv" id="cvv" value="962"/>
							</div>
						</td>
					</tr>
				</table>

				<div class="section_header">Recurring payments profile details</div>
				<div class="param_name">Subscriber Name</div>
				<div class="param_value">
					<input type="text" name="subscriberName" id="subscriberName" />
				</div>
				<div class="param_name">Billing start date</div>
				<div class="param_value">
					<input type="text" name="billingStartDate" id="billingStartDate" runat="server" />
				</div>
				<div class="param_name">Subscriber shipping address (if
					different from buyer's PayPal account address)</div>
				<table class="line_item">
					<tr>
						<th>Name</th>
						<th>Street 1</th>
						<th>Street 2</th>
						<th>City</th>
						<th>State</th>
						<th>Postal Code</th>
						<th>Country</th>
						<th>Phone</th>
					</tr>
					<tr>
						<td><span class="param_value"> <input type="text"
								id="shippingName" name="shippingName" value="" /> </span></td>
						<td><span class="param_value"> <input type="text"
								id="shippingStreet1" name="shippingStreet1" value="" /> </span></td>
						<td><span class="param_value"> <input type="text"
								id="shippingStreet2" name="shippingStreet2" value="" /> </span></td>
						<td><span class="param_value"> <input type="text"
								id="shippingCity" name="shippingCity" value="" /> </span></td>
						<td><span class="param_value"> <input type="text"
								id="shippingState" name="shippingState" value="" /> </span></td>
						<td><span class="param_value"> <input type="text"
								id="shippingPostalCode" name="shippingPostalCode" value="" /> </span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="shippingCountry" name="shippingCountry" value="" /> </span></td>
						<td><span class="param_value"> <input type="text"
								id="shippingPhone" name="shippingPhone" value="" /> </span></td>
					</tr>
				</table>
				<div class="section_header">
					<b><u>Schedule Details:</u> </b>
				</div>
				<div class="params">
					<div class="param_name">Description* </div>
					<div class="param_value">
						<textarea rows="5" cols="60" name="profileDescription">Sample profile description</textarea>
					</div>
				</div>
				<div class="section_header">Activation Details</div>
				<table class="params">
					<tr>
						<th>Initial Amount</th>
						<th>Failed Payment Action</th>
					</tr>
					<tr>
						<td><span class="param_value"> <input
								id="initialAmount" name="initialAmount" /> </span></td>
						<td><span class="param_value"> <select
								name="failedInitialAmountAction">
									<option value="ContinueOnFailure">Continue On Failure</option>
									<option value="CancelOnFailure">Cancel On Failure</option>
							</select> </span></td>
					</tr>
				</table>

				<div class="section_header">
					<b>Trial Period</b>
				</div>
				<table class="params">
					<tr>
						<th>Billing frequency</th>
						<th>Billing period</th>
						<th>Total billing cycles</th>
						<th>Per billing cycle amount</th>
						<th>Shipping amount</th>
						<th>Tax</th>
					</tr>
					<tr>
						<td>
                            <span class="param_value"> 
                                <input type="text" id="trialBillingFrequency" name="trialBillingFrequency" value="1" /> 
                            </span>
						</td>
						<td>
                            <span class="param_value"> 
                                <select name="trialBillingPeriod">
                                    <option value="NOBILLINGPERIODTYPE">NoBillingPeriodType</option>
									<option value="DAY" selected="selected">Day</option>
									<option value="WEEK">Week</option>
									<option value="SemiMonth">SemiMonth</option>
									<option value="Month">Month</option>
									<option value="Year">Year</option>
							    </select> 
                            </span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="trialBillingCycles" name="trialBillingCycles" value="2" />
						</span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="trialBillingAmount" name="trialBillingAmount" value="2.0" />
						</span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="trialShippingAmount" name="trialShippingAmount" value="0.0" />
						</span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="trialTaxAmount" name="trialTaxAmount" value="0.0" /> </span>
						</td>
					</tr>
				</table>

				<div class="section_header">
					<b>Payment Period *</b>
				</div>
				<table class="params_name">
					<tr>
						<th>Billing frequency</th>
						<th>Billing period</th>
						<th>Total billing cycles</th>
						<th>Per billing cycle amount</th>
						<th>Shipping amount</th>
						<th>Tax</th>
					</tr>
					<tr>
						<td>
                        <span class="param_value"> 
                            <input type="text" id="billingFrequency" name="billingFrequency" value="1" /> 
                        </span>
						</td>						
                        <td>
                            <span class="param_value"> 
                                <select name="billingPeriod">
                                    <option value="NOBILLINGPERIODTYPE">NoBillingPeriodType</option>
									<option value="DAY" selected="selected">Day</option>
									<option value="WEEK">Week</option>
									<option value="SemiMonth">SemiMonth</option>
									<option value="Month">Month</option>
									<option value="Year">Year</option>
							    </select> 
                            </span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="totalBillingCycles" name="totalBillingCycles" value="8" />
						</span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="billingAmount" name="billingAmount" value="5.0" /> </span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="shippingAmount" name="shippingAmount" value="1.0" /> </span>
						</td>
						<td><span class="param_value"> <input type="text"
								id="taxAmount" name="taxAmount" value="0.0" /> </span>
						</td>
					</tr>
				</table>
				<div class="params">
					<div class="param_name">Maximum failed payments before
						profile suspension</div>
					<div class="param_value">
						<input type="text" name="maxFailedPayments" id="maxFailedPayments"
							value="3" />
					</div>
				</div>
				<div class="param_name">Auto billing of outstanding amount</div>
				<div class="param_value">
					<select name="autoBillOutstandingAmount">
						<option value="NOAUTOBILL">No Auto billing</option>
						<option value="ADDTONEXTBILLING">Add to next billing</option>
					</select>
				</div>
				<br />
				<div class="submit">
                    <asp:Button ID="ButtonPayments" Text="CreateRecurringPaymentsProfile"  runat="server" PostBackUrl="~/UseCaseSamples/Payments.ashx" />
				</div>
				<br />
                <a href="../Default.aspx">Home</a>
            </div>
        </form>
    </div>
</body>
</html>

using System;

namespace PayPalAPISample.UseCaseSamples
{
    public partial class RecurringPaymentsUsingCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            billingStartDate.Value = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web;
using System.Collections.Specialized;

namespace PayPalAPISample.UseCaseSamples
{
    public partial class DoExpressCheckout : System.Web.UI.Page
    {
        private string ecToken;
        public string Token
        {
            get
            {
                return this.ecToken;

            }
            set
            {
                this.ecToken = value;
            }
        }

        private string PayerIdentity;
        public string PayerId
        {
            get
            {
                return this.PayerIdentity;

            }
            set
            {
                this.PayerIdentity = value;
            }
        }
              

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Context.Request.QueryString["token"] != null)
                {
                    Token = Request.QueryString["token"];
                }
                if (Context.Request.QueryString["PayerID"] != null)
                {
                    PayerId = Request.QueryString["PayerID"];
                }
                if (Context.Request.QueryString["currencyCodeType"] != null)
                {
                    currencyCode.Value = Request.QueryString["currencyCodeType"];
                }
                if (Context.Request.QueryString["paymentType"] != null)
                {
                    paymentType.Value = Request.QueryString["paymentType"];
                }
            }
        }        
    }
}
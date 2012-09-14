using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.PayPalAPIInterfaceService.Model;

namespace PayPal.PayPalAPIInterfaceService {
	public partial class PayPalAPIInterfaceServiceService : BasePayPalService {

		// Service Version
		private static string ServiceVersion = "93.0";

		// Service Name
		private static string ServiceName = "PayPalAPIInterfaceService";

		public PayPalAPIInterfaceServiceService() : base(ServiceName, ServiceVersion)
		{
		}
	
		private void setStandardParams(AbstractRequestType request) {
			if (request.Version == null)
			{
				request.Version = ServiceVersion;
			}
			if (request.ErrorLanguage != null && ConfigManager.Instance.GetProperty("languageCode") != null)
			{
				request.ErrorLanguage = ConfigManager.Instance.GetProperty("languageCode");
			}
		}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public RefundTransactionResponseType RefundTransaction(RefundTransactionReq RefundTransactionReq, string apiUsername)
	 	{
			setStandardParams(RefundTransactionReq.RefundTransactionRequest);
			string response = call("RefundTransaction", RefundTransactionReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='RefundTransactionResponse']");
			return new RefundTransactionResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public RefundTransactionResponseType RefundTransaction(RefundTransactionReq RefundTransactionReq)
	 	{
	 		return RefundTransaction(RefundTransactionReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public InitiateRecoupResponseType InitiateRecoup(InitiateRecoupReq InitiateRecoupReq, string apiUsername)
	 	{
			setStandardParams(InitiateRecoupReq.InitiateRecoupRequest);
			string response = call("InitiateRecoup", InitiateRecoupReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='InitiateRecoupResponse']");
			return new InitiateRecoupResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public InitiateRecoupResponseType InitiateRecoup(InitiateRecoupReq InitiateRecoupReq)
	 	{
	 		return InitiateRecoup(InitiateRecoupReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CompleteRecoupResponseType CompleteRecoup(CompleteRecoupReq CompleteRecoupReq, string apiUsername)
	 	{
			setStandardParams(CompleteRecoupReq.CompleteRecoupRequest);
			string response = call("CompleteRecoup", CompleteRecoupReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='CompleteRecoupResponse']");
			return new CompleteRecoupResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CompleteRecoupResponseType CompleteRecoup(CompleteRecoupReq CompleteRecoupReq)
	 	{
	 		return CompleteRecoup(CompleteRecoupReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CancelRecoupResponseType CancelRecoup(CancelRecoupReq CancelRecoupReq, string apiUsername)
	 	{
			setStandardParams(CancelRecoupReq.CancelRecoupRequest);
			string response = call("CancelRecoup", CancelRecoupReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='CancelRecoupResponse']");
			return new CancelRecoupResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CancelRecoupResponseType CancelRecoup(CancelRecoupReq CancelRecoupReq)
	 	{
	 		return CancelRecoup(CancelRecoupReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetTransactionDetailsResponseType GetTransactionDetails(GetTransactionDetailsReq GetTransactionDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetTransactionDetailsReq.GetTransactionDetailsRequest);
			string response = call("GetTransactionDetails", GetTransactionDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetTransactionDetailsResponse']");
			return new GetTransactionDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetTransactionDetailsResponseType GetTransactionDetails(GetTransactionDetailsReq GetTransactionDetailsReq)
	 	{
	 		return GetTransactionDetails(GetTransactionDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public BillUserResponseType BillUser(BillUserReq BillUserReq, string apiUsername)
	 	{
			setStandardParams(BillUserReq.BillUserRequest);
			string response = call("BillUser", BillUserReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BillUserResponse']");
			return new BillUserResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public BillUserResponseType BillUser(BillUserReq BillUserReq)
	 	{
	 		return BillUser(BillUserReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public TransactionSearchResponseType TransactionSearch(TransactionSearchReq TransactionSearchReq, string apiUsername)
	 	{
			setStandardParams(TransactionSearchReq.TransactionSearchRequest);
			string response = call("TransactionSearch", TransactionSearchReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='TransactionSearchResponse']");
			return new TransactionSearchResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public TransactionSearchResponseType TransactionSearch(TransactionSearchReq TransactionSearchReq)
	 	{
	 		return TransactionSearch(TransactionSearchReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public MassPayResponseType MassPay(MassPayReq MassPayReq, string apiUsername)
	 	{
			setStandardParams(MassPayReq.MassPayRequest);
			string response = call("MassPay", MassPayReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='MassPayResponse']");
			return new MassPayResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public MassPayResponseType MassPay(MassPayReq MassPayReq)
	 	{
	 		return MassPay(MassPayReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public BAUpdateResponseType BillAgreementUpdate(BillAgreementUpdateReq BillAgreementUpdateReq, string apiUsername)
	 	{
			setStandardParams(BillAgreementUpdateReq.BAUpdateRequest);
			string response = call("BillAgreementUpdate", BillAgreementUpdateReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BAUpdateResponse']");
			return new BAUpdateResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public BAUpdateResponseType BillAgreementUpdate(BillAgreementUpdateReq BillAgreementUpdateReq)
	 	{
	 		return BillAgreementUpdate(BillAgreementUpdateReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public AddressVerifyResponseType AddressVerify(AddressVerifyReq AddressVerifyReq, string apiUsername)
	 	{
			setStandardParams(AddressVerifyReq.AddressVerifyRequest);
			string response = call("AddressVerify", AddressVerifyReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='AddressVerifyResponse']");
			return new AddressVerifyResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public AddressVerifyResponseType AddressVerify(AddressVerifyReq AddressVerifyReq)
	 	{
	 		return AddressVerify(AddressVerifyReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public EnterBoardingResponseType EnterBoarding(EnterBoardingReq EnterBoardingReq, string apiUsername)
	 	{
			setStandardParams(EnterBoardingReq.EnterBoardingRequest);
			string response = call("EnterBoarding", EnterBoardingReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='EnterBoardingResponse']");
			return new EnterBoardingResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public EnterBoardingResponseType EnterBoarding(EnterBoardingReq EnterBoardingReq)
	 	{
	 		return EnterBoarding(EnterBoardingReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBoardingDetailsResponseType GetBoardingDetails(GetBoardingDetailsReq GetBoardingDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetBoardingDetailsReq.GetBoardingDetailsRequest);
			string response = call("GetBoardingDetails", GetBoardingDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetBoardingDetailsResponse']");
			return new GetBoardingDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetBoardingDetailsResponseType GetBoardingDetails(GetBoardingDetailsReq GetBoardingDetailsReq)
	 	{
	 		return GetBoardingDetails(GetBoardingDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateMobilePaymentResponseType CreateMobilePayment(CreateMobilePaymentReq CreateMobilePaymentReq, string apiUsername)
	 	{
			setStandardParams(CreateMobilePaymentReq.CreateMobilePaymentRequest);
			string response = call("CreateMobilePayment", CreateMobilePaymentReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='CreateMobilePaymentResponse']");
			return new CreateMobilePaymentResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateMobilePaymentResponseType CreateMobilePayment(CreateMobilePaymentReq CreateMobilePaymentReq)
	 	{
	 		return CreateMobilePayment(CreateMobilePaymentReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetMobileStatusResponseType GetMobileStatus(GetMobileStatusReq GetMobileStatusReq, string apiUsername)
	 	{
			setStandardParams(GetMobileStatusReq.GetMobileStatusRequest);
			string response = call("GetMobileStatus", GetMobileStatusReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetMobileStatusResponse']");
			return new GetMobileStatusResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetMobileStatusResponseType GetMobileStatus(GetMobileStatusReq GetMobileStatusReq)
	 	{
	 		return GetMobileStatus(GetMobileStatusReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetMobileCheckoutResponseType SetMobileCheckout(SetMobileCheckoutReq SetMobileCheckoutReq, string apiUsername)
	 	{
			setStandardParams(SetMobileCheckoutReq.SetMobileCheckoutRequest);
			string response = call("SetMobileCheckout", SetMobileCheckoutReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='SetMobileCheckoutResponse']");
			return new SetMobileCheckoutResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetMobileCheckoutResponseType SetMobileCheckout(SetMobileCheckoutReq SetMobileCheckoutReq)
	 	{
	 		return SetMobileCheckout(SetMobileCheckoutReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoMobileCheckoutPaymentResponseType DoMobileCheckoutPayment(DoMobileCheckoutPaymentReq DoMobileCheckoutPaymentReq, string apiUsername)
	 	{
			setStandardParams(DoMobileCheckoutPaymentReq.DoMobileCheckoutPaymentRequest);
			string response = call("DoMobileCheckoutPayment", DoMobileCheckoutPaymentReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoMobileCheckoutPaymentResponse']");
			return new DoMobileCheckoutPaymentResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoMobileCheckoutPaymentResponseType DoMobileCheckoutPayment(DoMobileCheckoutPaymentReq DoMobileCheckoutPaymentReq)
	 	{
	 		return DoMobileCheckoutPayment(DoMobileCheckoutPaymentReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBalanceResponseType GetBalance(GetBalanceReq GetBalanceReq, string apiUsername)
	 	{
			setStandardParams(GetBalanceReq.GetBalanceRequest);
			string response = call("GetBalance", GetBalanceReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetBalanceResponse']");
			return new GetBalanceResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetBalanceResponseType GetBalance(GetBalanceReq GetBalanceReq)
	 	{
	 		return GetBalance(GetBalanceReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetPalDetailsResponseType GetPalDetails(GetPalDetailsReq GetPalDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetPalDetailsReq.GetPalDetailsRequest);
			string response = call("GetPalDetails", GetPalDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetPalDetailsResponse']");
			return new GetPalDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetPalDetailsResponseType GetPalDetails(GetPalDetailsReq GetPalDetailsReq)
	 	{
	 		return GetPalDetails(GetPalDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoExpressCheckoutPaymentResponseType DoExpressCheckoutPayment(DoExpressCheckoutPaymentReq DoExpressCheckoutPaymentReq, string apiUsername)
	 	{
			setStandardParams(DoExpressCheckoutPaymentReq.DoExpressCheckoutPaymentRequest);
			string response = call("DoExpressCheckoutPayment", DoExpressCheckoutPaymentReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoExpressCheckoutPaymentResponse']");
			return new DoExpressCheckoutPaymentResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoExpressCheckoutPaymentResponseType DoExpressCheckoutPayment(DoExpressCheckoutPaymentReq DoExpressCheckoutPaymentReq)
	 	{
	 		return DoExpressCheckoutPayment(DoExpressCheckoutPaymentReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoUATPExpressCheckoutPaymentResponseType DoUATPExpressCheckoutPayment(DoUATPExpressCheckoutPaymentReq DoUATPExpressCheckoutPaymentReq, string apiUsername)
	 	{
			setStandardParams(DoUATPExpressCheckoutPaymentReq.DoUATPExpressCheckoutPaymentRequest);
			string response = call("DoUATPExpressCheckoutPayment", DoUATPExpressCheckoutPaymentReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoUATPExpressCheckoutPaymentResponse']");
			return new DoUATPExpressCheckoutPaymentResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoUATPExpressCheckoutPaymentResponseType DoUATPExpressCheckoutPayment(DoUATPExpressCheckoutPaymentReq DoUATPExpressCheckoutPaymentReq)
	 	{
	 		return DoUATPExpressCheckoutPayment(DoUATPExpressCheckoutPaymentReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetAuthFlowParamResponseType SetAuthFlowParam(SetAuthFlowParamReq SetAuthFlowParamReq, string apiUsername)
	 	{
			setStandardParams(SetAuthFlowParamReq.SetAuthFlowParamRequest);
			string response = call("SetAuthFlowParam", SetAuthFlowParamReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='SetAuthFlowParamResponse']");
			return new SetAuthFlowParamResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetAuthFlowParamResponseType SetAuthFlowParam(SetAuthFlowParamReq SetAuthFlowParamReq)
	 	{
	 		return SetAuthFlowParam(SetAuthFlowParamReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAuthDetailsResponseType GetAuthDetails(GetAuthDetailsReq GetAuthDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetAuthDetailsReq.GetAuthDetailsRequest);
			string response = call("GetAuthDetails", GetAuthDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetAuthDetailsResponse']");
			return new GetAuthDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAuthDetailsResponseType GetAuthDetails(GetAuthDetailsReq GetAuthDetailsReq)
	 	{
	 		return GetAuthDetails(GetAuthDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetAccessPermissionsResponseType SetAccessPermissions(SetAccessPermissionsReq SetAccessPermissionsReq, string apiUsername)
	 	{
			setStandardParams(SetAccessPermissionsReq.SetAccessPermissionsRequest);
			string response = call("SetAccessPermissions", SetAccessPermissionsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='SetAccessPermissionsResponse']");
			return new SetAccessPermissionsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetAccessPermissionsResponseType SetAccessPermissions(SetAccessPermissionsReq SetAccessPermissionsReq)
	 	{
	 		return SetAccessPermissions(SetAccessPermissionsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public UpdateAccessPermissionsResponseType UpdateAccessPermissions(UpdateAccessPermissionsReq UpdateAccessPermissionsReq, string apiUsername)
	 	{
			setStandardParams(UpdateAccessPermissionsReq.UpdateAccessPermissionsRequest);
			string response = call("UpdateAccessPermissions", UpdateAccessPermissionsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='UpdateAccessPermissionsResponse']");
			return new UpdateAccessPermissionsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public UpdateAccessPermissionsResponseType UpdateAccessPermissions(UpdateAccessPermissionsReq UpdateAccessPermissionsReq)
	 	{
	 		return UpdateAccessPermissions(UpdateAccessPermissionsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetAccessPermissionDetailsResponseType GetAccessPermissionDetails(GetAccessPermissionDetailsReq GetAccessPermissionDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetAccessPermissionDetailsReq.GetAccessPermissionDetailsRequest);
			string response = call("GetAccessPermissionDetails", GetAccessPermissionDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetAccessPermissionDetailsResponse']");
			return new GetAccessPermissionDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetAccessPermissionDetailsResponseType GetAccessPermissionDetails(GetAccessPermissionDetailsReq GetAccessPermissionDetailsReq)
	 	{
	 		return GetAccessPermissionDetails(GetAccessPermissionDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetIncentiveEvaluationResponseType GetIncentiveEvaluation(GetIncentiveEvaluationReq GetIncentiveEvaluationReq, string apiUsername)
	 	{
			setStandardParams(GetIncentiveEvaluationReq.GetIncentiveEvaluationRequest);
			string response = call("GetIncentiveEvaluation", GetIncentiveEvaluationReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetIncentiveEvaluationResponse']");
			return new GetIncentiveEvaluationResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetIncentiveEvaluationResponseType GetIncentiveEvaluation(GetIncentiveEvaluationReq GetIncentiveEvaluationReq)
	 	{
	 		return GetIncentiveEvaluation(GetIncentiveEvaluationReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetExpressCheckoutResponseType SetExpressCheckout(SetExpressCheckoutReq SetExpressCheckoutReq, string apiUsername)
	 	{
			setStandardParams(SetExpressCheckoutReq.SetExpressCheckoutRequest);
			string response = call("SetExpressCheckout", SetExpressCheckoutReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='SetExpressCheckoutResponse']");
			return new SetExpressCheckoutResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetExpressCheckoutResponseType SetExpressCheckout(SetExpressCheckoutReq SetExpressCheckoutReq)
	 	{
	 		return SetExpressCheckout(SetExpressCheckoutReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ExecuteCheckoutOperationsResponseType ExecuteCheckoutOperations(ExecuteCheckoutOperationsReq ExecuteCheckoutOperationsReq, string apiUsername)
	 	{
			setStandardParams(ExecuteCheckoutOperationsReq.ExecuteCheckoutOperationsRequest);
			string response = call("ExecuteCheckoutOperations", ExecuteCheckoutOperationsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='ExecuteCheckoutOperationsResponse']");
			return new ExecuteCheckoutOperationsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ExecuteCheckoutOperationsResponseType ExecuteCheckoutOperations(ExecuteCheckoutOperationsReq ExecuteCheckoutOperationsReq)
	 	{
	 		return ExecuteCheckoutOperations(ExecuteCheckoutOperationsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetExpressCheckoutDetailsResponseType GetExpressCheckoutDetails(GetExpressCheckoutDetailsReq GetExpressCheckoutDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetExpressCheckoutDetailsReq.GetExpressCheckoutDetailsRequest);
			string response = call("GetExpressCheckoutDetails", GetExpressCheckoutDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetExpressCheckoutDetailsResponse']");
			return new GetExpressCheckoutDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetExpressCheckoutDetailsResponseType GetExpressCheckoutDetails(GetExpressCheckoutDetailsReq GetExpressCheckoutDetailsReq)
	 	{
	 		return GetExpressCheckoutDetails(GetExpressCheckoutDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoDirectPaymentResponseType DoDirectPayment(DoDirectPaymentReq DoDirectPaymentReq, string apiUsername)
	 	{
			setStandardParams(DoDirectPaymentReq.DoDirectPaymentRequest);
			string response = call("DoDirectPayment", DoDirectPaymentReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoDirectPaymentResponse']");
			return new DoDirectPaymentResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoDirectPaymentResponseType DoDirectPayment(DoDirectPaymentReq DoDirectPaymentReq)
	 	{
	 		return DoDirectPayment(DoDirectPaymentReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ManagePendingTransactionStatusResponseType ManagePendingTransactionStatus(ManagePendingTransactionStatusReq ManagePendingTransactionStatusReq, string apiUsername)
	 	{
			setStandardParams(ManagePendingTransactionStatusReq.ManagePendingTransactionStatusRequest);
			string response = call("ManagePendingTransactionStatus", ManagePendingTransactionStatusReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='ManagePendingTransactionStatusResponse']");
			return new ManagePendingTransactionStatusResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ManagePendingTransactionStatusResponseType ManagePendingTransactionStatus(ManagePendingTransactionStatusReq ManagePendingTransactionStatusReq)
	 	{
	 		return ManagePendingTransactionStatus(ManagePendingTransactionStatusReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoCancelResponseType DoCancel(DoCancelReq DoCancelReq, string apiUsername)
	 	{
			setStandardParams(DoCancelReq.DoCancelRequest);
			string response = call("DoCancel", DoCancelReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoCancelResponse']");
			return new DoCancelResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoCancelResponseType DoCancel(DoCancelReq DoCancelReq)
	 	{
	 		return DoCancel(DoCancelReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoCaptureResponseType DoCapture(DoCaptureReq DoCaptureReq, string apiUsername)
	 	{
			setStandardParams(DoCaptureReq.DoCaptureRequest);
			string response = call("DoCapture", DoCaptureReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoCaptureResponse']");
			return new DoCaptureResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoCaptureResponseType DoCapture(DoCaptureReq DoCaptureReq)
	 	{
	 		return DoCapture(DoCaptureReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoReauthorizationResponseType DoReauthorization(DoReauthorizationReq DoReauthorizationReq, string apiUsername)
	 	{
			setStandardParams(DoReauthorizationReq.DoReauthorizationRequest);
			string response = call("DoReauthorization", DoReauthorizationReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoReauthorizationResponse']");
			return new DoReauthorizationResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoReauthorizationResponseType DoReauthorization(DoReauthorizationReq DoReauthorizationReq)
	 	{
	 		return DoReauthorization(DoReauthorizationReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoVoidResponseType DoVoid(DoVoidReq DoVoidReq, string apiUsername)
	 	{
			setStandardParams(DoVoidReq.DoVoidRequest);
			string response = call("DoVoid", DoVoidReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoVoidResponse']");
			return new DoVoidResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoVoidResponseType DoVoid(DoVoidReq DoVoidReq)
	 	{
	 		return DoVoid(DoVoidReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoAuthorizationResponseType DoAuthorization(DoAuthorizationReq DoAuthorizationReq, string apiUsername)
	 	{
			setStandardParams(DoAuthorizationReq.DoAuthorizationRequest);
			string response = call("DoAuthorization", DoAuthorizationReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoAuthorizationResponse']");
			return new DoAuthorizationResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoAuthorizationResponseType DoAuthorization(DoAuthorizationReq DoAuthorizationReq)
	 	{
	 		return DoAuthorization(DoAuthorizationReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public SetCustomerBillingAgreementResponseType SetCustomerBillingAgreement(SetCustomerBillingAgreementReq SetCustomerBillingAgreementReq, string apiUsername)
	 	{
			setStandardParams(SetCustomerBillingAgreementReq.SetCustomerBillingAgreementRequest);
			string response = call("SetCustomerBillingAgreement", SetCustomerBillingAgreementReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='SetCustomerBillingAgreementResponse']");
			return new SetCustomerBillingAgreementResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public SetCustomerBillingAgreementResponseType SetCustomerBillingAgreement(SetCustomerBillingAgreementReq SetCustomerBillingAgreementReq)
	 	{
	 		return SetCustomerBillingAgreement(SetCustomerBillingAgreementReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetBillingAgreementCustomerDetailsResponseType GetBillingAgreementCustomerDetails(GetBillingAgreementCustomerDetailsReq GetBillingAgreementCustomerDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetBillingAgreementCustomerDetailsReq.GetBillingAgreementCustomerDetailsRequest);
			string response = call("GetBillingAgreementCustomerDetails", GetBillingAgreementCustomerDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetBillingAgreementCustomerDetailsResponse']");
			return new GetBillingAgreementCustomerDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetBillingAgreementCustomerDetailsResponseType GetBillingAgreementCustomerDetails(GetBillingAgreementCustomerDetailsReq GetBillingAgreementCustomerDetailsReq)
	 	{
	 		return GetBillingAgreementCustomerDetails(GetBillingAgreementCustomerDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateBillingAgreementResponseType CreateBillingAgreement(CreateBillingAgreementReq CreateBillingAgreementReq, string apiUsername)
	 	{
			setStandardParams(CreateBillingAgreementReq.CreateBillingAgreementRequest);
			string response = call("CreateBillingAgreement", CreateBillingAgreementReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='CreateBillingAgreementResponse']");
			return new CreateBillingAgreementResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateBillingAgreementResponseType CreateBillingAgreement(CreateBillingAgreementReq CreateBillingAgreementReq)
	 	{
	 		return CreateBillingAgreement(CreateBillingAgreementReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoReferenceTransactionResponseType DoReferenceTransaction(DoReferenceTransactionReq DoReferenceTransactionReq, string apiUsername)
	 	{
			setStandardParams(DoReferenceTransactionReq.DoReferenceTransactionRequest);
			string response = call("DoReferenceTransaction", DoReferenceTransactionReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoReferenceTransactionResponse']");
			return new DoReferenceTransactionResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoReferenceTransactionResponseType DoReferenceTransaction(DoReferenceTransactionReq DoReferenceTransactionReq)
	 	{
	 		return DoReferenceTransaction(DoReferenceTransactionReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoNonReferencedCreditResponseType DoNonReferencedCredit(DoNonReferencedCreditReq DoNonReferencedCreditReq, string apiUsername)
	 	{
			setStandardParams(DoNonReferencedCreditReq.DoNonReferencedCreditRequest);
			string response = call("DoNonReferencedCredit", DoNonReferencedCreditReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoNonReferencedCreditResponse']");
			return new DoNonReferencedCreditResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoNonReferencedCreditResponseType DoNonReferencedCredit(DoNonReferencedCreditReq DoNonReferencedCreditReq)
	 	{
	 		return DoNonReferencedCredit(DoNonReferencedCreditReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public DoUATPAuthorizationResponseType DoUATPAuthorization(DoUATPAuthorizationReq DoUATPAuthorizationReq, string apiUsername)
	 	{
			setStandardParams(DoUATPAuthorizationReq.DoUATPAuthorizationRequest);
			string response = call("DoUATPAuthorization", DoUATPAuthorizationReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='DoUATPAuthorizationResponse']");
			return new DoUATPAuthorizationResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public DoUATPAuthorizationResponseType DoUATPAuthorization(DoUATPAuthorizationReq DoUATPAuthorizationReq)
	 	{
	 		return DoUATPAuthorization(DoUATPAuthorizationReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public CreateRecurringPaymentsProfileResponseType CreateRecurringPaymentsProfile(CreateRecurringPaymentsProfileReq CreateRecurringPaymentsProfileReq, string apiUsername)
	 	{
			setStandardParams(CreateRecurringPaymentsProfileReq.CreateRecurringPaymentsProfileRequest);
			string response = call("CreateRecurringPaymentsProfile", CreateRecurringPaymentsProfileReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='CreateRecurringPaymentsProfileResponse']");
			return new CreateRecurringPaymentsProfileResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public CreateRecurringPaymentsProfileResponseType CreateRecurringPaymentsProfile(CreateRecurringPaymentsProfileReq CreateRecurringPaymentsProfileReq)
	 	{
	 		return CreateRecurringPaymentsProfile(CreateRecurringPaymentsProfileReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public GetRecurringPaymentsProfileDetailsResponseType GetRecurringPaymentsProfileDetails(GetRecurringPaymentsProfileDetailsReq GetRecurringPaymentsProfileDetailsReq, string apiUsername)
	 	{
			setStandardParams(GetRecurringPaymentsProfileDetailsReq.GetRecurringPaymentsProfileDetailsRequest);
			string response = call("GetRecurringPaymentsProfileDetails", GetRecurringPaymentsProfileDetailsReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='GetRecurringPaymentsProfileDetailsResponse']");
			return new GetRecurringPaymentsProfileDetailsResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public GetRecurringPaymentsProfileDetailsResponseType GetRecurringPaymentsProfileDetails(GetRecurringPaymentsProfileDetailsReq GetRecurringPaymentsProfileDetailsReq)
	 	{
	 		return GetRecurringPaymentsProfileDetails(GetRecurringPaymentsProfileDetailsReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ManageRecurringPaymentsProfileStatusResponseType ManageRecurringPaymentsProfileStatus(ManageRecurringPaymentsProfileStatusReq ManageRecurringPaymentsProfileStatusReq, string apiUsername)
	 	{
			setStandardParams(ManageRecurringPaymentsProfileStatusReq.ManageRecurringPaymentsProfileStatusRequest);
			string response = call("ManageRecurringPaymentsProfileStatus", ManageRecurringPaymentsProfileStatusReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='ManageRecurringPaymentsProfileStatusResponse']");
			return new ManageRecurringPaymentsProfileStatusResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ManageRecurringPaymentsProfileStatusResponseType ManageRecurringPaymentsProfileStatus(ManageRecurringPaymentsProfileStatusReq ManageRecurringPaymentsProfileStatusReq)
	 	{
	 		return ManageRecurringPaymentsProfileStatus(ManageRecurringPaymentsProfileStatusReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public BillOutstandingAmountResponseType BillOutstandingAmount(BillOutstandingAmountReq BillOutstandingAmountReq, string apiUsername)
	 	{
			setStandardParams(BillOutstandingAmountReq.BillOutstandingAmountRequest);
			string response = call("BillOutstandingAmount", BillOutstandingAmountReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='BillOutstandingAmountResponse']");
			return new BillOutstandingAmountResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public BillOutstandingAmountResponseType BillOutstandingAmount(BillOutstandingAmountReq BillOutstandingAmountReq)
	 	{
	 		return BillOutstandingAmount(BillOutstandingAmountReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public UpdateRecurringPaymentsProfileResponseType UpdateRecurringPaymentsProfile(UpdateRecurringPaymentsProfileReq UpdateRecurringPaymentsProfileReq, string apiUsername)
	 	{
			setStandardParams(UpdateRecurringPaymentsProfileReq.UpdateRecurringPaymentsProfileRequest);
			string response = call("UpdateRecurringPaymentsProfile", UpdateRecurringPaymentsProfileReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='UpdateRecurringPaymentsProfileResponse']");
			return new UpdateRecurringPaymentsProfileResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public UpdateRecurringPaymentsProfileResponseType UpdateRecurringPaymentsProfile(UpdateRecurringPaymentsProfileReq UpdateRecurringPaymentsProfileReq)
	 	{
	 		return UpdateRecurringPaymentsProfile(UpdateRecurringPaymentsProfileReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ReverseTransactionResponseType ReverseTransaction(ReverseTransactionReq ReverseTransactionReq, string apiUsername)
	 	{
			setStandardParams(ReverseTransactionReq.ReverseTransactionRequest);
			string response = call("ReverseTransaction", ReverseTransactionReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='ReverseTransactionResponse']");
			return new ReverseTransactionResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ReverseTransactionResponseType ReverseTransaction(ReverseTransactionReq ReverseTransactionReq)
	 	{
	 		return ReverseTransaction(ReverseTransactionReq, null);
	 	}

		/**	
          *AUTO_GENERATED
	 	  */
	 	public ExternalRememberMeOptOutResponseType ExternalRememberMeOptOut(ExternalRememberMeOptOutReq ExternalRememberMeOptOutReq, string apiUsername)
	 	{
			setStandardParams(ExternalRememberMeOptOutReq.ExternalRememberMeOptOutRequest);
			string response = call("ExternalRememberMeOptOut", ExternalRememberMeOptOutReq.toXMLString(), apiUsername);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(response);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("*[local-name()='Envelope']/*[local-name()='Body']/*[local-name()='ExternalRememberMeOptOutResponse']");
			return new ExternalRememberMeOptOutResponseType(xmlNode);
			
	 	}
	 
	 	/** 
          *AUTO_GENERATED
	 	  */
	 	public ExternalRememberMeOptOutResponseType ExternalRememberMeOptOut(ExternalRememberMeOptOutReq ExternalRememberMeOptOutReq)
	 	{
	 		return ExternalRememberMeOptOut(ExternalRememberMeOptOutReq, null);
	 	}
	}
}

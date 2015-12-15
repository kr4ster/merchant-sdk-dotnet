# PayPal Merchant SDK for .NET

#### This Classic SDK is not actively supported and will be deprecated in the future. For full support on new integrations, please use the [PayPal REST API SDK for .NET](https://github.com/paypal/rest-api-sdk-dotnet)

## TLSv1.2 Update
> **The [PCIv3.1 DSS (PDF)](https://www.pcisecuritystandards.org/documents/PCI_DSS_v3-1.pdf) mandates (p.46) that TLSv1.0 be retired from service by June 30, 2016. All organizations that handle credit card information are required to comply with this standard. As part of this obligation, PayPal is updating its services to require TLSv1.2 for all HTTPS connections. [Click here](https://github.com/paypal/tls-update) for more information.**

> A new `mode` has been created to test if your server/machine handles TLSv1.2 connections. Please use `security-test-sandbox` mode instead of `sandbox` to verify. You can return back to `sandbox` mode once you have verified.


The repository contains the PayPal Merchant SDK C#.NET Class Library Application and the PayPalAPISample Sample ASP.NET C# Web Application.


## SDK Integration

*	Integrate the PayPal Merchant SDK with an ASP.NET Web Application

*	Use NuGet to install the 'PayPalMerchantSDK' package 

*	The NuGet package installs the dependencies to the solution and automatically updates the project

*	Dependent library references:
	•	'log4net.dll'
	•	'PayPalCoreSDK.dll'	
	•	'PayPalMerchantSDK.dll'
	•	'PayPalPermissionsSDK.dll'
	
*	Namespaces:
	•	PayPal
	•	PayPal.PayPalAPIInterfaceService
	•	PayPal.PayPalAPIInterfaceService.Model
	•	PayPal.Util
	•	PayPal.Exception

## Using Classic SDKs and PayPal .NET SDK

If you need to use one of the Classic SDKs along with the [PayPal .NET SDK](https://github.com/paypal/PayPal-NET-SDK) (which uses PayPal's REST APIs), then you will need to do the following to your project to allow everything to work properly:

1. Update your project's **web.config** to the following:

  ````xml
<configuration>
  <configSections>
    <section name="paypal" type="PayPal.SDKConfigHandler, PayPal" />
  </configSections>

  <!-- PayPal SDK settings -->
  <paypal>
    <settings>
      <add name="mode" value="sandbox"/>
      
      <!-- REST API credentials -->
      <add name="clientId" value="_client_Id_"/>
      <add name="clientSecret" value="_client_secret_"/>
    
      <!-- Classic API credentials -->
      <add name="account1.apiUsername" value="_api_username_"/>
      <add name="account1.apiPassword" value="_api_password_"/>
    </settings>
  </paypal>
</configuration>
````

2. When creating the main services object for any of the Classic SDKs, first create the `config` to be used by the service using the `ConfigManager` instance from the `PayPal.Api` namespace.  Then pass that `config` object into the constructor for the Classic SDK service object:

  ````csharp
// Get the config properties from PayPal.Api.ConfigManager
Dictionary<string, string> config = PayPal.Api.ConfigManager.Instance.GetProperties();

// Create the Classic SDK service instance to use.
PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(config);
````

	
## Help

*	Merchant.bat - Automation script that builds the PayPal Merchant SDK C#.NET Class Library Application in release mode and copies the built dlls to the lib folder in the PayPalAPISample Sample ASP.NET C# Web Application

*	Changelog.txt - Release Notes

*	DotNetSDK.SandcastleGUI - Tool to create the documentation of the PayPal Merchant SDK

*	LICENSE.txt - PayPal, Inc. SDK License

*	Installing NuGet in Visual Studio 2010 and 2012.pdf - Guide to Install NuGet in Visual Studio 2010 and 2012

*	Integrating NuGet with Visual Studio 2005 and 2008.pdf - Guide to Integrate NuGet with Visual Studio 2005 and 2008

call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPalMerchantSDK\PayPalMerchantSDK.sln /build Release

copy /Y PayPalMerchantSDK\bin\Release\PayPalMerchantSDK.dll Samples\PayPalAPISample\lib\. 
copy /Y PayPalMerchantSDK\bin\Release\PayPalMerchantSDK.XML Samples\PayPalAPISample\lib\. 

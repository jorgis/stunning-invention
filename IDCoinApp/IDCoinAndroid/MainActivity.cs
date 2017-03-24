using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace IDCoinAndroid
{
	[Activity(Label = "IDCoinAndroid", MainLauncher = true, Icon = "@mipmap/icon", Theme="@android:style/Theme.DeviceDefault.NoActionBar")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			var webView = FindViewById<WebView>(Resource.Id.webView);
			webView.Settings.JavaScriptEnabled = true;

			// Use subclassed WebViewClient to intercept hybrid native calls
			webView.SetWebViewClient(new HybridWebViewClient());

			// Render the view from the type generated from RazorView.cshtml
			var model = new Model1() { Text = "Text goes here" };
			var template = new RazorView() { Model = model };
			var page = template.GenerateString();

			// Load the rendered HTML into the view with a base URL 
			// that points to the root of the bundled Assets folder
			webView.LoadDataWithBaseURL("file:///android_asset/", page, "text/html", "UTF-8", null);

			var url = "https://idcoin.howell.no/Authenticator/Selector"; // NOTE: https secure request
			webView.LoadUrl( url);


		}

		private class HybridWebViewClient : WebViewClient
		{
			
			public override async void OnLoadResource(WebView view, string url)
			{
				// If the URL is not our own custom scheme, just let the webView load the URL as usual
				var scheme = "hybrid:";

				//if (!url.StartsWith(scheme))
				//	return false;

				if (url.EndsWith("Scanner"))
				{
					var scanner = new ZXing.Mobile.MobileBarcodeScanner();

					var result = await scanner.Scan(view.Context, new ZXing.Mobile.MobileBarcodeScanningOptions { PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE } });

					if (result != null)
					{
						Console.WriteLine("Scanned Barcode: " + result.Text);
						scanner.Cancel();
						// TODO
						System.Net.WebClient client = new System.Net.WebClient();
						var response = client.UploadString("https://idcoin.howell.no/Bank/Authenticated", result.Text);
						// - POST request to /Bank/AuthenticateOrWhatever with the keywords in the QR
						// - Navigate to /Authenticator/Success

						view.LoadUrl("https://idcoin.howell.no/Authenticator/Success");
					}

				}
			}
		}
	}
}

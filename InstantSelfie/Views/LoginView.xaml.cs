using System;
using System.Collections.Generic;
using System.Diagnostics;
using Amazon.CognitoIdentity;
using Amazon.CognitoSync;
using Amazon.CognitoSync.SyncManager;
using Xamarin.Forms;

namespace InstantSelfie
{
	public partial class LoginView : ContentPage
	{
		private string _fbAppId = "213346429135158";
		private CognitoAWSCredentials creds;
		private AmazonCognitoSyncConfig config;
		private CognitoSyncManager syncManager;
		private FacebookProfile profile;

		public LoginView()
		{
			InitializeComponent();
		}

		void Facebook_Button_Clicked(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Facebook login clicked");
		}

		//login clicked
		void Facebook_Login_Clicked(object sender, System.EventArgs e)
		{

			var apiRequest =
				"https://www.facebook.com/dialog/oauth?client_id="
				+ _fbAppId
				+ "&display=popup&response_type=token&redirect_uri=http://www.facebook.com/connect/login_success.html";

			var webView = new WebView
			{
				Source = apiRequest,

				HeightRequest = 1
			};

			webView.Navigated += WebViewOnNavigated;

			Content = webView;

		}

		// on navigation we grab the token
		private void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
		{

			var accessToken = ExtractAccessTokenFromUrl(e.Url);

			if (accessToken != "")
			{
				InstantSelfieSettings.FBToken = accessToken;

				//var getFBProfileAction = new GetFacebookProfileAction();
				//var task = getFBProfileAction.execute(accessToken);

				//await task;

				//profile = task.Result;



				//Content = successView;

			}
		}

		//getting the token from the url
		private string ExtractAccessTokenFromUrl(string url)
		{
			if (url.Contains("access_token") && url.Contains("&expires_in="))
			{
				var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");

				if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
				{
					at = url.Replace("http://www.facebook.com/connect/login_success.html#access_token=", "");
				}

				var accessToken = at.Remove(at.IndexOf("&expires_in=", StringComparison.Ordinal));

				return accessToken;
			}

			return string.Empty;
		}
	}
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoSync;
using Amazon.CognitoSync.SyncManager;

namespace InstantSelfie
{
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent ();
			InitCognito ();
		}

		private void InitCognito()
		{
			// Initialize the Amazon Cognito credentials provider
			CognitoAWSCredentials credentials = new CognitoAWSCredentials (
				"us-east-1:aac0b0c4-867a-4544-a1aa-60c2e8d719c8", // Identity Pool ID
				RegionEndpoint.USEast1 // Region
			);

		}
	}
}

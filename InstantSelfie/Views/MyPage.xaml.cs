using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace InstantSelfie
{
	public partial class MyPage : ContentPage
	{
		public MyPage()
		{
			InitializeComponent();
		}

		void Facebook_Login_Clicked(object sender, System.EventArgs e)
		{
			Debug.WriteLine("Login in with Facebook clicked");
		}
	}
}

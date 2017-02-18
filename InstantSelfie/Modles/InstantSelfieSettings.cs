using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace InstantSelfie
{
	public class InstantSelfieSettings
	{
		private const string FBTokenKey = "fbtoken_key";
		private static readonly string FBTokenDefault = "";

		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		public static string FBToken
		{
			get { return AppSettings.GetValueOrDefault<string>(FBTokenKey, FBTokenDefault); }
			set { AppSettings.AddOrUpdateValue<string>(FBTokenKey, value); }
		}
	}
}

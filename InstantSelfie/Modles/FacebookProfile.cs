using System;
namespace InstantSelfie
{
	public class FacebookProfile
	{
		public string name { get; set; }
		public Picture picture { get; set; }
		public string locale { get; set; }
		public string link { get; set; }
		public Cover cover { get; set; }
		public AgeRange ageRange { get; set; }
		public Device[] devices { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string gender { get; set; }
		public bool isVerified { get; set; }
		public string id { get; set; }
		public string token { get; set; }
		public string email { get; set; }

		public class Picture
		{
			public Data Data { get; set; }
		}

		public class Data
		{
			public bool isSilhouette { get; set; }
			public string url { get; set; }
		}

		public class Cover
		{
			public string id { get; set; }
			public int offsetY { get; set; }
			public string source { get; set; }
		}

		public class AgeRange
		{
			public int min { get; set; }
		}

		public class Device
		{
			public string os { get; set; }
		}
	}
}

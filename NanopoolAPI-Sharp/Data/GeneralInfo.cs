using NanopoolAPI_Sharp.Helpers;
using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// General account information
	/// </summary>
	public class GeneralInfo
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Account information
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public Data info;

		/// <summary>
		/// Helper class
		/// </summary>
		public class Data
		{
			/// <summary>
			/// Current account balance
			/// </summary>
			public double balance;

			/// <summary>
			/// Current unconfirmed balance
			/// </summary>
			[JsonProperty(PropertyName = "unconfirmed_balance")]
			public double unconfirmedBalance;

			/// <summary>
			/// Current hashrate
			/// </summary>
			public double hashrate;

			/// <summary>
			/// Average hashrate over varying periods of time
			/// </summary>
			public HashrateAverages avgHashrate;

			/// <summary>
			/// Array of workers for the account
			/// </summary>
			[JsonProperty(PropertyName = "worker")]
			public Worker[] workers;

			/// <summary>
			/// Helper class
			/// </summary>
			public class Worker
			{
				/// <summary>
				/// The ID of the worker
				/// </summary>
				public string id;

				/// <summary>
				/// The workers current hashrate
				/// </summary>
				public double hashrate;

				/// <summary>
				/// Time of the last share from the worker
				/// </summary>
				public DateTime lastShare;

				/// <summary>
				/// Average hashrate for 1 hour
				/// </summary>
				[JsonProperty(PropertyName = "avg_h1")]
				public double oneHourAvg;

				/// <summary>
				/// Average hashrate for 3 hours
				/// </summary>
				[JsonProperty(PropertyName = "avg_h3")]
				public double threeHoursAvg;

				/// <summary>
				/// Average hashrate for 6 hours
				/// </summary>
				[JsonProperty(PropertyName = "avg_h6")]
				public double sixHoursAvg;

				/// <summary>
				/// Average hashrate for 12 hours
				/// </summary>
				[JsonProperty(PropertyName = "avg_h12")]
				public double twelveHoursAvg;

				/// <summary>
				/// Average hashrate for 24 hours
				/// </summary>
				[JsonProperty(PropertyName = "avg_h24")]
				public double twentyFourHoursAvg;
			}
		}
	}
}

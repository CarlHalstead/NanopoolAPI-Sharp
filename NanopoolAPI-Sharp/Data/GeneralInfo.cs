using NanopoolAPI_Sharp.Helpers;
using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	public class GeneralInfo
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public Data info;

		public class Data
		{
			public double balance;

			[JsonProperty(PropertyName = "unconfirmed_balance")]
			public double unconfirmedBalance;

			public double hashrate;
			public HashrateAverages avgHashrate;

			[JsonProperty(PropertyName = "worker")]
			public Worker[] workers;

			public class Worker
			{
				public string id;
				public double hashrate;
				public DateTime lastShare;

				[JsonProperty(PropertyName = "avg_h1")]
				public double oneHourAvg;

				[JsonProperty(PropertyName = "avg_h3")]
				public double threeHoursAvg;

				[JsonProperty(PropertyName = "avg_h6")]
				public double sixHoursAvg;

				[JsonProperty(PropertyName = "avg_h12")]
				public double twelveHoursAvg;

				[JsonProperty(PropertyName = "avg_h24")]
				public double twentyFourHoursAvg;
			}
		}
	}
}

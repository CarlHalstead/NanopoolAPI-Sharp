using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	public class AccountPayouts
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public Payout[] payouts;

		public class Payout
		{
			public DateTime date;

			[JsonProperty(PropertyName = "txHash")]
			public string transactionHash;

			public double amount;
			public bool confirmed;
		}
	}
}

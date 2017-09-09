using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// The payouts from this account
	/// </summary>
	public class AccountPayouts
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// List of payouts
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public Payout[] payouts;

		/// <summary>
		/// Helper class
		/// </summary>
		public class Payout
		{
			/// <summary>
			/// Date the payout took place
			/// </summary>
			public DateTime date;

			/// <summary>
			/// Hash for the transaction
			/// </summary>
			[JsonProperty(PropertyName = "txHash")]
			public string transactionHash;

			/// <summary>
			/// Amount that was payed out
			/// </summary>
			public double amount;

			/// <summary>
			/// Was the transaction confirmed
			/// </summary>
			public bool confirmed;
		}
	}
}

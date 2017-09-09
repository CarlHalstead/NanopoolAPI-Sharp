using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Class containing both the balance for the account
	/// as well as the hashrate
	/// </summary>
	public class BalanceAndHashrate
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Info containing the hashrate/balance
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public Info info;

		/// <summary>
		/// Helper class
		/// </summary>
		public class Info
		{
			/// <summary>
			/// Current hashrate
			/// </summary>
			public double hashrate;

			/// <summary>
			/// Current balance
			/// </summary>
			public double balance;
		}
	}
}

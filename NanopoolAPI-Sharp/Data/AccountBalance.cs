using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// The current balance for an account
	/// </summary>
	public class AccountBalance
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// The balance in cruptocurrency
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public double balance;
	}
}

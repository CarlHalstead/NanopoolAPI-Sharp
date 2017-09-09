using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Does an account exist
	/// </summary>
	public class AccountExists
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// String saying if the account exists
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public string exists;

		/// <summary>
		/// Helpful property returning a bool for whether the account exists
		/// </summary>
		public bool doesExist => (exists == "Account exist");
	}
}

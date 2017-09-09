using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Current hashrate for the account
	/// </summary>
	public class CurrentHashrate
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Current hashrate
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public double hashrate;
	}
}

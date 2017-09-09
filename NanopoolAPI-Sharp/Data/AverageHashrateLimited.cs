using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Average hashrate for a specific period of time
	/// </summary>
	public class AverageHashrateLimited
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// The average hashrate
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public double avgHashrate;
	}
}

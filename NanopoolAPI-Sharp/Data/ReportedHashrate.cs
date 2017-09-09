using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Reported hashrate
	/// </summary>
	public class ReportedHashrate
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

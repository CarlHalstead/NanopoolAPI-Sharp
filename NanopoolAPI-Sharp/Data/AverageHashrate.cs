using NanopoolAPI_Sharp.Helpers;
using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// The average hash rate
	/// </summary>
	public class AverageHashrate
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Average hashrates, 1h, 3h etc
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public HashrateAverages averages;
	}
}

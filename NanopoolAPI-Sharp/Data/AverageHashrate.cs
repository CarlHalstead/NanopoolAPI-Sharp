using NanopoolAPI_Sharp.Helpers;
using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class AverageHashrate
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public HashrateAverages averages;
	}
}

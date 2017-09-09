using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class CurrentHashrate
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public double hashrate;
	}
}

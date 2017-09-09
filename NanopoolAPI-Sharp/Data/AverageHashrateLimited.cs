using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class AverageHashrateLimited
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public double avgHashrate;
	}
}

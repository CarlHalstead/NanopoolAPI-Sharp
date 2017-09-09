using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Helpers
{
	public class NanopoolError
	{
		public string status;

		[JsonProperty(PropertyName = "error")]
		public string message;
	}
}

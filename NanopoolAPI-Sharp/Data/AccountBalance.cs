using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class AccountBalance
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public double balance;
	}
}

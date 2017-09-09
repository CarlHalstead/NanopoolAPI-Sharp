using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class BalanceAndHashrate
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public Info info;

		public class Info
		{
			public double hashrate;
			public double balance;
		}
	}
}

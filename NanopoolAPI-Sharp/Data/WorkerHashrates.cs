using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class WorkerHashrates
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public Worker worker;

		public class Worker
		{
			public string worker;
			public double hashrate;
		}
	}
}

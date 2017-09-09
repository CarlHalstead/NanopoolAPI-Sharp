using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	public class WorkerList
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public Worker[] workers;

		public class Worker
		{
			public string id;
			public double hashrate;
			public DateTime lastShare;
			public long rating;
		}
	}
}

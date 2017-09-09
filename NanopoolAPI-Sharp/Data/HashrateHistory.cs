using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	public class HashrateHistory
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public History[] history;

		public class History
		{
			public DateTime date;
			public double hashrate;
		}
	}
}

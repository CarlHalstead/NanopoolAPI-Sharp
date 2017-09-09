using System;

namespace NanopoolAPI_Sharp.Data
{
	public class HashrateChart
	{
		public bool status;
		public Data[] data;

		public class Data
		{
			public DateTime date;
			public long shares;
			public double hashrate;
		}
	}
}

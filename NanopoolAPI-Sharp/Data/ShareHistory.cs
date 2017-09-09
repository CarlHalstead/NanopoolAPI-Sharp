using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	public class ShareHistory
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public ShareInfo shareInfo;

		public class ShareInfo
		{
			public DateTime date;
			public long shares;
		}
	}
}

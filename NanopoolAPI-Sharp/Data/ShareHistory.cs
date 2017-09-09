using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// History of shares
	/// </summary>
	public class ShareHistory
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// time and number of shares
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public ShareInfo shareInfo;

		/// <summary>
		/// Helper class
		/// </summary>
		public class ShareInfo
		{
			/// <summary>
			/// Date
			/// </summary>
			public DateTime date;

			/// <summary>
			/// Number of shares
			/// </summary>
			public long shares;
		}
	}
}

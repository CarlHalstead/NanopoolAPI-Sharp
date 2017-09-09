using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// History of hashrate
	/// </summary>
	public class HashrateHistory
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Array of times as well as the hashrates at that moment
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public History[] history;

		/// <summary>
		/// Helper class
		/// </summary>
		public class History
		{
			/// <summary>
			/// DateTime at that moment
			/// </summary>
			public DateTime date;

			/// <summary>
			/// Hashrate at that moment
			/// </summary>
			public double hashrate;
		}
	}
}

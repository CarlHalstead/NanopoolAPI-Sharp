using System;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Hashrate over time
	/// </summary>
	public class HashrateChart
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Array of timestamps
		/// </summary>
		public Data[] data;

		/// <summary>
		/// Helper class
		/// </summary>
		public class Data
		{
			/// <summary>
			/// Date/Time at this point
			/// </summary>
			public DateTime date;

			/// <summary>
			/// Number of shares
			/// </summary>
			public long shares;

			/// <summary>
			/// Hashrate
			/// </summary>
			public double hashrate;
		}
	}
}

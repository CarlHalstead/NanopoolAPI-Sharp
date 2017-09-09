namespace NanopoolAPI_Sharp.Helpers
{
	/// <summary>
	/// Class holding the enum for the requests
	/// </summary>
	public class Requests
	{
		/// <summary>
		/// Enum for the requests so I can add it to the URL
		/// </summary>
		public enum RequestType
		{
			/// <summary>
			/// Pair with the 'AccountExists' class
			/// </summary>
			AccountExist,

			/// <summary>
			/// Pair with the 'AverageHashrate' class
			/// </summary>
			AvgHashrate,

			/// <summary>
			/// Pair with the 'AverageHashrateLimited' class making sure to supply an amount of hours
			/// with the SendRequest call
			/// </summary>
			AvgHashrateLimited,

			/// <summary>
			/// Pair with the 'WorkerHashrates' class
			/// </summary>
			AvgHashrateWorkers,

			/// <summary>
			/// Pair with the 'AccountBalance' class
			/// </summary>
			Balance,

			/// <summary>
			/// Pair with the 'BalanceAndHashrate' class
			/// </summary>
			Balance_Hashrate,

			/// <summary>
			/// Pair with the 'AverageHashrate' class
			/// </summary>
			Hashrate,

			/// <summary>
			/// Pair with the 'HashrateChart' class
			/// </summary>
			HashrateChart,

			/// <summary>
			/// Pair with the 'HashrateHistory' class
			/// </summary>
			History,

			/// <summary>
			/// Pair with the 'AccountPayouts' class
			/// </summary>
			Payments,

			/// <summary>
			/// Pair with the 'ReportedHashrate' class
			/// </summary>
			ReportedHashrate,

			/// <summary>
			/// Pair with the 'ShareHistory' class
			/// </summary>
			ShareRateHistory,

			/// <summary>
			/// Pair with the 'GeneralInfo' class
			/// </summary>
			User,

			/// <summary>
			/// Pair with the 'WorkerList' class
			/// </summary>
			Workers
		}
	}
}

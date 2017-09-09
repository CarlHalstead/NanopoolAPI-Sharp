using Newtonsoft.Json;
using System;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// All workers
	/// </summary>
	public class WorkerList
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Array of workers
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public Worker[] workers;

		/// <summary>
		/// Helper class
		/// </summary>
		public class Worker
		{
			/// <summary>
			/// Worker ID
			/// </summary>
			public string id;

			/// <summary>
			/// hashrate of the worker
			/// </summary>
			public double hashrate;

			/// <summary>
			/// DateTime of the last received share
			/// </summary>
			public DateTime lastShare;

			/// <summary>
			/// The rating of the worker
			/// </summary>
			public long rating;
		}
	}
}

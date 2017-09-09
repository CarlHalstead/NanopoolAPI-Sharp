using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	/// <summary>
	/// Hashrates of the worker
	/// </summary>
	public class WorkerHashrates
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// Worker information
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public Worker worker;

		/// <summary>
		/// Helper class
		/// </summary>
		public class Worker
		{
			/// <summary>
			/// Worker ID
			/// </summary>
			public string worker;

			/// <summary>
			/// Hashrate of the worker
			/// </summary>
			public double hashrate;
		}
	}
}

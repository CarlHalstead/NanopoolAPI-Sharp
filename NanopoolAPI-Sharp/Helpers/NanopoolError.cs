using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Helpers
{
	/// <summary>
	/// Error from the Nanopool API
	/// </summary>
	public class NanopoolError
	{
		/// <summary>
		/// Did it succeed
		/// </summary>
		public bool status;

		/// <summary>
		/// The error message from the API
		/// </summary>
		[JsonProperty(PropertyName = "error")]
		public string message;
	}
}

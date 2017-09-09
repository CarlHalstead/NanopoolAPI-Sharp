using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Helpers
{
	/// <summary>
	/// Averages of hashrates over differing time periods
	/// </summary>
	public class HashrateAverages
	{
		/// <summary>
		/// Average over 1 hour
		/// </summary>
		[JsonProperty(PropertyName = "h1")]
		public double oneHour;

		/// <summary>
		/// Average over 3 hours
		/// </summary>
		[JsonProperty(PropertyName = "h3")]
		public double threeHours;

		/// <summary>
		/// Average over 6 hours
		/// </summary>
		[JsonProperty(PropertyName = "h6")]
		public double sixHours;

		/// <summary>
		/// Average over 12 hours
		/// </summary>
		[JsonProperty(PropertyName = "h12")]
		public double twelveHours;

		/// <summary>
		/// Average over 24 hours
		/// </summary>
		[JsonProperty(PropertyName = "h24")]
		public double twentyFourHours;
	}
}

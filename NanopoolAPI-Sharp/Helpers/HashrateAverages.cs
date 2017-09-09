using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Helpers
{
	public class HashrateAverages
	{
		[JsonProperty(PropertyName = "h1")]
		public double oneHour;

		[JsonProperty(PropertyName = "h3")]
		public double threeHours;

		[JsonProperty(PropertyName = "h6")]
		public double sixHours;

		[JsonProperty(PropertyName = "h12")]
		public double twelveHours;

		[JsonProperty(PropertyName = "h24")]
		public double twentyFourHours;
	}
}

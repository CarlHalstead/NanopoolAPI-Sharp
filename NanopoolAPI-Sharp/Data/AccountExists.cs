using Newtonsoft.Json;

namespace NanopoolAPI_Sharp.Data
{
	public class AccountExists
	{
		public bool status;

		[JsonProperty(PropertyName = "data")]
		public string exists;

		public bool doesExist => (exists == "Account exist");
	}
}

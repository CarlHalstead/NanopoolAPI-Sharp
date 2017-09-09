using NanopoolAPI_Sharp.Helpers;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace NanopoolAPI_Sharp
{
	public class EthClient
	{
		const string baseUrl = "https://api.nanopool.org/v1/eth";
		string address = "";

		public EthClient(string address)
		{
			if (string.IsNullOrEmpty(address)) throw new Exception("Your address should not be empty!");

			this.address = address;
		}

		public async Task<T> SendRequest<T>(Requests.RequestType request)
		{
			using (WebClient client = new WebClient())
			{
				string json = await client.DownloadStringTaskAsync($"{baseUrl}/{request.ToString().ToLower()}/{address}");

				if (json.Contains("error"))
				{
					NanopoolError error = JsonConvert.DeserializeObject<NanopoolError>(json);
					throw new Exception(error.message);
				}

				T result = JsonConvert.DeserializeObject<T>(json);
				return result;
			}
		}
	}
}

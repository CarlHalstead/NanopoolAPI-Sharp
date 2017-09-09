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

		/// <summary>
		/// Send a request to the api asynchronously
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="request"></param>
		/// <returns></returns>
		public async Task<T> SendRequest<T>(Requests.RequestType request)
		{
			string url = $"{baseUrl}/{request.ToString().ToLower()}/{address}";
			return await DoRequest<T>(url);
		}

		/// <summary>
		/// Send a request to the api supplying an amount of hours for the api to look at
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="request"></param>
		/// <param name="hours"></param>
		/// <returns></returns>
		public async Task<T> SendRequest<T>(Requests.RequestType request, int hours)
		{
			Console.WriteLine($"{baseUrl}/{request.ToString().ToLower()}/{address}/{hours}");
			string url = $"{baseUrl}/{request.ToString().ToLower()}/{address}/{hours}";
			return await DoRequest<T>(url);
		}

		public async Task<T> DoRequest<T>(string url)
		{
			using (WebClient client = new WebClient())
			{
				string json = await client.DownloadStringTaskAsync(url);

				if (json.Contains("error"))
				{
					NanopoolError error = JsonConvert.DeserializeObject<NanopoolError>(json);
					throw new Exception(error.message);
				}

				T result;
				try
				{
					result = JsonConvert.DeserializeObject<T>(json);
				}
				catch (Exception)
				{
					throw new Exception("JSON Parsing failed, did you fail to match the correct class and enum values?");
				}
				
				return result;
			}
		}
	}
}

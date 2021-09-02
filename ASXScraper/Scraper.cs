using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ASXScrapper
{
    public class Scraper
    {
        private readonly HttpClient _client;

        private const string URL = "https://www.asx.com.au/asx/1/share/";

        public Scraper()
        {
            _client = new HttpClient();
        }

        ~Scraper()
        {
            if(_client != null)
            {
                _client.Dispose();
            }
        }

        public AsxData GetData(string asxTicker)
        {
            AsxData resultObject = null;
            _client.BaseAddress = new Uri(URL);

            _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = _client.GetAsync(asxTicker).Result;  // Blocking call
            if (response.IsSuccessStatusCode)
            {
               string stringResult = response.Content.ReadAsStringAsync().Result;
               resultObject = JsonConvert.DeserializeObject<AsxData>(stringResult);
            }
            else
            {
                Console.WriteLine($"{(int)response.StatusCode} ({response.ReasonPhrase})");
            }

            return resultObject;
        }
    }
}

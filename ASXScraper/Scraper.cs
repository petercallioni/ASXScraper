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
        HttpClient client;

        private const string URL = "https://www.asx.com.au/asx/1/share/";

        public Scraper()
        {
            client = new HttpClient();
        }

        ~Scraper()
        {
            if(client != null)
            {
                client.Dispose();
            }
        }

        public DataObject GetData(string asxTicker)
        {
            DataObject resultObject = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(asxTicker).Result;  // Blocking call
            if (response.IsSuccessStatusCode)
            {
               string stringResult = response.Content.ReadAsStringAsync().Result;
               resultObject = JsonConvert.DeserializeObject<DataObject>(stringResult);
            }
            else
            {
                Console.WriteLine($"{(int)response.StatusCode} ({response.ReasonPhrase})");
            }

            return resultObject;
        }
    }
}

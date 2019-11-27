using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JobTaskSecond.ConApp.Core
{
    public  class Tools
    {
        public static void save(string url, string name)
        {
            string sname = JsonConvert.SerializeObject(name);

            var content = new StringContent(sname, Encoding.UTF8, "application/json");
            var client = new HttpClient { BaseAddress = new Uri(url) };

            // call sync
            var response = client.PostAsync("/api/values", content).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync();
            }

        }
        public async static Task<string> GetItems(string url)
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);

        }
    }
}

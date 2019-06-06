using Newtonsoft.Json;
using NobelLaureates.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NobelLaureates.Connection
{
    public class JSONConnector : GlobalConnection
    {

        public JSONConnector()
        {

        }

        public async override void InitializePrizes()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync(GlobalConfig.JSONLink).Result;
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    ProcessTheData(data);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
        }

        private void ProcessTheData(string data)
        {
            RootObject model = JsonConvert.DeserializeObject<RootObject>(data);
            GlobalConfig.Connection.Container = model;
        }
    }
}

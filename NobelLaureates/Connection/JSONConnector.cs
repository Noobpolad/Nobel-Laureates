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

        /// <summary>
        /// Connect to the web page, get the json string and process it to the object.
        /// </summary>
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

        /// <summary>
        /// Convert the json string from web page to the object.
        /// </summary>
        /// <param name="data"></param>
        private void ProcessTheData(string data)
        {
            GlobalConfig.Connection.Container = JsonConvert.DeserializeObject<RootObject>(data);
        }
    }
}

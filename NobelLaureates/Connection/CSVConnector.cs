using NobelLaureates.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NobelLaureates.Connection
{
    public class CSVConnector : GlobalConnection
    {
        public CSVConnector()
        {
            
        }

        public async override void InitializePrizes()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync(GlobalConfig.CSVLink).Result;
                    response.EnsureSuccessStatusCode();
                    using (Stream responseBody = await response.Content.ReadAsStreamAsync())
                    {
                        using (StreamReader reader = new StreamReader(responseBody))
                        {
                            string line;
                            reader.ReadLine();
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (ProcessTheString(line)[3] == "912")
                                {
                                    line = reader.ReadLine();
                                    continue;
                                }

                                ConvertStringToPrize(line);
                            }
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
        }

        private static void ConvertStringToPrize(string data)
        {
            string[] columns = ProcessTheString(data);
            PrizeModel curPrize = LookForAPrize(columns[0], columns[1]);
            if (curPrize == null)
            {
                curPrize = new PrizeModel(columns[0],columns[1],columns[2]);
                curPrize.Laureates.Add(new LaureateModel(columns[3], columns[4], columns[5], columns[6], columns[7]));
                GlobalConfig.Connection.Container.Prizes.Add(curPrize);
            }
            else
            {
                curPrize.Laureates.Add(new LaureateModel(columns[3], columns[4], columns[5], columns[6], columns[7]));
            }
        }

        private static string[] ProcessTheString(string data)
        {
            List<string> output = new List<string>();
            StringBuilder word = new StringBuilder();
            bool ignoreComma = false;

            foreach (char c in data)
            {
                if (c == '"')
                {
                    ignoreComma = !ignoreComma;
                }
                else if (c == ',' && !ignoreComma)
                {
                    output.Add(word.ToString());
                    word = new StringBuilder();
                }
                else
                {
                    word.Append(c);
                }
            }

            output.Add(word.ToString());

            return output.ToArray();
        }

        private static PrizeModel LookForAPrize(string year, string category)
        {
            return GlobalConfig.Connection.Container.Prizes.Where(x => x.Year == int.Parse(year) && x.Category == category).FirstOrDefault();
        }
    }
}

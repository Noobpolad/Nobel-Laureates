using NobelLaureates.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelLaureates
{
    public class GlobalConfig
    {
        private const string CSVLink = "http://api.nobelprize.org/v1/prize.csv?";
        private const string JSONLink = "http://api.nobelprize.org/v1/prize.json?";
        public static GlobalConnection Connection;

        public static void InitializeConnection(ConnectionType type)
        {
            if (type == ConnectionType.CSV)
            {
                Connection = new CSVConnector(CSVLink);
            }
            else if (type == ConnectionType.JSON)
            {
                Connection = new JSONConnector(JSONLink);
            }
        }
    }
}

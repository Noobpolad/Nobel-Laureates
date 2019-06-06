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
        public const string CSVLink = "http://api.nobelprize.org/v1/prize.csv?";
        public const string JSONLink = "http://api.nobelprize.org/v1/prize.json?";
        public static GlobalConnection Connection;

        public static void InitializeConnection(ConnectionType type)
        {
            if (type == ConnectionType.CSV)
            {
                Connection = new CSVConnector();
            }
            else if (type == ConnectionType.JSON)
            {
                Connection = new JSONConnector();
            }
        }
    }
}

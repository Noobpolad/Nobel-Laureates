using NobelLaureates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelLaureates.Connection
{
    public abstract class GlobalConnection
    {
        public List<PrizeModel> Prizes { get; set; }

        public abstract void InitializePrizes();
    }
}

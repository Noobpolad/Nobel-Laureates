using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelLaureates.Models
{
    public class RootObject
    {
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
    }
}

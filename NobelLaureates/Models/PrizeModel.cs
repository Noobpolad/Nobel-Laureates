using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelLaureates.Models
{
    public class PrizeModel
    {
        public int Year { get; set; }
        public string Category { get; set; }
        public string OverallMotivation { get; set; }
        public List<LaureateModel> Laureates { get; set; } = new List<LaureateModel>();

        public PrizeModel(string year, string category, string overallMotivation)
        {
            Year = int.Parse(year);
            Category = category;
            OverallMotivation = overallMotivation;
        }
    }
}

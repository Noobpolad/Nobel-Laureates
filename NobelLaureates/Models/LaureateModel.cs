using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelLaureates.Models
{
    public class LaureateModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Motivation { get; set; }
        public int Share { get; set; }

        public LaureateModel(string id, string fn, string ln, string motivation, string share) 
        {
            Id = int.Parse(id);
            Firstname = fn;
            Surname = ln;
            Motivation = motivation;
            Share = int.Parse(share);
        }
    }
}

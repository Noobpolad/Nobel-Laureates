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
        public RootObject Container { get; set; } = new RootObject();

        public abstract void InitializePrizes();
        
        public List<RepresentationObject> ConverPrizesToRepresentationObjects(List<PrizeModel> prizes)
        {
            List<RepresentationObject> output = new List<RepresentationObject>();
            if (prizes.Count == 0) return output;

            foreach (PrizeModel prize in prizes)
            {
                foreach (LaureateModel laureate in prize.Laureates)
                {
                    RepresentationObject model = new RepresentationObject();
                    model.Year = prize.Year;
                    model.Category = prize.Category;
                    model.Id = laureate.Id;
                    model.LaureateName = laureate.Firstname;
                    model.LaureateSurname = laureate.Surname;
                    model.Share = laureate.Share;
                    output.Add(model);
                }
            }

            return output;
        }

        public List<PrizeModel> FilterOnName(string name, List<PrizeModel> curPrizes)
        {

            List<PrizeModel> output = new List<PrizeModel>();

            foreach (PrizeModel prize in curPrizes)
            {
                foreach (LaureateModel laureate in prize.Laureates)
                {
                    if (laureate.Firstname == name)
                    {
                        PrizeModel p = output.Where(x => x.Year == prize.Year && x.Category == prize.Category).FirstOrDefault();
                        if (p == null)
                        {
                            p = new PrizeModel(prize.Year.ToString(), prize.Category, prize.OverallMotivation);
                            p.Laureates.Add(new LaureateModel(laureate.Id.ToString(), laureate.Firstname, laureate.Surname, laureate.Motivation, laureate.Share.ToString()));
                            output.Add(p);
                        }
                        else
                        {
                            p.Laureates.Add(new LaureateModel(laureate.Id.ToString(), laureate.Firstname, laureate.Surname, laureate.Motivation, laureate.Share.ToString()));
                        }
                    }
                }
            }

            return output;
        }

        public List<PrizeModel> FilterOnSurname(string surname, List<PrizeModel> curPrizes)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (PrizeModel prize in curPrizes)
            {
                foreach (LaureateModel laureate in prize.Laureates)
                {
                    if (laureate.Surname == surname)
                    {
                        PrizeModel p = output.Where(x => x.Year == prize.Year && x.Category == prize.Category).FirstOrDefault();
                        if (p == null)
                        {
                            p = new PrizeModel(prize.Year.ToString(), prize.Category, prize.OverallMotivation);
                            p.Laureates.Add(new LaureateModel(laureate.Id.ToString(), laureate.Firstname, laureate.Surname, laureate.Motivation, laureate.Share.ToString()));
                            output.Add(p);
                        }
                        else
                        {
                            p.Laureates.Add(new LaureateModel(laureate.Id.ToString(), laureate.Firstname, laureate.Surname, laureate.Motivation, laureate.Share.ToString()));
                        }
                    }
                }
            }

            return output;
        }

        public List<PrizeModel> FilterOnShareNumber(int share, List<PrizeModel> curPrizes)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (PrizeModel prize in curPrizes)
            {
                foreach (LaureateModel laureate in prize.Laureates)
                {
                    if (laureate.Share == share)
                    {
                        PrizeModel p = output.Where(x => x.Year == prize.Year && x.Category == prize.Category).FirstOrDefault();
                        if (p == null)
                        {
                            p = new PrizeModel(prize.Year.ToString(), prize.Category, prize.OverallMotivation);
                            p.Laureates.Add(new LaureateModel(laureate.Id.ToString(), laureate.Firstname, laureate.Surname, laureate.Motivation, laureate.Share.ToString()));
                            output.Add(p);
                        }
                        else
                        {
                            p.Laureates.Add(new LaureateModel(laureate.Id.ToString(), laureate.Firstname, laureate.Surname, laureate.Motivation, laureate.Share.ToString()));
                        }
                    }
                }
            }

            return output;
        }

        public List<PrizeModel> FilterOnDates(int from, int to, List<PrizeModel> curPrizes)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (PrizeModel prize in curPrizes)
            {
                if (prize.Year <= from && prize.Year >= to)
                {
                    output.Add(prize);
                }
            }

            return output;
        }

        public List<PrizeModel> FilterOnCategory(string category, List<PrizeModel> curPrizes)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (PrizeModel prize in curPrizes)
            {
                if (prize.Category == category)
                {
                    output.Add(prize);
                }
            }

            return output;
        }
    }
}

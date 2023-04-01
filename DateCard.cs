using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class DateCard 
    {
        public string YearCard { get; set; }
        public string MonthCard { get; set; }

        public DateCard(string yearcard, string monthcard)
        {
            YearCard = yearcard;
            MonthCard = monthcard;
        }
        public override string ToString()
        {
            return YearCard + ", " + MonthCard;
        }
    }
}

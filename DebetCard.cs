using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class DebetCard : PaymentCard
    {
        public float PercentDebet { get; set; }
        public float Sum { get; set; }

        public DebetCard(string number, DateCard datecard, CustomerInfo customerInfo, int ccv, float percentDebet, float sum) : base(number, datecard, customerInfo, ccv)
        {
            PercentDebet = percentDebet;
            Sum = sum;
        }
        public override string GetFullInformation()
        {
            return String.Format($"Number:{Number} Date:{Datecard} Name:{CustomerInfo} CCV:{CCV} %Debet: {PercentDebet} Sum:{Sum}");

        }
    } 
}

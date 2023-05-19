using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{

    internal class CashBackCard : DebetCard, IPayment

    {
        public float CashBackPercent { get; set; }
        public CashBackCard(string number, DateCard datecard, int ccv, float sum, float cashBackPercent) : base(number, datecard, ccv, sum)
        {
            CashBackPercent = cashBackPercent;
        }
        public override bool MakePayment(float sum)
        {
            if (base.MakePayment(sum))
            {
                Sum = Sum + sum * CashBackPercent / 100;
                return true;
            }
            return false;
        }
        public override string GetFullInformation()
        {
            return String.Format($"Number:{Number} Date:{Datecard} CCV:{CCV}  Sum:{Sum} %CashBack:{CashBackPercent}");
        }
        public float GetSum()
        {
            return Sum;
        }
    }
}

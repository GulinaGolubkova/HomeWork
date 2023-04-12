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
        public CashBackCard(string number, DateCard datecard, CustomerInfo customerInfo, int ccv, float sum, float cashBackPercent) : base(number, datecard, customerInfo, ccv, sum)
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
            return String.Format($"Number:{Number} Date:{Datecard} Name:{CustomerInfo} CCV:{CCV}  Sum:{Sum} %CashBack:{CashBackPercent}");
        }
    }
}

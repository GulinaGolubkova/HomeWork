using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class CreditCard : PaymentCard, IPayment
    {
        public float PercentCredit { get; set; }
        public float LimitCredit { get; set; }

        public CreditCard(string number, DateCard datecard, int ccv, float percentCredit, float limitCredit) : base(number, datecard, ccv)
        {
            PercentCredit = percentCredit;
            LimitCredit = limitCredit;
        
        }
        public override string GetFullInformation()
        {
            return String.Format($"Number:{Number} Date:{Datecard} CCV:{CCV} %Credit: {PercentCredit} LimitSum:{LimitCredit}" );

        }
        public bool MakePayment(float sum)
        {
            if (LimitCredit >= sum)
            {
                LimitCredit = LimitCredit - sum;
                return true;
            }
            return false;
        }
        public float GetSum()
        {
            return LimitCredit;
        }
    }
}

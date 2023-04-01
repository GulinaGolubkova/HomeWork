using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class CreditCard : PaymentCard
    {
        public float PercentCredit { get; set; }
        public float LimitCredit { get; set; }

        public CreditCard(string number, DateCard datecard, CustomerInfo customerInfo, int ccv, float percentCredit, float limitCredit) : base(number, datecard, customerInfo, ccv)
        {
            PercentCredit = percentCredit;
            LimitCredit = limitCredit;
        
        }
        public override string GetFullInformation()
        {
            return String.Format($"Number:{Number} Date:{Datecard} Name:{CustomerInfo} CCV:{CCV} %Credit: {PercentCredit} LimitSum:{LimitCredit}" );

        }
    }
}

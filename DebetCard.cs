using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class DebetCard : PaymentCard, IPayment
    {
        public float PercentDebet { get; set; }
        public float Sum { get; set; }

        public DebetCard(string number, DateCard datecard, CustomerInfo customerInfo, int ccv,  float sum) : base(number, datecard, customerInfo, ccv)
        {
        Sum = sum;
        }
        public override string GetFullInformation()
        {
            return String.Format($"Number:{Number} Date:{Datecard} Name:{CustomerInfo} CCV:{CCV}  Sum:{Sum}");

        }
        public virtual bool MakePayment(float sum)
        {
            if (Sum >= sum) 
            {
                Sum = Sum - sum;
                return true;
            }
            return false;        
        }
    } 
}

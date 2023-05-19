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

        public DebetCard(string number, DateCard datecard, int ccv,  float sum) : base(number, datecard, ccv)
        {
        Sum = sum;
        }
        public override string GetFullInformation()
        {
            return String.Format($"Number:{Number} Date:{Datecard} CCV:{CCV} Sum:{Sum}");

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
        public float GetSum()
        {
            return Sum;
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class PaymentCard
    {
        public string Number { get; set; }
        public DateCard Datecard;
        public CustomerInfo CustomerInfo;
        public int CCV { get; set; }

        public PaymentCard(string number, DateCard datecard, CustomerInfo customerInfo, int ccv)
        {
            Number = number;
            Datecard = datecard;
            CustomerInfo = customerInfo;
            CCV = ccv;
        }
        
        public virtual string GetFullInformation()
        {
            return  String.Format($"Number:{Number} Date:{Datecard} Name:{CustomerInfo} CCV:{CCV}");

        }
       /* abstract bool MakePayment(float sum); */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    abstract class PaymentCard
    {
        public string Number { get; set; }
        public DateCard Datecard;
        public int CCV { get; set; }

        public PaymentCard(string number, DateCard datecard, int ccv)
        {
            Number = number;
            Datecard = datecard;
            CCV = ccv;
        }
        
        public virtual string GetFullInformation()
        {
            return  String.Format($"Number:{Number} Date:{Datecard} CCV:{CCV}");

        }
       
    }
}

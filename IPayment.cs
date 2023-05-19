using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal interface IPayment
    {
        bool MakePayment(float sum);
        public string GetFullInformation();
        public float GetSum();

    }
}

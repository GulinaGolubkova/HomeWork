using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Cash : IPayment
    {
        public float Sum { get; set; }
        public Cash(float sum)
        {
            Sum = sum;
        }
        public bool MakePayment(float sum)
        {
            if (Sum >= sum)
            {
                Sum = Sum - sum;
                return true;
            }
            return false;
        }
        public string GetFullInformation()
        {
            return String.Format($"Sum:{Sum}");
        }
        public float GetSum()
        {
            return Sum;
        }
    }
}

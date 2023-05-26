using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Bitcoin: IPayment
    {
        public float Sum { get; set; }
        public float Bitcoins { get; set; }

        public Bitcoin(float bitkoins, float sum)
        {
            Bitcoins = bitkoins;
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

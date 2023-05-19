using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Comparers
{
    internal class AmountSumComparer : IComparer<BankClient>
    {
        public int Compare(BankClient? x, BankClient? y)
        {
            float generalSumX = 0;
            foreach (var item in x.PaymentMethods)
            {
                generalSumX = generalSumX + item.GetSum();
            }
            float generalSumY = 0;
            foreach (var item in y.PaymentMethods)
            {
                generalSumY = generalSumY + item.GetSum();
            }
            return generalSumX.CompareTo(generalSumY);
        }
    }
}

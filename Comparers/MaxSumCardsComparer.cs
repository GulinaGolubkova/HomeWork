using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Comparers
{
    internal class MaxSumCardsComparer : IComparer<BankClient>
    {
        public int Compare(BankClient? x, BankClient? y)
        {

            var paymentMethodsX = x.PaymentMethods.OrderBy(item => item.GetSum()).ToList();
            var paymentMethodsY = y.PaymentMethods.OrderBy(item => item.GetSum()).ToList();
            var maxSumX = paymentMethodsX.Last();
            var maxSumY = paymentMethodsY.Last();

            return maxSumX.GetSum().CompareTo(maxSumY.GetSum());
        }
    }
}

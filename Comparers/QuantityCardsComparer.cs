using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1.Comparers
{
    internal class QuantityCardsComparer : IComparer<BankClient>
    {
        public int Compare(BankClient? x, BankClient? y)
        {
            return x.GetPaymentMethodCount().CompareTo(y.GetPaymentMethodCount());
        }
    }
}

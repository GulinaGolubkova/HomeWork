using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class BankClient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public List<IPayment> PaymentMethods { get; set; }  

        public BankClient(string firstname, string lastname, Address address, List<IPayment> paymentMethods)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            PaymentMethods = paymentMethods;    
        }

        public bool AddPaymentMethod(IPayment payElement)
        {
            PaymentMethods.Add(payElement);
            return true;

        }
        public int GetPaymentMethodCount() 
        { 
        return PaymentMethods.Count;
        }


        public bool Pay(float sum)
        {
            List<DebetCard> debetCards = new List<DebetCard>();
            List<CreditCard> creditCards = new List<CreditCard>();
            List<CashBackCard> cachBackCards = new List<CashBackCard>();
            List<Cash> cashPays = new List<Cash>();

            foreach (IPayment paymentMethod in PaymentMethods)
            {
                if (paymentMethod is CashBackCard)
                {
                    cachBackCards.Add(paymentMethod as CashBackCard);
                }
                else
                if (paymentMethod is DebetCard)
                {
                    debetCards.Add(paymentMethod as DebetCard);
                }
                else
                if (paymentMethod is CreditCard)
                {
                    creditCards.Add(paymentMethod as CreditCard);
                }
                else if (paymentMethod is Cash)
                {
                    cashPays.Add(paymentMethod as Cash);
                }
            }
            foreach (Cash card in cashPays)
            {
                if (card.MakePayment(sum) == true)
                    return true;

            }
            foreach (CashBackCard card in cachBackCards)
            {
                if (card.MakePayment(sum) == true)
                    return true;

            }

            foreach (DebetCard card in debetCards)
            {
                if (card.MakePayment(sum) == true)
                    return true;

            }

            // sort by PercentCredit ascending
            creditCards = creditCards.OrderBy(card => card.PercentCredit).ToList();
            foreach (CreditCard card in creditCards)
            {
                if (card.MakePayment(sum) == true)
                    return true;
            }


            return false;
        }
        public void ShowPaymentInfo()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Address);

            foreach (IPayment paymentMethod in PaymentMethods)
            {
                if (paymentMethod is PaymentCard)
                {
                    string information = (paymentMethod as PaymentCard).GetFullInformation();
                    Console.WriteLine(information);
                }
                else if (paymentMethod is Cash)
                {
                    string information = (paymentMethod as Cash).GetFullInformation();
                    Console.WriteLine("Cash available: " + (paymentMethod as Cash).Sum);    
                }
            }
        }

    }
}
using HomeWork1.Comparers;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace HomeWork1
{
    internal class Program

    {
        static void Task1()
        {
            Address address = new Address("Zaslavl", "Vasilkovaya", 2, 1);
            Address address1 = new Address("Zaslavl", "Kupalskaya", 3, 1);
            Address address2 = new Address("Zaslavl", "Zagor'e", 4, 1);
            Address address3 = new Address("Zaslavl", "Primor'e", 5, 1);
            Address address4 = new Address("Zaslavl", "Bagryanaya", 6, 1);

            DateCard datecard = new DateCard("2023", "03");
            DateCard datecard1 = new DateCard("2023", "04");
            DateCard datecard2 = new DateCard("2023", "05");
            DateCard datecard3 = new DateCard("2023", "06");
            DateCard datecard4 = new DateCard("2023", "07");

            DebetCard card1 = new DebetCard("1111111111111115", datecard, 111, 15000.00f);
            DebetCard card2 = new DebetCard("2222222222222225", datecard1, 222, 19000.00f);
            CreditCard card3 = new CreditCard("3333333333333335", datecard2, 333, 20.56f, 120000.00f);
            CreditCard card4 = new CreditCard("4444444444444445", datecard3, 444, 18.56f, 100000.00f);
            DebetCard card5 = new DebetCard("5555555555555555", datecard4, 555, 25000.00f);
            CashBackCard card6 = new CashBackCard("5555555555556666", datecard4, 556, 9000.00f, 2.15f);
            CashBackCard card7 = new CashBackCard("5555555555557777", datecard3, 557, 6000.00f, 2.00f);
            Cash cash = new Cash(5500);

            List<IPayment> paymentMethods = new List<IPayment>() { card1, card2, card3, card4, card5, card6, card7 };

            BankClient client = new BankClient("Olga", "Golubkova", address, paymentMethods);
            client.AddPaymentMethod(cash);

            client.ShowPaymentInfo();

            if (client.Pay(92000) == true)
            {
                Console.WriteLine("Payment is seccessful");
            }
            else
            {
                Console.WriteLine("Payment is failed");
            }

            client.ShowPaymentInfo();

            if (client.Pay(450) == true)
            {
                Console.WriteLine("Payment is seccessful");
            }
            else
            {
                Console.WriteLine("Payment is failed");
            }

            client.ShowPaymentInfo();
        }

        static void Task2()
        {
            DebetCard card1 = new DebetCard("0000000000000001", new DateCard("2023", "12"), 111, 1200);
            List<IPayment> paymentMethods1 = new List<IPayment>() { card1 };
            BankClient client1 = new BankClient("Olga", "Golubkova", new Address("Gomel", "Sovietskaya", 1, 1), paymentMethods1);

            DebetCard card2 = new DebetCard("1111111111111111", new DateCard("2023", "11"), 222, 1000);
            CreditCard card3 = new CreditCard("2222222222222222", new DateCard("2023", "10"), 333, 20.56f, 12000);
            List<IPayment> paymentMethods2 = new List<IPayment>() { card2, card3 };
            BankClient client2 = new BankClient("Vasya", "Kruglov", new Address("Zaslavl", "Vasilkovaya", 2, 2), paymentMethods2);

            DebetCard card4 = new DebetCard("3333333333333333", new DateCard("2023", "09"), 444, 800);
            CreditCard card5 = new CreditCard("4444444444444444", new DateCard("2023", "08"), 555, 18.56f, 10000);
            Cash cash1 = new Cash(500);
            List<IPayment> paymentMethods3 = new List<IPayment>() { card4, card5, cash1 };
            BankClient client3 = new BankClient("Petya", "Petichkin", new Address("Minsk", "Primorskaya", 3, 3), paymentMethods3);

            CreditCard card6 = new CreditCard("5555555555555555", new DateCard("2023", "07"), 666, 17.56f, 11000);
            DebetCard card7 = new DebetCard("6666666666666666", new DateCard("2023", "06"), 777, 950);
            Cash cash2 = new Cash(400);
            List<IPayment> paymentMethods4 = new List<IPayment>() { card6, card7, cash2 };
            BankClient client4 = new BankClient("Sasha", "Vasechkin", new Address("Brest", "Kupalskaya", 4, 4), paymentMethods4);

            List<BankClient> bankClients = new List<BankClient>() { client4, client1, client3, client2 };


            bankClients.Sort(new NameClientComparer());
            Console.WriteLine("    Sorting by customer lastname:     ");
            foreach (BankClient bankClient in bankClients)
            { 
            bankClient.ShowPaymentInfo();
            }

            bankClients.Sort(new AddressClientComparer());
            Console.WriteLine("\n    Sorting by customer address:     ");

            foreach (BankClient bankClient in bankClients)
            {
                bankClient.ShowPaymentInfo();
            }

            bankClients.Sort(new QuantityCardsComparer());
            Console.WriteLine("\n    Sorting by quantity payment means:     ");
            foreach (BankClient bankClient in bankClients)
            {
                bankClient.ShowPaymentInfo();
            }

            bankClients.Sort(new AmountSumComparer());
            Console.WriteLine("\n    Sorting by total amount of money:     ");
            foreach (BankClient bankClient in bankClients)
            {
                bankClient.ShowPaymentInfo();
            }

            bankClients.Sort(new MaxSumCardsComparer());
            Console.WriteLine("\n    Sorting by the amount of money on one payment mean:     ");
            foreach (BankClient bankClient in bankClients)
            {
                bankClient.ShowPaymentInfo();
            }

        }

        static void Main(string[] args)

        {
            //Task1();
            Task2();
        }
    }
}

namespace HomeWork1
{
    internal class Program

    {


        static void Main(string[] args)

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

            CustomerInfo customerInfo = new CustomerInfo("Ivanov", "Ivan", address, "375291111111");
            CustomerInfo customerInfo1 = new CustomerInfo("Petrov", "Petr", address1, "375292222222");
            CustomerInfo customerInfo2 = new CustomerInfo("Sidorov", "Sidor", address2, "375293333333");
            CustomerInfo customerInfo3 = new CustomerInfo("Kruglov", "Nikolay", address3, "375294444444");
            CustomerInfo customerInfo4 = new CustomerInfo("Beglov", "Boris", address4, "375295555555");

            DebetCard card1 = new DebetCard("1111111111111115", datecard, customerInfo, 111, 15000.00f);
            DebetCard card2 = new DebetCard("2222222222222225", datecard1, customerInfo1, 222, 19000.00f);
            CreditCard card3 = new CreditCard("3333333333333335", datecard2, customerInfo2, 333, 20.56f, 120000.00f);
            CreditCard card4 = new CreditCard("4444444444444445", datecard3, customerInfo3, 444, 18.56f, 100000.00f);
            DebetCard card5 = new DebetCard("5555555555555555", datecard4, customerInfo4, 555, 25000.00f);
            CashBackCard card6 = new CashBackCard("5555555555556666", datecard4, customerInfo4, 556, 9000.00f, 2.15f);
            CashBackCard card7 = new CashBackCard("5555555555557777", datecard3, customerInfo3, 557, 6000.00f, 2.00f);
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
    }
}

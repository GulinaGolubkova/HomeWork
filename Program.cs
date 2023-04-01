namespace HomeWork1
{
    internal class Program
    {
        static bool ListCustomers(PaymentCard[] form)
        {   

            foreach (PaymentCard Customer in form)
            {
                string information = Customer.GetFullInformation();
                Console.WriteLine(information);
            }
            return true;
        }

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

                DebetCard Customer = new DebetCard("1111111111111115", datecard, customerInfo, 111, 18.11f, 15000.00f);
                DebetCard Customer1 = new DebetCard("2222222222222225", datecard1, customerInfo1, 222, 19.33f, 19000.00f);
                CreditCard Customer2 = new CreditCard("3333333333333335", datecard2, customerInfo2, 333, 20.56f, 120000.00f);                
                CreditCard Customer3 = new CreditCard("4444444444444445", datecard3, customerInfo3, 444, 18.56f, 100000.00f);
                
                DebetCard Customer4 = new DebetCard("5555555555555555", datecard4, customerInfo4, 555, 20.22f, 25000.00f);

                PaymentCard[] form = new PaymentCard[] { Customer, Customer1, Customer2, Customer3, Customer4 };

                ListCustomers(form);
                





            }
        }
    }

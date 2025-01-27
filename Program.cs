using POO_CSharp_P12.Entities;
using System.Globalization;

namespace POO_CSharp_P11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Classes abstratas");

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1005, "Junior", 500.0, 0.01));
            list.Add(new BusinessAccount(1006, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1007, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1008, "Ana", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sobreposição, palavras virtual, override e base");
           // Account acc6 = new Account(1001, "Alex", 500.0);
            Account acc7 = new SavingsAccount(1004, "Anna", 500.0, 1.01);

           // acc6.Withdraw(10.0);
            acc7.Withdraw(10.0);

           // Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Exemplo Upcasting e downcasting");

            //Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            //Console.WriteLine(acc.ToString());
            Console.WriteLine(bacc);
            // UPCASTING
            Console.WriteLine("UPCASTING");
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc3.Balance);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            // DOWNCASTING
            Console.WriteLine("DOWNCASTING");
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Exemplo Herança:");
            BusinessAccount account = new BusinessAccount(810, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0;
        }
    }
}
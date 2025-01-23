using POO_CSharp_P12.Entities;

namespace POO_CSharp_P11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Exemplo Upcasting e downcasting");

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            Console.WriteLine(acc.ToString());
            Console.WriteLine(bacc);
            // UPCASTING
            Console.WriteLine("UPCASTING");
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);
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
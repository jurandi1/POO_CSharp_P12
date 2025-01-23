using POO_CSharp_P12.Entities;

namespace POO_CSharp_P11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(810, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0;
        }
    }
}
﻿namespace POO_CSharp_P12.Entities
{
    internal class Account
    {
        public int Number { get; private  set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        
        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
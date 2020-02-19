using System;

namespace Section_10.Ex1
{
    public class Account
    {
        public int Number { protected set; get; }
        public String Holder { protected set; get; }
        public double Balance { protected set; get; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

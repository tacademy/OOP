using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Deposit : Account, IInterest
{
    public Deposit(string name, double balance, double interestRate, Holder holder)
        : base(name, balance, interestRate, holder)
    { 
    }
    public void DepositMoney(double ammount)
    {
        balance += ammount;
    }
    public void WithdrawMoney(double ammount)
    {
        balance -= ammount;
    }

    public double CalculateInterest(int months, double rate)
    {
        if (balance > 0 && balance < 1000)
        {
            return 0;
        }
        else 
        {
            return months * rate;
        }
    }
}


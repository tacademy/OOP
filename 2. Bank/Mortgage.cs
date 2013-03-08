using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Mortgage : Account, IInterest
{
    public Mortgage(string name, double balance, double interestRate, Holder holder)
        : base(name, balance, interestRate, holder)
    { 
    }

    public void DepositMoney(double ammount)
    {
        balance += ammount;
    }

    public double CalculateInterest(int months, double rate)
    {
        if (holder == Holder.company)
        {
            return (months * rate) / 2;
        }
        else
        {
            if (months == 6)
            {
                return 0;
            }
            else
            {
                return (months - 6) * rate;
            }
        }
    }
}

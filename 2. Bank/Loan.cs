using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Loan : Account, IInterest
{
    public Loan(string name, double balance, double interestRate, Holder holder)
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
            if (months == 2)
            {
                return 0;
            }
            else
            {
                return (months - 2) * rate;
            }
        }
        else
        {
            if (months == 3)
            {
                return 0;
            }
            else
            {
                return (months - 3) * rate;
            }
        }
    }
}

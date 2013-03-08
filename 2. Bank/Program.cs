using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        
        Deposit dep = new Deposit("Gosho", 100, 10, Account.Holder.person);
        dep.DepositMoney(100);
        Console.WriteLine(dep.balance);
    }
}


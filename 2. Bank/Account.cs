using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract class Account
{
    string customer;
    protected double interestRate;
    public double balance { get; set; }
    public enum Holder
    {
        company,
        person
    }
    public  Holder holder = new Holder();
    
    public Account(string customer, double balance, double interestRate, Holder holder)
    {
        this.customer = customer;
        this.balance = balance;
        this.interestRate = interestRate;
        this.holder = holder;

    }

    
       
}

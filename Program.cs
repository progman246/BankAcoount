using System;
using classes;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account=new Bankaccount("ali",1000);
            Console.WriteLine($"account {account.Number}"+" "+$" was created for {account.Owner} with {account.Balance} initial Balance ");
        }
    }
}

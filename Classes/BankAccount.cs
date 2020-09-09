using System;
namespace classes
{
public class Bankaccount
{
    private static int accountNumberSeed=1234567890;
    public string Number {get;}
    public string Owner{get;set;}
    public decimal Balance{get;}
    public Bankaccount(string name,decimal initialBalance)
    {
        this.Owner=name;
        this.Balance=initialBalance;
        this.Number=accountNumberSeed.ToString();
        accountNumberSeed++;

    }
    public void MakeDeposite(decimal amount,DateTime date,string notes)
    {

    }
    public void MakeWithdrow(decimal amount,DateTime date,string notes)
    {

    }
}
}
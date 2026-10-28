public class BankAccount
{
    public string AccountNumber{get;set;}=null!;
    public double Balance{get;set;}
    public string OwnerName{get; set;}=null!;
    public void ToUp(double a)
    {
        Balance+=a;
    }
    public void Withdraw(double s)
    {
        Balance = Balance-s;
    }
    public double PrintStatement()
    {
       return Balance;
    }
}
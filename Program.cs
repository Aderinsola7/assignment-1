using System;
using System.Globalization;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)

        {
            Account account = new Account("Betiku", "Aderinsola", "0246618978", 5000M);
            Console.WriteLine("Welcome {0} {1} {2} \n Your Balance is NGN{3}", account.FirstName, account.LastName, account.Bvn, account.Balance);
            Console.WriteLine();




            SavingsAccount sa = new SavingsAccount(account.FirstName, account.LastName, account.Bvn, account.Balance, 0.05M);
            decimal totalCredit = 10000.0M;

            Console.WriteLine("Beginning balance is NGN{0}", account.Balance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: NGN{0}", totalCredit);
            sa.Credit(totalCredit);
            Console.WriteLine("Ending balance is: NGN{0}", sa.Balance);
            Console.WriteLine();




            CheckingAccount ca = new CheckingAccount(5000.00M, 26.00M);
            Console.WriteLine("Beginning balance is NGN{0}", account.Balance);
            ca.Credit(10000.00M);
            ca.Debit(1000.00M);
            Console.WriteLine("Ending balance is NGN{0}", ca.Balance);

            Console.ReadLine();
        }
    }
}
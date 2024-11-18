using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Sobreposicao.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
        : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount < LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                System.Console.WriteLine("Exceded Loan Limit");
            }
        }
        override public string ToString()
        {
            return "Account number: " + Number + ", Owner: " + Holder + ", Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture) + ", Loan Limit: " + LoanLimit.ToString("F2", CultureInfo.InvariantCulture);
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
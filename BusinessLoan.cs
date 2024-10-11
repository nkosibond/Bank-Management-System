using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    public class BusinessLoan : Loan
    {
        public BusinessLoan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term) : base(loanNumber, customerLastName, customerFirstName, loanAmount, term)
        {
        }

        public BusinessLoan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term, double primeInterestRate,double LoanAmount) : base(loanNumber, customerLastName, customerFirstName, loanAmount, term)
        {
            InterestRate = InterestRate + 1;
            loanAmount = InterestRate * loanAmount + loanAmount;
            loanAmountToDate = (InterestRate / 100) * term + loanAmount + loanAmount;
        }

        //public override string ToString()
        //{
        //    return $"Loan Type: Business Loan\n{customerFirstName} {customerLastName}\nLoan Number: {loanNumber}\nLoan Amount: {loanAmount:C} \nInterest Rate: {InterestRate}%\nTerm: {Term} year(s) \nTotal Repayment: {loanAmountToDate:C}";
        //}

        public override double GetAmountOwed()
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2781_PROJECT
{
    public abstract class Loan : LoanConstantsInterface
    {
        protected int loanNumber;
        protected string customerLastName;
        protected string customerFirstName;
        protected double loanAmount,dueamount, installments;
        protected int term;
        protected double interestRate = 15;

        public double loanAmountToDate;
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public int Term { get => term; set => term = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }

        public Loan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, int term)
        {
            LoanNumber = loanNumber;
            CustomerLastName = customerLastName;
            CustomerFirstName = customerFirstName;
            LoanAmount = loanAmount; // Add this line
            Term = term;             // Add this line

        }

        protected Loan(int loanNumber, string customerLastName, string customerFirstName, double loanAmount, double dueamount, double installments, int term, double interestRate)
        {
            this.loanNumber = loanNumber;
            this.customerLastName = customerLastName;
            this.customerFirstName = customerFirstName;
            this.loanAmount = loanAmount;
            this.dueamount = dueamount;
            this.installments = installments;
            this.term = term;
            this.interestRate = interestRate;
        }

        public abstract double GetAmountOwed();

        public int ShortTerm => 1;
        public int MediumTerm => 3;
        public int LongTerm => 5;
        public string CompanyName => "Unique Business Solutions";
        public int MaxLoanAmount => 100000;

        public double Dueamount { get => Dueamount; set => Dueamount = value; }
        public double Installments { get => installments; set => installments = value; }

        public override string ToString()
        {
            return $"Loan Number: {LoanNumber}\n" +
                   $"Customer: {CustomerFirstName} {CustomerLastName}\n" +
                   $"Loan Amount: {LoanAmount:C}\n" +
                   $"Interest Rate: {InterestRate}%\n" +
                   $"Term: {Term} years";
        }

        
    }
}

using System;

namespace CSharp.Activity.Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
           // LoanSystem example = new LoanSystem ();
            LoanSystem loanSystem = new LoanSystem();
            loanSystem.ProcessLoanApplication(new LoanSystem.ProcessLoanDelegate(Show));
            Console.ReadLine();
        }

        //Display the loan applicant's credit score.
        static void Show(LoanApplicant showApplicant)
        {
            Console.WriteLine("Loan Applicant's Credit Score: {0}", showApplicant.CreditScore);
        }
    }
}
      

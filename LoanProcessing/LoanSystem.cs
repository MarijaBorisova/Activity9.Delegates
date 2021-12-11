using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Activity.Delegates
{
    public class LoanSystem
    {
        //the method that ar parameter takes delegate instance, creates a LoanApplicant
        //instance, assigns the credit score and then invokes the delegate showApplicant.
       
        private LoanApplicant _LoanApplicant = new LoanApplicant();

        // Delegate for processing a loan.
        public delegate void ProcessLoanDelegate(LoanApplicant showApplicant);
       
        // Process the loan application.
        public void ProcessLoanApplication(ProcessLoanDelegate showApplicant)
            {

                // Assign the credit score
                this.AssignCreditScore(_LoanApplicant);

                // Invoke the callback the delegate showApplicant
                showApplicant(_LoanApplicant);
            }

        // Assign the applicant's credit score.
        private void AssignCreditScore(LoanApplicant showApplicant)
            {
                Random randNumber = new Random();
                showApplicant.CreditScore = randNumber.Next(100) + 1;
            }
        }

    }


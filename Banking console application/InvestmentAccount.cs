

using System.Security.Principal;
using static Banking_console_application.Display;

namespace Banking_console_application
{


    public class InvestmentAccount : CustomerAccount
    {
        private int v1;
        private string v2;
        private int v3;
        private int v4;
        private int v5;

        public decimal Investment { get; private set; }

        public InvestmentAccount(int id, string firstName, string lastName, string accountType, decimal accountNumber, decimal accountBalance, decimal investment)
            : base(id, firstName, lastName, accountType)
        {
            Investment = investment;
        }

       
    }
}

    



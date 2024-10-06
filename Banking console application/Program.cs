using static Banking_console_application.Bank;
using static Banking_console_application.Display;
using static Banking_console_application.Display.CustomerAccount;

namespace Banking_console_application
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Account.Welcome();

           Account.DisplayCustomer();

            CustomerAccount account1 = new CustomerAccount(1, "Tom", "Anady", " CustomerAccount", 11, 1000);
            InvestmentAccount account2 = new InvestmentAccount(2, "Tom", "Anady", "InvestmentAccount", 22, 40000,0);
            SavingsAccount account3 = new SavingsAccount(3,"Tom","Anady", "SavingsAccount",33, 60000,5);

            Bank bankkonto = new Bank(); 
            Bankkonto.Menu(account1);
            Bankkonto.Menu(account2);
            Bankkonto.Menu(account3);

            Console.WriteLine("You have exited.");




        }
    }
}

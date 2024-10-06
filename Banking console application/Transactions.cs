

using static Banking_console_application.Display;
using static Banking_console_application.Display.CustomerAccount;

namespace Banking_console_application
{
    
    public enum Transactions
    {
            ShowBlance,
            Deposit,
            Withdram,
            Transfer,
    }
    public static class Account
    {

        public static void Welcome()
        {

            Console.WriteLine("\n\n\nWelcome to your your account where you can manage your bank account");
        }


        public static void DisplayMenu()
        {

            Console.WriteLine(" Choose an a options :");
            Console.WriteLine("1. AccountBlance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Transfer Money");
            Console.WriteLine("5. ShowTranssactions");
            Console.WriteLine("6. Exit");


        }
         public static CustomerAccount DisplayCustomer()
    {
            List<CustomerAccount> Accounts = new List<CustomerAccount>
            {
              new CustomerAccount(1,"Tom","Anady","MainAccount",11,20000),
              new InvestmentAccount(2,"Tom","Anady","investmentAccount",22,40000,3),
              new SavingsAccount(3, "Tom", "Anady", "SavingsAccount",33, 60000,5),

            };
            
            foreach (var customerAccount in Accounts)
            {
                Console.WriteLine($"\tAccountId:{customerAccount.Id} Name:{customerAccount.FirstName}{customerAccount.LastName}n\t\taccountType:{customerAccount.AccountType}");
               
            }
            Console.WriteLine("\nEnter customer's Account's Id");
            int Kund = 0;
            do
            {
                try
                {
                    Kund = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Error: Invalid Input!");
                    Kund = 0;
                }
                if (Kund <= 0 || Kund > 3)
                {
                    Console.WriteLine("Invalid Id");
                }


            } while (Kund == 6);


            CustomerAccount account1 = Accounts[Kund - 1];

            Console.WriteLine($"Account Chosen:{account1.LastName}");

            return account1;
        }

        

    }
   

        
    
}



using Banking_console_application;

namespace Banking_console_application

{
    public class Display
    {
        public class CustomerAccount
        {
            public int Id { get; private set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string AccountType { get; set; }
       
            public float AccountNumber { get; set; }
            public float AccountBlance { get; set; }
            
            private float minLimitCredit = 300;
            private int kontonummer;
            private string kontoinnehavare;
            private double saldo;

            public void updateBalance(float amt, updateType update)
            {
                if (update == updateType.add)
                {
                    AccountBlance += amt;
                }
                else if (update == updateType.substract)
                {
                    if (AccountBlance - amt > minLimitCredit)
                    {
                        AccountBlance -= amt;
                    }
                    else
                    {
                        Console.WriteLine("Your account is too low to withdra this amount of credit!");
                    }
                }

            }
            public CustomerAccount(int id, string firstName, string lastName, string accountType, float accountNumber, float accountBlance)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                AccountNumber = accountNumber;
                AccountType = accountType;
                AccountBlance = accountBlance;

            }

            public CustomerAccount(int id, string firstName, string lastName, string accountType)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                AccountType = accountType;
            }

            public CustomerAccount(int id, string firstName, string lastName, string accountType,int kontonummer, string kontoinnehavare, double saldo)

            {
                this.Id = id;
                this.FirstName = firstName;
                this.LastName = lastName;
                this.AccountType = accountType;
                this.kontonummer = kontonummer;
                this.kontoinnehavare = kontoinnehavare;
                this.saldo = saldo;
            }

 
        }

    }
        public enum updateType
        {
            add,
            substract
        }
       
}





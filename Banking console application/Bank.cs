

using System.Transactions;
using static Banking_console_application.Display;

namespace Banking_console_application
{
    internal class Bank
    {

        public static class Bankkonto

        {
            public static List<Transactions> transactionsMade = new List<Transactions>();
            public static List<DateTime> transactionsDates = new List<DateTime>();


            public static void ShowBalance(CustomerAccount customer)
            {
                Console.WriteLine($"\nAccount Balance :{customer.AccountBlance}");

            }
            public static void DepositCredit(CustomerAccount customer)
            {
                Console.WriteLine("This is the section for depositing credit. ");
                float amt = EnterAmount();
                customer.updateBalance(amt, updateType.add);
                ShowBalance(customer);

            }
            public static void WithdrawCredit(CustomerAccount customer)
            {
                Console.WriteLine("This is the section for Withdraw credit. ");
                float amt = EnterAmount();
                customer.updateBalance(amt, updateType.substract);
                ShowBalance(customer);

            }
            public static void TransferCredit(CustomerAccount sender)
            {
                CustomerAccount customer = Account.DisplayCustomer();

                Console.WriteLine("This is the section for Transfering credit. ");

                CustomerAccount receiver = Account.DisplayCustomer();


                float amt = EnterAmount();
                sender.updateBalance(amt, updateType.substract);
                receiver.updateBalance(amt, updateType.add);
                ShowBalance(sender);




            }
            public static void ShowTranssactionsCredit(CustomerAccount customer)
            {
                Console.WriteLine("\tTransactions made are:\n");
                for (int i = 0; i < transactionsDates.Count; i++)
                {
                    Console.WriteLine($"Transaction:{transactionsMade[i]}" +
                         $"\n\tDate: {transactionsDates[i]}\n\n ");
                }

            }

            public static void Menu(CustomerAccount Account)
            {
                bool looping = true;

                while (looping)
                {
                    Banking_console_application.Account.DisplayMenu();
                    int option = 0;
                    do
                    {

                        try
                        {
                            option = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            option = 0;
                            Console.WriteLine("Error:Invalid Input");
                        }
                        if (option <= 0 || option > 6)
                        {
                            option = 0;
                        }
                    } while (option == 0);
                    switch (option)
                    {
                        case 1:
                            ShowBalance(Account);
                            transactionsMade.Add(Transactions.ShowBlance);
                            transactionsDates.Add(DateTime.Now);
                            break;
                        case 2:
                            DepositCredit(Account);
                            transactionsMade.Add(Transactions.Deposit);
                            transactionsDates.Add(DateTime.Now);
                            break;
                        case 3:
                            WithdrawCredit(Account);
                            transactionsMade.Add(Transactions.Withdram);
                            transactionsDates.Add(DateTime.Now);
                            break;
                        case 4:
                            TransferCredit(Account);
                            transactionsMade.Add(Transactions.Transfer);
                            transactionsDates.Add(DateTime.Now);
                            break;
                        case 5:
                            ShowTranssactionsCredit(Account);
                            break;

                        default:

                            looping = false;
                            break;
                    }
                }
            }
            private static float EnterAmount()
            {
                float num = 0;
                do
                {
                    Console.Write("Enter Amout:");
                    try
                    {
                        num = float.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        num = 0;
                        Console.WriteLine("Error:Invlid Amount.");
                    }
                } while (num == 0);
                return num;
            }

        }
    }
}

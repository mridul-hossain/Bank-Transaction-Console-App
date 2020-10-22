using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Hosting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(100);
            Account acc = new Account();
            Account s=new Savings();
            Account c = new Checking();


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("-----COMMAND LIST-----\n");
                Console.WriteLine("open ----- for ------- opening an account");
                Console.WriteLine("account ----- for ------- performing a transaction");
                Console.WriteLine("quit ----- for ------- exit\n\n");
                Console.Write("Please type your command: ");
                String bank = Console.ReadLine();

                //Bank b = new Bank(100);
                //Account acc = new Account();
                //Savings s = new Savings();
                //Checking c = new Checking();

                switch (bank)
                {
                    case "open":
                        Console.WriteLine("\n\nOpen an account:\n");
                        Console.WriteLine("-----COMMAND LIST-----");
                        Console.WriteLine("savings ----- for ------- opening a savings account");
                        Console.WriteLine("checking ----- for ------- opening a checking account");
                        Console.WriteLine("quit ----- for ------- exit\n\n");
                        Console.Write("Please type your command: ");

                        string open = Console.ReadLine();
                        //Bank b = new Bank(100);
                        //Account acc = new Account();
                        //Savings s = new Savings();

                            switch (open)
                            {
                                case "savings":

                                    Console.WriteLine("Write your name: ");
                                    s.AccountName = Console.ReadLine();
                                    Console.WriteLine("\nWrite your date of birth: ");
                                    s.DOB = Console.ReadLine();
                                    Console.WriteLine("\nWrite your address: ");
                                    s.AccountAddress = Console.ReadLine();
                                    Console.WriteLine("\nWrite your starting amount: ");
                                    s.CurrentBalance = Convert.ToInt32(Console.ReadLine());
                                s.ID();
                                    b.CreateAccount(s);
                                
                                
                                Console.WriteLine("Your account is successfully created.\nYour account number: "+s.Account_Number);
                                //acc.AccountDetails(Console.ReadLine());
                                break;
                                case "checking":
                                    Console.WriteLine("Write your name: ");
                                    c.AccountName = Console.ReadLine();
                                    Console.WriteLine("\nWrite your date of birth: ");
                                    c.DOB = Console.ReadLine();
                                    Console.WriteLine("\nWrite your address: ");
                                    c.AccountAddress = Console.ReadLine();
                                    Console.WriteLine("\nWrite your starting amount: ");
                                    c.CurrentBalance = Convert.ToInt32(Console.ReadLine());
                                c.ID();
                                    b.CreateAccount(c);
                                Console.WriteLine("Your account is successfully created.\nYour account number: " + c.Account_Number);
                                break;
                            case "quit":
                                break;
                            default:
                                Console.WriteLine("ERROR: Please write your command as it shown!");
                                break;
                        }
                        
                        break;

                    case "account":
                        Console.WriteLine("Perform transactions on an account:\n");
                        Console.WriteLine("-----COMMAND LIST-----");
                        Console.WriteLine("deposit ----- for ------- making a deposit");
                        Console.WriteLine("withdraw ----- for ------- making a withdraw");
                        Console.WriteLine("transfer ----- for ------- making a transfer");
                        Console.WriteLine("change ----- for ------- changing name");
                        Console.WriteLine("show ----- for ------- showing the number of transactions");
                        Console.WriteLine("quit ----- for ------- exit\n\n");
                        Console.Write("Please type your command: ");

                        string cmd = Console.ReadLine();

                        switch (cmd)
                        {
                            case "deposit":
                                string AccountNumber;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber = Convert.ToString(Console.ReadLine());
                                if(AccountNumber==s.Account_Number)
                                {
                                    s.Deposit(AccountNumber);
                                }
                                else if (AccountNumber == c.Account_Number)
                                {
                                    c.Deposit(AccountNumber);
                                }
                                break;
                            case "withdraw":
                                string AccountNumber1;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber1 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber1 == s.Account_Number)
                                {
                                    s.Withdraw(AccountNumber1);
                                }
                                else if (AccountNumber1 == c.Account_Number)
                                {
                                    c.Withdraw(AccountNumber1);
                                }
                                break;
                            case "transfer":
                                string AccountNumber2;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber2 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber2 == s.Account_Number)
                                {
                                    s.Transfer(acc,AccountNumber2);
                                }
                                else if (AccountNumber2 == c.Account_Number)
                                {
                                    c.Transfer(acc,AccountNumber2);
                                }
                                break;
                            case "change":
                                string AccountNumber3;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber3 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber3 == s.Account_Number)
                                {
                                    s.ChangeName(AccountNumber3);
                                }
                                else if (AccountNumber3 == c.Account_Number)
                                {
                                    //c.Deposit(AccountNumber3);
                                }
                                break;
                            case "show":
                                string AccountNumber4;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber4 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber4 == s.Account_Number)
                                {
                                    Console.WriteLine("Till the number of transactions: " + s.TransactionNumber());
                                }
                                else if (AccountNumber4 == c.Account_Number)
                                {
                                    Console.WriteLine("Till the number of transactions: " + c.TransactionNumber());
                                }
                                break;
                            case "quit":
                                break;
                            default:
                                Console.WriteLine("ERROR: Please write your command as it shown!");
                                break;
                        }
                        break;
                }

                if(bank=="quit")
                {
                    break;
                }
            }

            
            
                
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Bank
{
    class Account
    {
        private string Name;
        private string DateOfBirth;
        private string Address;
        private int Balance;
        private string AccountNumber;
        public static int accNumber = 101;
        public int transaction = 0;

        public string Account_Number
        {
            set { this.AccountNumber = value; }
            get { return this.AccountNumber; }

        }
        public string AccountName
        {
            set { this.Name = value; }
            get { return this.Name; }
        }

        public string DOB
        {
            set { this.DateOfBirth = value; }
            get { return this.DateOfBirth; }
        }

        public string AccountAddress
        {
            set { this.Address = value; }
            get { return this.Address; }
        }

        

        public int CurrentBalance
        {
            set { this.Balance = value; }
            get { return this.Balance; }
        }

        public int ID()
        {
            this.Account_Number = accNumber.ToString();
            accNumber++;
            return accNumber;
        }



        public int TransactionNumber()
        {
            transaction++;
            return transaction;
        }


        public virtual void Deposit(string ANumber)
        {
            ANumber = this.Account_Number;

        }

        public virtual void Withdraw(string ANumber)
        {
            ANumber = this.Account_Number;
            
        }


        public virtual void Transfer(Account ANumber1, string ANumber)
        {
            ANumber = this.Account_Number;

        }


        public virtual void ChangeName(string ANumber)
        {
            ANumber = this.Account_Number;

        }
    }
}

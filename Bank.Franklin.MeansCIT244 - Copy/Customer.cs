using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Franklin.MeansCIT244
{
    public class Customer
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int accountNumber;
        private decimal balance;

        public Customer(string fName, string mName, string lName, int aNumber, decimal initialBalance)
        {
            firstName = fName;
            middleName = mName;
            lastName = lName;
            accountNumber = aNumber;
            balance = initialBalance;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}

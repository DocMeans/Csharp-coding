using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Customer
    {
        private string firstName;
        private string lastName;
        private int accountNumber;
        private double depositAmount;
        private double withdrawAmount;
        private double balance;

        // Constructors
        public Customer(string _firstName, string _lastName, int _accountNumber,
            double _depositAmount, double _withdrawAmount, double _balance)
        {
            firstName = _firstName;
            this.lastName = _lastName;
            this.accountNumber = _accountNumber;
            this.depositAmount = _depositAmount;
            this.withdrawAmount = _withdrawAmount;
            this.balance = _balance;
        }

        public Customer(string _firstName, string _lastName, int _accountNumber, 
            double _withdrawAmount, double _balance)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.accountNumber = _accountNumber;
            this.withdrawAmount = _withdrawAmount;
            this.balance = _balance;
        }

        public string _firstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string _lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int _accountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double _depositAmount
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }

        public double _withdrawAmount
        {
            get { return withdrawAmount; }
            set { depositAmount = value; }
        }

        public double _balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Calculate deposit
        public double DepositTo(double accountBalance, double depositAmount)
        {
            double balance;
            balance = accountBalance + depositAmount;
            return balance;
        }

        // Calculate withdraw amount
        public static double WithdrawFrom(double accountBalance, double withdrawAmount)
        {
            double balance;
            balance = accountBalance - withdrawAmount;
            if(balance <= 0)
            {
                MessageBox.Show("Error! Cannot withdraw more money than what's in the account");
                return accountBalance;
            }
            else
            {
                balance = accountBalance - withdrawAmount;
            }
            return balance;
        }



    }
}

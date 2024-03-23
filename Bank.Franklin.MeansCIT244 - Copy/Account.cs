using System;
using System.Linq;
using System.Windows.Forms;
/*
 Bank app: Franklin Means 02/21/2024
 */
namespace Bank.Franklin.MeansCIT244
{
    // The Account class represents the main form of the banking application.
    public partial class Account : Form
    {
        private Customer customer; // Stores customer information.
        private bool isFirstTransaction = true; // Tracks if it's the first transaction.

        // Constructor for the Account form.
        public Account()
        {
            InitializeComponent();
            HideDepositAndWithdrawControls();
        }
        // This method handles the update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Setting variables for easier readability
            string firstName = tbxFirstName.Text;
            string middleName = tbxMiddleName.Text;
            string lastName = tbxLastName.Text;
            string accountNumberStr = tbxAccountNumber.Text;

            //Ensures the the name fields are not numbers.
            if (!IsValidName(firstName) || !IsValidName(middleName) || !IsValidName(lastName))
            {
                MessageBox.Show("Invalid name. Please enter alphabetic characters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Ensure the account numbers are digits.
            if (!int.TryParse(accountNumberStr, out int accountNumber))
            {
                MessageBox.Show("Account number must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customer == null)
            {
                // For initial transaction:
                if (!decimal.TryParse(tbxInitialDeposit.Text, out decimal initialBalance))
                {
                    MessageBox.Show("Invalid initial balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customer = new Customer(firstName, middleName, lastName, accountNumber, initialBalance);
                isFirstTransaction = false;
                UpdateAccountBalanceLabel();
                ShowDepositAndWithdrawControls();
                HideInitalDepositControl();
            }
            else
            {
                // For subsequent transactions:
                if (!isFirstTransaction && !HasTransaction())
                {
                    MessageBox.Show("Please enter either a deposit or withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal amount = 0;
                // Performs deposit or withdrawal based on user input.
                if (decimal.TryParse(tbxDeposit.Text, out decimal depositAmount))
                {
                    amount = depositAmount;
                    customer.Deposit(depositAmount);
                }
                else if (decimal.TryParse(tbxWithdraw.Text, out decimal withdrawAmount))
                {
                    amount = -withdrawAmount;
                    customer.Withdraw(withdrawAmount);
                }
                else
                {
                    MessageBox.Show("Please enter a valid deposit or withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UpdateAccountBalanceLabel(); // Updates the account balance label.
                ResetFields(); // Resets input fields.
            }
        }
        // Validates the name by ensuring it contains only alphabetic characters.
        private bool IsValidName(string name)
        {
            return !name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name);
        }
        // Checks if a deposit or withdrawal amount has been entered.
        private bool HasTransaction()
        {
            return !string.IsNullOrWhiteSpace(tbxDeposit.Text) || !string.IsNullOrWhiteSpace(tbxWithdraw.Text);
        }
        // Resets the deposit and withdrawal textboxes.
        private void ResetFields()
        {
            tbxDeposit.Text = string.Empty;
            tbxWithdraw.Text = string.Empty;
        }
        // Updates the account balance label.
        private void UpdateAccountBalanceLabel()
        {
            lblAccountBalance.Text = $"${customer.Balance}";
        }
        // Resets all input fields and flags.
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxFirstName.Text = string.Empty;
            tbxMiddleName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxAccountNumber.Text = string.Empty;
            tbxInitialDeposit.Text = string.Empty;
            tbxDeposit.Text = string.Empty;
            tbxWithdraw.Text = string.Empty;
            lblAccountBalance.Text = string.Empty;
            isFirstTransaction = true;
            HideDepositAndWithdrawControls();
        }
        // Hides the initial deposit control.
        private void HideInitalDepositControl()
        {
            lblIntialDeposit.Visible = false;
            tbxInitialDeposit.Visible = false;
        }
        // Hides deposit and withdraw controls.
        private void HideDepositAndWithdrawControls()
        {
            lblDeposit.Visible = false;
            tbxDeposit.Visible = false;
            lblWithdraw.Visible = false;
            tbxWithdraw.Visible = false;
        }
        // Shows deposit and withdraw controls.
        private void ShowDepositAndWithdrawControls()
        {
            lblDeposit.Visible = true;
            tbxDeposit.Visible = true;
            lblWithdraw.Visible = true;
            tbxWithdraw.Visible = true;
        }
    }
}

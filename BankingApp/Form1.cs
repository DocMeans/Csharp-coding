using System.DirectoryServices.ActiveDirectory;
using System.Xml.Linq;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_submit_Click(object sender, EventArgs e)
        {
            string _firstName = tb_firstName.Text;
            string _lastName = tb_lastName.Text;
            int _accountNumber = int.Parse(tb_accountNumber.Text);
            double _depositAmount = double.Parse(tb_depositAmount.Text);
            double _withdrawAmount = double.Parse(tb_withdrawAmount.Text);
            double _balance = double.Parse(tb_accountBalance.Text);
            Customer aCustomer = new Customer( _firstName, _lastName, _accountNumber,
            _depositAmount, _withdrawAmount, _balance);

            if (_withdrawAmount > 0)
            {
                Customer.WithdrawFrom(_balance,  _withdrawAmount);
            }
            if (_depositAmount <= 0)
            {
                MessageBox.Show("Enter a valid positive number");
            }
            if(_withdrawAmount > _balance) 
            {
               
            }
        }
    }
}

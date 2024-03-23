namespace BankingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAccountNumber = new Label();
            label1 = new Label();
            lblWithdrawAmount = new Label();
            lblDepositAmount = new Label();
            lblAccountBalance = new Label();
            tb_firstName = new TextBox();
            tb_lastName = new TextBox();
            tb_accountNumber = new TextBox();
            tb_withdrawAmount = new TextBox();
            tb_depositAmount = new TextBox();
            tb_accountBalance = new TextBox();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Tahoma", 14.25F);
            lblFirstName.Location = new Point(29, 74);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Tahoma", 14.25F);
            lblLastName.Location = new Point(29, 131);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 23);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Font = new Font("Tahoma", 14.25F);
            lblAccountNumber.Location = new Point(29, 188);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(151, 23);
            lblAccountNumber.TabIndex = 2;
            lblAccountNumber.Text = "Account Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 21);
            label1.Name = "label1";
            label1.Size = new Size(126, 29);
            label1.TabIndex = 3;
            label1.Text = "XYZ Bank";
            // 
            // lblWithdrawAmount
            // 
            lblWithdrawAmount.AutoSize = true;
            lblWithdrawAmount.Font = new Font("Tahoma", 14.25F);
            lblWithdrawAmount.Location = new Point(29, 245);
            lblWithdrawAmount.Name = "lblWithdrawAmount";
            lblWithdrawAmount.Size = new Size(150, 23);
            lblWithdrawAmount.TabIndex = 4;
            lblWithdrawAmount.Text = "Withraw Amount";
            // 
            // lblDepositAmount
            // 
            lblDepositAmount.AutoSize = true;
            lblDepositAmount.Font = new Font("Tahoma", 14.25F);
            lblDepositAmount.Location = new Point(29, 302);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new Size(143, 23);
            lblDepositAmount.TabIndex = 5;
            lblDepositAmount.Text = "Deposit Amount";
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.AutoSize = true;
            lblAccountBalance.Font = new Font("Tahoma", 14.25F);
            lblAccountBalance.Location = new Point(29, 359);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(148, 23);
            lblAccountBalance.TabIndex = 6;
            lblAccountBalance.Text = "Account Balance";
            // 
            // tb_firstName
            // 
            tb_firstName.Location = new Point(208, 74);
            tb_firstName.Name = "tb_firstName";
            tb_firstName.Size = new Size(100, 23);
            tb_firstName.TabIndex = 7;
            // 
            // tb_lastName
            // 
            tb_lastName.Location = new Point(208, 131);
            tb_lastName.Name = "tb_lastName";
            tb_lastName.Size = new Size(100, 23);
            tb_lastName.TabIndex = 8;
            // 
            // tb_accountNumber
            // 
            tb_accountNumber.Location = new Point(208, 192);
            tb_accountNumber.Name = "tb_accountNumber";
            tb_accountNumber.Size = new Size(100, 23);
            tb_accountNumber.TabIndex = 9;
            tb_accountNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_withdrawAmount
            // 
            tb_withdrawAmount.Location = new Point(208, 249);
            tb_withdrawAmount.Name = "tb_withdrawAmount";
            tb_withdrawAmount.Size = new Size(100, 23);
            tb_withdrawAmount.TabIndex = 10;
            tb_withdrawAmount.Text = "0";
            tb_withdrawAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_depositAmount
            // 
            tb_depositAmount.Location = new Point(208, 306);
            tb_depositAmount.Name = "tb_depositAmount";
            tb_depositAmount.Size = new Size(100, 23);
            tb_depositAmount.TabIndex = 11;
            tb_depositAmount.Text = "0";
            tb_depositAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // tb_accountBalance
            // 
            tb_accountBalance.Location = new Point(208, 359);
            tb_accountBalance.Name = "tb_accountBalance";
            tb_accountBalance.Size = new Size(100, 23);
            tb_accountBalance.TabIndex = 12;
            tb_accountBalance.Text = "0";
            tb_accountBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_submit.Location = new Point(29, 421);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(279, 31);
            btn_submit.TabIndex = 13;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(337, 472);
            Controls.Add(btn_submit);
            Controls.Add(tb_accountBalance);
            Controls.Add(tb_depositAmount);
            Controls.Add(tb_withdrawAmount);
            Controls.Add(tb_accountNumber);
            Controls.Add(tb_lastName);
            Controls.Add(tb_firstName);
            Controls.Add(lblAccountBalance);
            Controls.Add(lblDepositAmount);
            Controls.Add(lblWithdrawAmount);
            Controls.Add(label1);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banking App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAccountNumber;
        private Label label1;
        private Label lblWithdrawAmount;
        private Label lblDepositAmount;
        private Label lblAccountBalance;
        private TextBox tb_firstName;
        private TextBox tb_lastName;
        private TextBox tb_accountNumber;
        private TextBox tb_withdrawAmount;
        private TextBox tb_depositAmount;
        private TextBox tb_accountBalance;
        private Button btn_submit;
    }
}

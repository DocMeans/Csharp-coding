namespace Bank.Franklin.MeansCIT244
{
    partial class Account
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
            lblMiddleName = new Label();
            lblLastName = new Label();
            lblAccountNumber = new Label();
            lblDeposit = new Label();
            lblWithdraw = new Label();
            tbxFirstName = new TextBox();
            tbxMiddleName = new TextBox();
            tbxLastName = new TextBox();
            tbxAccountNumber = new TextBox();
            tbxDeposit = new TextBox();
            tbxWithdraw = new TextBox();
            btnUpdate = new Button();
            btnReset = new Button();
            lblBalance = new Label();
            lblAccountBalance = new Label();
            label2 = new Label();
            lblIntialDeposit = new Label();
            tbxInitialDeposit = new TextBox();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(12, 102);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiddleName.Location = new Point(12, 163);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(109, 21);
            lblMiddleName.TabIndex = 2;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(12, 224);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 21);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountNumber.Location = new Point(12, 285);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(135, 21);
            lblAccountNumber.TabIndex = 6;
            lblAccountNumber.Text = "Account Number";
            // 
            // lblDeposit
            // 
            lblDeposit.AutoSize = true;
            lblDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeposit.Location = new Point(322, 102);
            lblDeposit.Name = "lblDeposit";
            lblDeposit.Size = new Size(67, 21);
            lblDeposit.TabIndex = 8;
            lblDeposit.Text = "Deposit";
            // 
            // lblWithdraw
            // 
            lblWithdraw.AutoSize = true;
            lblWithdraw.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWithdraw.Location = new Point(322, 163);
            lblWithdraw.Name = "lblWithdraw";
            lblWithdraw.Size = new Size(80, 21);
            lblWithdraw.TabIndex = 10;
            lblWithdraw.Text = "Withdraw";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(160, 100);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(100, 23);
            tbxFirstName.TabIndex = 1;
            // 
            // tbxMiddleName
            // 
            tbxMiddleName.Location = new Point(160, 161);
            tbxMiddleName.Name = "tbxMiddleName";
            tbxMiddleName.Size = new Size(100, 23);
            tbxMiddleName.TabIndex = 3;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(160, 222);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(100, 23);
            tbxLastName.TabIndex = 5;
            // 
            // tbxAccountNumber
            // 
            tbxAccountNumber.Location = new Point(160, 283);
            tbxAccountNumber.Name = "tbxAccountNumber";
            tbxAccountNumber.Size = new Size(100, 23);
            tbxAccountNumber.TabIndex = 7;
            // 
            // tbxDeposit
            // 
            tbxDeposit.Location = new Point(470, 100);
            tbxDeposit.Name = "tbxDeposit";
            tbxDeposit.Size = new Size(100, 23);
            tbxDeposit.TabIndex = 9;
            tbxDeposit.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxWithdraw
            // 
            tbxWithdraw.Location = new Point(470, 161);
            tbxWithdraw.Name = "tbxWithdraw";
            tbxWithdraw.Size = new Size(100, 23);
            tbxWithdraw.TabIndex = 11;
            tbxWithdraw.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(322, 224);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(248, 35);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(322, 285);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(248, 35);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(3, 420);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(66, 21);
            lblBalance.TabIndex = 14;
            lblBalance.Text = "Balance";
            // 
            // lblAccountBalance
            // 
            lblAccountBalance.AutoSize = true;
            lblAccountBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountBalance.Location = new Point(151, 416);
            lblAccountBalance.Name = "lblAccountBalance";
            lblAccountBalance.Size = new Size(0, 25);
            lblAccountBalance.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 29);
            label2.Name = "label2";
            label2.Size = new Size(154, 35);
            label2.TabIndex = 16;
            label2.Text = "XYZ Bank";
            // 
            // lblIntialDeposit
            // 
            lblIntialDeposit.AutoSize = true;
            lblIntialDeposit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntialDeposit.Location = new Point(12, 337);
            lblIntialDeposit.Name = "lblIntialDeposit";
            lblIntialDeposit.Size = new Size(107, 21);
            lblIntialDeposit.TabIndex = 17;
            lblIntialDeposit.Text = "Inital Deposit";
            // 
            // tbxInitialDeposit
            // 
            tbxInitialDeposit.Location = new Point(160, 339);
            tbxInitialDeposit.Name = "tbxInitialDeposit";
            tbxInitialDeposit.Size = new Size(100, 23);
            tbxInitialDeposit.TabIndex = 18;
            tbxInitialDeposit.TextAlign = HorizontalAlignment.Right;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(588, 505);
            Controls.Add(tbxInitialDeposit);
            Controls.Add(lblIntialDeposit);
            Controls.Add(label2);
            Controls.Add(lblAccountBalance);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(tbxWithdraw);
            Controls.Add(tbxDeposit);
            Controls.Add(tbxAccountNumber);
            Controls.Add(tbxLastName);
            Controls.Add(tbxMiddleName);
            Controls.Add(tbxFirstName);
            Controls.Add(lblBalance);
            Controls.Add(lblWithdraw);
            Controls.Add(lblDeposit);
            Controls.Add(lblAccountNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblLastName;
        private Label lblAccountNumber;
        private Label lblDeposit;
        private Label lblWithdraw;
        private TextBox tbxFirstName;
        private TextBox tbxMiddleName;
        private TextBox tbxLastName;
        private TextBox tbxAccountNumber;
        private TextBox tbxDeposit;
        private TextBox tbxWithdraw;
        private Button btnUpdate;
        private Button btnReset;
        private Label lblBalance;
        private Label lblAccountBalance;
        private Label label2;
        private Label lblIntialDeposit;
        private TextBox tbxInitialDeposit;
    }
}

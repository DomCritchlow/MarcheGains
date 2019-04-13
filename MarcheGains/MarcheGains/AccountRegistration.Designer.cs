namespace MarcheGains
{
    partial class AccountRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccName_Box = new System.Windows.Forms.TextBox();
            this.AccNum_Box = new System.Windows.Forms.TextBox();
            this.Checking_check = new System.Windows.Forms.CheckBox();
            this.Savings_check = new System.Windows.Forms.CheckBox();
            this.AccRouting_Box = new System.Windows.Forms.TextBox();
            this.Invest_Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Account_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccName_Box
            // 
            this.AccName_Box.Location = new System.Drawing.Point(136, 38);
            this.AccName_Box.Name = "AccName_Box";
            this.AccName_Box.Size = new System.Drawing.Size(100, 20);
            this.AccName_Box.TabIndex = 0;
            // 
            // AccNum_Box
            // 
            this.AccNum_Box.Location = new System.Drawing.Point(136, 80);
            this.AccNum_Box.Name = "AccNum_Box";
            this.AccNum_Box.Size = new System.Drawing.Size(100, 20);
            this.AccNum_Box.TabIndex = 1;
            // 
            // Checking_check
            // 
            this.Checking_check.AutoSize = true;
            this.Checking_check.Location = new System.Drawing.Point(136, 115);
            this.Checking_check.Name = "Checking_check";
            this.Checking_check.Size = new System.Drawing.Size(76, 17);
            this.Checking_check.TabIndex = 2;
            this.Checking_check.Text = "Checkings";
            this.Checking_check.UseVisualStyleBackColor = true;
            // 
            // Savings_check
            // 
            this.Savings_check.AutoSize = true;
            this.Savings_check.Location = new System.Drawing.Point(136, 138);
            this.Savings_check.Name = "Savings_check";
            this.Savings_check.Size = new System.Drawing.Size(64, 17);
            this.Savings_check.TabIndex = 3;
            this.Savings_check.Text = "Savings";
            this.Savings_check.UseVisualStyleBackColor = true;
            // 
            // AccRouting_Box
            // 
            this.AccRouting_Box.Location = new System.Drawing.Point(136, 185);
            this.AccRouting_Box.Name = "AccRouting_Box";
            this.AccRouting_Box.Size = new System.Drawing.Size(100, 20);
            this.AccRouting_Box.TabIndex = 4;
            // 
            // Invest_Balance
            // 
            this.Invest_Balance.Location = new System.Drawing.Point(136, 227);
            this.Invest_Balance.Name = "Invest_Balance";
            this.Invest_Balance.Size = new System.Drawing.Size(100, 20);
            this.Invest_Balance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Routing Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Investment Balance";
            // 
            // Account_Reg
            // 
            this.Account_Reg.Location = new System.Drawing.Point(136, 276);
            this.Account_Reg.Name = "Account_Reg";
            this.Account_Reg.Size = new System.Drawing.Size(75, 23);
            this.Account_Reg.TabIndex = 10;
            this.Account_Reg.Text = "Register";
            this.Account_Reg.UseVisualStyleBackColor = true;
            this.Account_Reg.Click += new System.EventHandler(this.Account_Reg_Click);
            // 
            // AccountRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(364, 395);
            this.Controls.Add(this.Account_Reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Invest_Balance);
            this.Controls.Add(this.AccRouting_Box);
            this.Controls.Add(this.Savings_check);
            this.Controls.Add(this.Checking_check);
            this.Controls.Add(this.AccNum_Box);
            this.Controls.Add(this.AccName_Box);
            this.Name = "AccountRegistration";
            this.Text = "AccountRegistration";
            this.Load += new System.EventHandler(this.AccountRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccName_Box;
        private System.Windows.Forms.TextBox AccNum_Box;
        private System.Windows.Forms.CheckBox Checking_check;
        private System.Windows.Forms.CheckBox Savings_check;
        private System.Windows.Forms.TextBox AccRouting_Box;
        private System.Windows.Forms.TextBox Invest_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Account_Reg;
    }

    partial class CopyOfAccountRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccName_Box = new System.Windows.Forms.TextBox();
            this.AccNum_Box = new System.Windows.Forms.TextBox();
            this.Checking_check = new System.Windows.Forms.CheckBox();
            this.Savings_check = new System.Windows.Forms.CheckBox();
            this.AccRouting_Box = new System.Windows.Forms.TextBox();
            this.Invest_Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Account_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccName_Box
            // 
            this.AccName_Box.Location = new System.Drawing.Point(136, 38);
            this.AccName_Box.Name = "AccName_Box";
            this.AccName_Box.Size = new System.Drawing.Size(100, 20);
            this.AccName_Box.TabIndex = 0;
            // 
            // AccNum_Box
            // 
            this.AccNum_Box.Location = new System.Drawing.Point(136, 80);
            this.AccNum_Box.Name = "AccNum_Box";
            this.AccNum_Box.Size = new System.Drawing.Size(100, 20);
            this.AccNum_Box.TabIndex = 1;
            // 
            // Checking_check
            // 
            this.Checking_check.AutoSize = true;
            this.Checking_check.Location = new System.Drawing.Point(136, 115);
            this.Checking_check.Name = "Checking_check";
            this.Checking_check.Size = new System.Drawing.Size(76, 17);
            this.Checking_check.TabIndex = 2;
            this.Checking_check.Text = "Checkings";
            this.Checking_check.UseVisualStyleBackColor = true;
            // 
            // Savings_check
            // 
            this.Savings_check.AutoSize = true;
            this.Savings_check.Location = new System.Drawing.Point(136, 138);
            this.Savings_check.Name = "Savings_check";
            this.Savings_check.Size = new System.Drawing.Size(64, 17);
            this.Savings_check.TabIndex = 3;
            this.Savings_check.Text = "Savings";
            this.Savings_check.UseVisualStyleBackColor = true;
            // 
            // AccRouting_Box
            // 
            this.AccRouting_Box.Location = new System.Drawing.Point(136, 185);
            this.AccRouting_Box.Name = "AccRouting_Box";
            this.AccRouting_Box.Size = new System.Drawing.Size(100, 20);
            this.AccRouting_Box.TabIndex = 4;
            // 
            // Invest_Balance
            // 
            this.Invest_Balance.Location = new System.Drawing.Point(136, 227);
            this.Invest_Balance.Name = "Invest_Balance";
            this.Invest_Balance.Size = new System.Drawing.Size(100, 20);
            this.Invest_Balance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Routing Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Investment Balance";
            // 
            // Account_Reg
            // 
            this.Account_Reg.Location = new System.Drawing.Point(136, 275);
            this.Account_Reg.Name = "Account_Reg";
            this.Account_Reg.Size = new System.Drawing.Size(75, 23);
            this.Account_Reg.TabIndex = 10;
            this.Account_Reg.Text = "Register";
            this.Account_Reg.UseVisualStyleBackColor = true;
            this.Account_Reg.Click += new System.EventHandler(this.Account_Reg_Click);
            // 
            // CopyOfAccountRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 395);
            this.Controls.Add(this.Account_Reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Invest_Balance);
            this.Controls.Add(this.AccRouting_Box);
            this.Controls.Add(this.Savings_check);
            this.Controls.Add(this.Checking_check);
            this.Controls.Add(this.AccNum_Box);
            this.Controls.Add(this.AccName_Box);
            this.Name = "CopyOfAccountRegistration";
            this.Text = "CopyOfAccountRegistration";
            this.Load += new System.EventHandler(this.AccountRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccName_Box;
        private System.Windows.Forms.TextBox AccNum_Box;
        private System.Windows.Forms.CheckBox Checking_check;
        private System.Windows.Forms.CheckBox Savings_check;
        private System.Windows.Forms.TextBox AccRouting_Box;
        private System.Windows.Forms.TextBox Invest_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Account_Reg;
    }
}
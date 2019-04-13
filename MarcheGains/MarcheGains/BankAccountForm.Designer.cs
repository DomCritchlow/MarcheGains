namespace MarcheGains
{
    partial class BankAccountForm
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
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.header_box = new System.Windows.Forms.TextBox();
            this.Balance_Box = new System.Windows.Forms.TextBox();
            this.balance_label = new System.Windows.Forms.Label();
            this.Nobank_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(353, 304);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(173, 57);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(156, 304);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(148, 57);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(230, 197);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(229, 48);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register Account";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(558, 465);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(98, 38);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // header_box
            // 
            this.header_box.BackColor = System.Drawing.Color.Silver;
            this.header_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_box.Location = new System.Drawing.Point(13, 13);
            this.header_box.Name = "header_box";
            this.header_box.ReadOnly = true;
            this.header_box.Size = new System.Drawing.Size(643, 29);
            this.header_box.TabIndex = 6;
            this.header_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Balance_Box
            // 
            this.Balance_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_Box.Location = new System.Drawing.Point(156, 128);
            this.Balance_Box.Name = "Balance_Box";
            this.Balance_Box.ReadOnly = true;
            this.Balance_Box.Size = new System.Drawing.Size(370, 38);
            this.Balance_Box.TabIndex = 7;
            this.Balance_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_label.Location = new System.Drawing.Point(252, 100);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(173, 25);
            this.balance_label.TabIndex = 8;
            this.balance_label.Text = "Current Balance:";
            // 
            // Nobank_label
            // 
            this.Nobank_label.AutoSize = true;
            this.Nobank_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nobank_label.Location = new System.Drawing.Point(151, 169);
            this.Nobank_label.Name = "Nobank_label";
            this.Nobank_label.Size = new System.Drawing.Size(375, 25);
            this.Nobank_label.TabIndex = 9;
            this.Nobank_label.Text = "No Bank Account has been registered";
            this.Nobank_label.Click += new System.EventHandler(this.Nobank_label_Click);
            // 
            // BankAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(668, 511);
            this.Controls.Add(this.Nobank_label);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.Balance_Box);
            this.Controls.Add(this.header_box);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Name = "BankAccountForm";
            this.Text = "BankAccountForm";
            this.Load += new System.EventHandler(this.BankAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox header_box;
        private System.Windows.Forms.TextBox Balance_Box;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.Label Nobank_label;
    }
}
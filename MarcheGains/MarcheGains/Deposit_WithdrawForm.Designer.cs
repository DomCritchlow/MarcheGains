namespace MarcheGains
{
    partial class Deposit_WithdrawForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.transaction_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // amount_box
            // 
            this.amount_box.Location = new System.Drawing.Point(48, 115);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(100, 20);
            this.amount_box.TabIndex = 1;
            // 
            // transaction_button
            // 
            this.transaction_button.Location = new System.Drawing.Point(60, 183);
            this.transaction_button.Name = "transaction_button";
            this.transaction_button.Size = new System.Drawing.Size(75, 23);
            this.transaction_button.TabIndex = 2;
            this.transaction_button.Text = "Default";
            this.transaction_button.UseVisualStyleBackColor = true;
            this.transaction_button.Click += new System.EventHandler(this.transaction_button_Click);
            // 
            // Deposit_WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(189, 261);
            this.Controls.Add(this.transaction_button);
            this.Controls.Add(this.amount_box);
            this.Controls.Add(this.label1);
            this.Name = "Deposit_WithdrawForm";
            this.Text = "Deposit_WithdrawForm";
            this.Load += new System.EventHandler(this.Deposit_WithdrawForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.Button transaction_button;
    }
}
namespace MarcheGains
{
    partial class UserRegistration
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
            this.Name_NewUser = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Password2Box = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name_NewUser
            // 
            this.Name_NewUser.AutoSize = true;
            this.Name_NewUser.Location = new System.Drawing.Point(45, 25);
            this.Name_NewUser.Name = "Name_NewUser";
            this.Name_NewUser.Size = new System.Drawing.Size(35, 13);
            this.Name_NewUser.TabIndex = 0;
            this.Name_NewUser.Text = "Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(44, 56);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.Location = new System.Drawing.Point(44, 87);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(53, 13);
            this.Password1.TabIndex = 2;
            this.Password1.Text = "Password";
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Location = new System.Drawing.Point(44, 115);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(91, 13);
            this.password2.TabIndex = 3;
            this.password2.Text = "Repeat Password";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(137, 25);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 7;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(137, 56);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameBox.TabIndex = 8;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(137, 89);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 9;
            // 
            // Password2Box
            // 
            this.Password2Box.Location = new System.Drawing.Point(137, 115);
            this.Password2Box.Name = "Password2Box";
            this.Password2Box.PasswordChar = '*';
            this.Password2Box.Size = new System.Drawing.Size(100, 20);
            this.Password2Box.TabIndex = 10;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(107, 183);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Begin Gains";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 142);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 15;
            this.label.Text = "Email Address";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(137, 142);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 16;
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(286, 231);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.Password2Box);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Name_NewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserRegistration";
            this.Text = "UserRegistration";
            this.Load += new System.EventHandler(this.UserRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_NewUser;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox Password2Box;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox EmailTextBox;
    }
}
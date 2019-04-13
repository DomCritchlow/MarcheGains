namespace MarcheGains
{
    partial class ViewInvestments
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remove_button = new System.Windows.Forms.Button();
            this.Purchase_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Qty_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticker_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAccountLabel = new System.Windows.Forms.Label();
            this.TotalCartBalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 399);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(344, 375);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "Name";
            this.columnHeader0.Width = 122;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ticker";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 153;
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(443, 22);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 23);
            this.remove_button.TabIndex = 1;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // Purchase_button
            // 
            this.Purchase_button.Location = new System.Drawing.Point(443, 61);
            this.Purchase_button.Name = "Purchase_button";
            this.Purchase_button.Size = new System.Drawing.Size(75, 23);
            this.Purchase_button.TabIndex = 2;
            this.Purchase_button.Text = "Purchase";
            this.Purchase_button.UseVisualStyleBackColor = true;
            this.Purchase_button.Click += new System.EventHandler(this.Purchase_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qty_grid,
            this.Name_grid,
            this.Ticker_grid,
            this.Price_grid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 369);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Qty_grid
            // 
            this.Qty_grid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Qty_grid.FillWeight = 50F;
            this.Qty_grid.HeaderText = "Qty";
            this.Qty_grid.Name = "Qty_grid";
            // 
            // Name_grid
            // 
            this.Name_grid.HeaderText = "Name";
            this.Name_grid.Name = "Name_grid";
            // 
            // Ticker_grid
            // 
            this.Ticker_grid.HeaderText = "Ticker";
            this.Ticker_grid.Name = "Ticker_grid";
            // 
            // Price_grid
            // 
            this.Price_grid.HeaderText = "Price";
            this.Price_grid.Name = "Price_grid";
            // 
            // TotalAccountLabel
            // 
            this.TotalAccountLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TotalAccountLabel.AutoSize = true;
            this.TotalAccountLabel.Location = new System.Drawing.Point(443, 130);
            this.TotalAccountLabel.Name = "TotalAccountLabel";
            this.TotalAccountLabel.Size = new System.Drawing.Size(35, 13);
            this.TotalAccountLabel.TabIndex = 4;
            this.TotalAccountLabel.Text = "label1";
            this.TotalAccountLabel.Click += new System.EventHandler(this.TotalAccountLabel_Click);
            // 
            // TotalCartBalLabel
            // 
            this.TotalCartBalLabel.AutoSize = true;
            this.TotalCartBalLabel.Location = new System.Drawing.Point(443, 233);
            this.TotalCartBalLabel.Name = "TotalCartBalLabel";
            this.TotalCartBalLabel.Size = new System.Drawing.Size(35, 13);
            this.TotalCartBalLabel.TabIndex = 5;
            this.TotalCartBalLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Balance : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cart Total : ";
            // 
            // ViewInvestments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(585, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalCartBalLabel);
            this.Controls.Add(this.TotalAccountLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Purchase_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.listView1);
            this.Name = "ViewInvestments";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ViewInvestments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button Purchase_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticker_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_grid;
        private System.Windows.Forms.Label TotalAccountLabel;
        private System.Windows.Forms.Label TotalCartBalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
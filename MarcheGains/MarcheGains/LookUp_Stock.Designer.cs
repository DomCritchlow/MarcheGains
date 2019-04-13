namespace MarcheGains
{
    partial class LookUp_Stock
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tickerBox = new System.Windows.Forms.TextBox();
            this.tickerLabel = new System.Windows.Forms.Label();
            this.LookupButton = new System.Windows.Forms.Button();
            this.StockInfoBox = new System.Windows.Forms.TextBox();
            this.ChooseStock = new System.Windows.Forms.Button();
            this.StockAddedLabel = new System.Windows.Forms.Label();
            this.ItemsInCartLabel = new System.Windows.Forms.Label();
            this.purchase_button = new System.Windows.Forms.Button();
            this.qty_box = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tickerBox
            // 
            this.tickerBox.Location = new System.Drawing.Point(83, 12);
            this.tickerBox.Name = "tickerBox";
            this.tickerBox.Size = new System.Drawing.Size(100, 20);
            this.tickerBox.TabIndex = 0;
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Location = new System.Drawing.Point(12, 12);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(65, 13);
            this.tickerLabel.TabIndex = 1;
            this.tickerLabel.Text = "Enter Ticker";
            // 
            // LookupButton
            // 
            this.LookupButton.Location = new System.Drawing.Point(83, 38);
            this.LookupButton.Name = "LookupButton";
            this.LookupButton.Size = new System.Drawing.Size(100, 23);
            this.LookupButton.TabIndex = 2;
            this.LookupButton.Text = "Look Up Stock";
            this.LookupButton.UseVisualStyleBackColor = true;
            this.LookupButton.Click += new System.EventHandler(this.LookupButton_Click);
            // 
            // StockInfoBox
            // 
            this.StockInfoBox.Location = new System.Drawing.Point(12, 67);
            this.StockInfoBox.Multiline = true;
            this.StockInfoBox.Name = "StockInfoBox";
            this.StockInfoBox.Size = new System.Drawing.Size(320, 263);
            this.StockInfoBox.TabIndex = 3;
            this.StockInfoBox.TextChanged += new System.EventHandler(this.StockInfoBox_TextChanged);
            // 
            // ChooseStock
            // 
            this.ChooseStock.Location = new System.Drawing.Point(12, 362);
            this.ChooseStock.Name = "ChooseStock";
            this.ChooseStock.Size = new System.Drawing.Size(103, 23);
            this.ChooseStock.TabIndex = 4;
            this.ChooseStock.Text = "Add to Cart";
            this.ChooseStock.UseVisualStyleBackColor = true;
            this.ChooseStock.Click += new System.EventHandler(this.ChooseStock_Click);
            // 
            // StockAddedLabel
            // 
            this.StockAddedLabel.AutoSize = true;
            this.StockAddedLabel.Location = new System.Drawing.Point(9, 339);
            this.StockAddedLabel.Name = "StockAddedLabel";
            this.StockAddedLabel.Size = new System.Drawing.Size(154, 13);
            this.StockAddedLabel.TabIndex = 5;
            this.StockAddedLabel.Text = "Please add a stock to your cart";
            this.StockAddedLabel.Click += new System.EventHandler(this.StockAddedLabel_Click);
            // 
            // ItemsInCartLabel
            // 
            this.ItemsInCartLabel.AutoSize = true;
            this.ItemsInCartLabel.Location = new System.Drawing.Point(218, 18);
            this.ItemsInCartLabel.Name = "ItemsInCartLabel";
            this.ItemsInCartLabel.Size = new System.Drawing.Size(24, 13);
            this.ItemsInCartLabel.TabIndex = 6;
            this.ItemsInCartLabel.Text = "test";
            // 
            // purchase_button
            // 
            this.purchase_button.Location = new System.Drawing.Point(221, 362);
            this.purchase_button.Name = "purchase_button";
            this.purchase_button.Size = new System.Drawing.Size(111, 23);
            this.purchase_button.TabIndex = 7;
            this.purchase_button.Text = "Purchase Stock";
            this.purchase_button.UseVisualStyleBackColor = true;
            this.purchase_button.Click += new System.EventHandler(this.purchase_button_Click);
            // 
            // qty_box
            // 
            this.qty_box.Location = new System.Drawing.Point(221, 336);
            this.qty_box.Name = "qty_box";
            this.qty_box.Size = new System.Drawing.Size(111, 20);
            this.qty_box.TabIndex = 8;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Silver;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(339, 67);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Close Price";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(450, 263);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // LookUp_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(801, 396);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.qty_box);
            this.Controls.Add(this.purchase_button);
            this.Controls.Add(this.ItemsInCartLabel);
            this.Controls.Add(this.StockAddedLabel);
            this.Controls.Add(this.ChooseStock);
            this.Controls.Add(this.StockInfoBox);
            this.Controls.Add(this.LookupButton);
            this.Controls.Add(this.tickerLabel);
            this.Controls.Add(this.tickerBox);
            this.Name = "LookUp_Stock";
            this.Text = "LookUp_Stock";
            this.Load += new System.EventHandler(this.LookUp_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tickerBox;
        private System.Windows.Forms.Label tickerLabel;
        private System.Windows.Forms.Button LookupButton;
        private System.Windows.Forms.TextBox StockInfoBox;
        private System.Windows.Forms.Button ChooseStock;
        private System.Windows.Forms.Label StockAddedLabel;
        private System.Windows.Forms.Label ItemsInCartLabel;
        private System.Windows.Forms.Button purchase_button;
        private System.Windows.Forms.TextBox qty_box;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
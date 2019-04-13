namespace MarcheGains
{
    partial class MainMenu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ViewAccountButton = new System.Windows.Forms.Button();
            this.ViewStocksButton = new System.Windows.Forms.Button();
            this.ViewInvestmentsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.CustomerInfobox = new System.Windows.Forms.TextBox();
            this.StockofDay_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VolumeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAccountButton
            // 
            this.ViewAccountButton.Location = new System.Drawing.Point(12, 67);
            this.ViewAccountButton.Name = "ViewAccountButton";
            this.ViewAccountButton.Size = new System.Drawing.Size(162, 30);
            this.ViewAccountButton.TabIndex = 0;
            this.ViewAccountButton.Text = "Manage Bank Account";
            this.ViewAccountButton.UseVisualStyleBackColor = true;
            this.ViewAccountButton.Click += new System.EventHandler(this.ViewAccountButton_Click);
            // 
            // ViewStocksButton
            // 
            this.ViewStocksButton.Location = new System.Drawing.Point(12, 124);
            this.ViewStocksButton.Name = "ViewStocksButton";
            this.ViewStocksButton.Size = new System.Drawing.Size(162, 30);
            this.ViewStocksButton.TabIndex = 1;
            this.ViewStocksButton.Text = "View Stocks";
            this.ViewStocksButton.UseVisualStyleBackColor = true;
            this.ViewStocksButton.Click += new System.EventHandler(this.ViewStocksButton_Click);
            // 
            // ViewInvestmentsButton
            // 
            this.ViewInvestmentsButton.Location = new System.Drawing.Point(12, 198);
            this.ViewInvestmentsButton.Name = "ViewInvestmentsButton";
            this.ViewInvestmentsButton.Size = new System.Drawing.Size(162, 30);
            this.ViewInvestmentsButton.TabIndex = 2;
            this.ViewInvestmentsButton.Text = "View Cart";
            this.ViewInvestmentsButton.UseVisualStyleBackColor = true;
            this.ViewInvestmentsButton.Click += new System.EventHandler(this.ViewInvestmentsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(12, 292);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(162, 30);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Securely Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CustomerInfobox
            // 
            this.CustomerInfobox.BackColor = System.Drawing.Color.Silver;
            this.CustomerInfobox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerInfobox.Location = new System.Drawing.Point(3, 12);
            this.CustomerInfobox.Name = "CustomerInfobox";
            this.CustomerInfobox.ReadOnly = true;
            this.CustomerInfobox.Size = new System.Drawing.Size(300, 13);
            this.CustomerInfobox.TabIndex = 5;
            this.CustomerInfobox.TextChanged += new System.EventHandler(this.CustomerInfobox_TextChanged);
            // 
            // StockofDay_Box
            // 
            this.StockofDay_Box.BackColor = System.Drawing.Color.Silver;
            this.StockofDay_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockofDay_Box.Location = new System.Drawing.Point(256, 67);
            this.StockofDay_Box.Multiline = true;
            this.StockofDay_Box.Name = "StockofDay_Box";
            this.StockofDay_Box.ReadOnly = true;
            this.StockofDay_Box.Size = new System.Drawing.Size(290, 291);
            this.StockofDay_Box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MarcheGains Recommended Stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VolumeChart
            // 
            this.VolumeChart.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.VolumeChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Silver;
            legend2.Name = "Legend1";
            this.VolumeChart.Legends.Add(legend2);
            this.VolumeChart.Location = new System.Drawing.Point(12, 370);
            this.VolumeChart.Name = "VolumeChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Close Price";
            this.VolumeChart.Series.Add(series2);
            this.VolumeChart.Size = new System.Drawing.Size(537, 300);
            this.VolumeChart.TabIndex = 8;
            this.VolumeChart.Text = "Volume Chart";
            this.VolumeChart.Click += new System.EventHandler(this.VolumeChart_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Location = new System.Drawing.Point(471, 7);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_Button.TabIndex = 9;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(561, 682);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.VolumeChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockofDay_Box);
            this.Controls.Add(this.CustomerInfobox);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ViewInvestmentsButton);
            this.Controls.Add(this.ViewStocksButton);
            this.Controls.Add(this.ViewAccountButton);
            this.Name = "MainMenu";
            this.Text = "MarcheGains";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewAccountButton;
        private System.Windows.Forms.Button ViewStocksButton;
        private System.Windows.Forms.Button ViewInvestmentsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TextBox CustomerInfobox;
        private System.Windows.Forms.TextBox StockofDay_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart VolumeChart;
        private System.Windows.Forms.Button Refresh_Button;
    }
}
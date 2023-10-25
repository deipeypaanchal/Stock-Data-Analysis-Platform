namespace Project_1
{
    partial class FormEntry
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_LoadStockData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView_Stock = new System.Windows.Forms.DataGridView();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCandlestickBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_EndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LoadStockData
            // 
            this.button_LoadStockData.Location = new System.Drawing.Point(1371, 438);
            this.button_LoadStockData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_LoadStockData.Name = "button_LoadStockData";
            this.button_LoadStockData.Size = new System.Drawing.Size(285, 51);
            this.button_LoadStockData.TabIndex = 1;
            this.button_LoadStockData.Text = "Load Stock Data";
            this.button_LoadStockData.UseVisualStyleBackColor = true;
            this.button_LoadStockData.Click += new System.EventHandler(this.button_LoadStockData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Stock files| *.csv| Daily Stocks|*-Day.csv| Weekly Stocks|*-Week.csv|Monthly " +
    "Stocks|*-Month.csv";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\Deipey Paanchal\\Desktop\\Stock Data";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView_Stock
            // 
            this.dataGridView_Stock.AllowUserToAddRows = false;
            this.dataGridView_Stock.AllowUserToDeleteRows = false;
            this.dataGridView_Stock.AutoGenerateColumns = false;
            this.dataGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.openDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView_Stock.DataSource = this.aCandlestickBindingSource1;
            this.dataGridView_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Stock.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Stock.Name = "dataGridView_Stock";
            this.dataGridView_Stock.ReadOnly = true;
            this.dataGridView_Stock.RowHeadersWidth = 51;
            this.dataGridView_Stock.RowTemplate.Height = 24;
            this.dataGridView_Stock.Size = new System.Drawing.Size(1774, 234);
            this.dataGridView_Stock.TabIndex = 3;
            this.dataGridView_Stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.ReadOnly = true;
            this.openDataGridViewTextBoxColumn.Width = 125;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.ReadOnly = true;
            this.highDataGridViewTextBoxColumn.Width = 125;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn.Width = 125;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.volumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCandlestickBindingSource1
            // 
            this.aCandlestickBindingSource1.DataSource = typeof(Project_1.aCandlestick);
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(1371, 298);
            this.dateTimePicker_StartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_StartDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(395, 31);
            this.dateTimePicker_StartDate.TabIndex = 4;
            this.dateTimePicker_StartDate.Value = new System.DateTime(2023, 7, 1, 12, 46, 0, 0);
            this.dateTimePicker_StartDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(1371, 384);
            this.dateTimePicker_EndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(395, 31);
            this.dateTimePicker_EndDate.TabIndex = 5;
            this.dateTimePicker_EndDate.Value = new System.DateTime(2023, 7, 15, 13, 10, 0, 0);
            this.dateTimePicker_EndDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Title = "Price";
            chartArea1.Name = "area_OHLC";
            chartArea2.AlignWithChartArea = "area_OHLC";
            chartArea2.AxisX.Title = "Date";
            chartArea2.AxisY.Title = "Volume";
            chartArea2.Name = "area_Volume";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.aCandlestickBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 244);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "area_OHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green, LabelValueType=Low";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "seriesOHLC";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "low, high, open, close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "area_Volume";
            series2.Legend = "Legend1";
            series2.Name = "seriesVolume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueMembers = "volume";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1363, 769);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart_stock_Click);
            // 
            // aCandlestickBindingSource
            // 
            this.aCandlestickBindingSource.DataSource = typeof(Project_1.aCandlestick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(1371, 499);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(285, 51);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Location = new System.Drawing.Point(1374, 265);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(108, 25);
            this.label_StartDate.TabIndex = 8;
            this.label_StartDate.Text = "Start Date";
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(1370, 354);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(101, 25);
            this.label_EndDate.TabIndex = 9;
            this.label_EndDate.Text = "End Date";
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1018);
            this.Controls.Add(this.label_EndDate);
            this.Controls.Add(this.label_StartDate);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.dataGridView_Stock);
            this.Controls.Add(this.button_LoadStockData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEntry";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_LoadStockData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_StartDate;
        private System.Windows.Forms.Label label_EndDate;
    }
}


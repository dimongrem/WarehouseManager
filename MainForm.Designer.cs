namespace Coursework
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControls = new System.Windows.Forms.TabControl();
            this.GoodsPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewGoodButton = new System.Windows.Forms.Button();
            this.SalesPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewSaleButton = new System.Windows.Forms.Button();
            this.StatsPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GoodsGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WH1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WH2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateBTNColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBTNColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.SaleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleGoodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleUpdateBTNColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaleDeleteBTNColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DemandChangePage = new System.Windows.Forms.TabPage();
            this.MostPopularPage = new System.Windows.Forms.TabPage();
            this.MostPopularGridView = new System.Windows.Forms.DataGridView();
            this.PopularTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopularPriorityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopularNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopularIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatsTabControl = new System.Windows.Forms.TabControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.GoodComboBox = new System.Windows.Forms.ComboBox();
            this.GetStatsButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TabControls.SuspendLayout();
            this.GoodsPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SalesPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.StatsPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.DemandChangePage.SuspendLayout();
            this.MostPopularPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostPopularGridView)).BeginInit();
            this.StatsTabControl.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControls
            // 
            this.TabControls.Controls.Add(this.GoodsPage);
            this.TabControls.Controls.Add(this.SalesPage);
            this.TabControls.Controls.Add(this.StatsPage);
            this.TabControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControls.Location = new System.Drawing.Point(0, 0);
            this.TabControls.Name = "TabControls";
            this.TabControls.SelectedIndex = 0;
            this.TabControls.Size = new System.Drawing.Size(784, 461);
            this.TabControls.TabIndex = 1;
            // 
            // GoodsPage
            // 
            this.GoodsPage.Controls.Add(this.panel2);
            this.GoodsPage.Controls.Add(this.panel1);
            this.GoodsPage.Location = new System.Drawing.Point(4, 22);
            this.GoodsPage.Name = "GoodsPage";
            this.GoodsPage.Padding = new System.Windows.Forms.Padding(3);
            this.GoodsPage.Size = new System.Drawing.Size(776, 435);
            this.GoodsPage.TabIndex = 0;
            this.GoodsPage.Text = "Goods";
            this.GoodsPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 383);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewGoodButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 40);
            this.panel1.TabIndex = 1;
            // 
            // NewGoodButton
            // 
            this.NewGoodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGoodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGoodButton.Location = new System.Drawing.Point(0, 0);
            this.NewGoodButton.Name = "NewGoodButton";
            this.NewGoodButton.Size = new System.Drawing.Size(770, 40);
            this.NewGoodButton.TabIndex = 0;
            this.NewGoodButton.Text = "Add new item";
            this.NewGoodButton.UseVisualStyleBackColor = true;
            this.NewGoodButton.Click += new System.EventHandler(this.NewGoodButton_Click);
            // 
            // SalesPage
            // 
            this.SalesPage.Controls.Add(this.panel5);
            this.SalesPage.Controls.Add(this.panel3);
            this.SalesPage.Location = new System.Drawing.Point(4, 22);
            this.SalesPage.Name = "SalesPage";
            this.SalesPage.Padding = new System.Windows.Forms.Padding(3);
            this.SalesPage.Size = new System.Drawing.Size(776, 435);
            this.SalesPage.TabIndex = 1;
            this.SalesPage.Text = "Sales";
            this.SalesPage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NewSaleButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 40);
            this.panel3.TabIndex = 1;
            // 
            // NewSaleButton
            // 
            this.NewSaleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewSaleButton.Location = new System.Drawing.Point(0, 0);
            this.NewSaleButton.Name = "NewSaleButton";
            this.NewSaleButton.Size = new System.Drawing.Size(770, 40);
            this.NewSaleButton.TabIndex = 0;
            this.NewSaleButton.Text = "Add new item";
            this.NewSaleButton.UseVisualStyleBackColor = true;
            this.NewSaleButton.Click += new System.EventHandler(this.NewSaleButton_Click);
            // 
            // StatsPage
            // 
            this.StatsPage.Controls.Add(this.StatsTabControl);
            this.StatsPage.Location = new System.Drawing.Point(4, 22);
            this.StatsPage.Name = "StatsPage";
            this.StatsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StatsPage.Size = new System.Drawing.Size(776, 435);
            this.StatsPage.TabIndex = 2;
            this.StatsPage.Text = "Stats";
            this.StatsPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GoodsGridView);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 386);
            this.panel4.TabIndex = 0;
            // 
            // GoodsGridView
            // 
            this.GoodsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GoodsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.PriorityColumn,
            this.WH1Column,
            this.WH2Column,
            this.TotalColumn,
            this.UpdateBTNColumn,
            this.DeleteBTNColumn});
            this.GoodsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoodsGridView.Location = new System.Drawing.Point(0, 0);
            this.GoodsGridView.Name = "GoodsGridView";
            this.GoodsGridView.Size = new System.Drawing.Size(776, 386);
            this.GoodsGridView.TabIndex = 2;
            this.GoodsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsGridView_CellContentClick);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // PriorityColumn
            // 
            this.PriorityColumn.HeaderText = "Priority";
            this.PriorityColumn.Name = "PriorityColumn";
            // 
            // WH1Column
            // 
            this.WH1Column.HeaderText = "In the 1st warehouse";
            this.WH1Column.Name = "WH1Column";
            // 
            // WH2Column
            // 
            this.WH2Column.HeaderText = "In the 2nd warehouse";
            this.WH2Column.Name = "WH2Column";
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            // 
            // UpdateBTNColumn
            // 
            this.UpdateBTNColumn.HeaderText = "";
            this.UpdateBTNColumn.Name = "UpdateBTNColumn";
            this.UpdateBTNColumn.Text = "Update";
            this.UpdateBTNColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteBTNColumn
            // 
            this.DeleteBTNColumn.HeaderText = "";
            this.DeleteBTNColumn.Name = "DeleteBTNColumn";
            this.DeleteBTNColumn.Text = "Delete";
            this.DeleteBTNColumn.UseColumnTextForButtonValue = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SalesGridView);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 395);
            this.panel5.TabIndex = 2;
            // 
            // SalesGridView
            // 
            this.SalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleIDColumn,
            this.SaleDateColumn,
            this.GoodIDColumn,
            this.SaleGoodColumn,
            this.SaleCountColumn,
            this.SaleUpdateBTNColumn,
            this.SaleDeleteBTNColumn});
            this.SalesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGridView.Location = new System.Drawing.Point(0, 0);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SalesGridView.Size = new System.Drawing.Size(776, 395);
            this.SalesGridView.TabIndex = 1;
            this.SalesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellContentClick);
            // 
            // SaleIDColumn
            // 
            this.SaleIDColumn.HeaderText = "ID";
            this.SaleIDColumn.Name = "SaleIDColumn";
            // 
            // SaleDateColumn
            // 
            this.SaleDateColumn.HeaderText = "Date";
            this.SaleDateColumn.Name = "SaleDateColumn";
            // 
            // GoodIDColumn
            // 
            this.GoodIDColumn.HeaderText = "Good ID";
            this.GoodIDColumn.Name = "GoodIDColumn";
            // 
            // SaleGoodColumn
            // 
            this.SaleGoodColumn.HeaderText = "Good";
            this.SaleGoodColumn.Name = "SaleGoodColumn";
            // 
            // SaleCountColumn
            // 
            this.SaleCountColumn.HeaderText = "Count";
            this.SaleCountColumn.Name = "SaleCountColumn";
            // 
            // SaleUpdateBTNColumn
            // 
            this.SaleUpdateBTNColumn.HeaderText = "";
            this.SaleUpdateBTNColumn.Name = "SaleUpdateBTNColumn";
            this.SaleUpdateBTNColumn.Text = "Update";
            this.SaleUpdateBTNColumn.UseColumnTextForButtonValue = true;
            // 
            // SaleDeleteBTNColumn
            // 
            this.SaleDeleteBTNColumn.HeaderText = "";
            this.SaleDeleteBTNColumn.Name = "SaleDeleteBTNColumn";
            this.SaleDeleteBTNColumn.Text = "Delete";
            this.SaleDeleteBTNColumn.UseColumnTextForButtonValue = true;
            // 
            // DemandChangePage
            // 
            this.DemandChangePage.Controls.Add(this.panel7);
            this.DemandChangePage.Controls.Add(this.panel6);
            this.DemandChangePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DemandChangePage.Location = new System.Drawing.Point(4, 22);
            this.DemandChangePage.Name = "DemandChangePage";
            this.DemandChangePage.Padding = new System.Windows.Forms.Padding(3);
            this.DemandChangePage.Size = new System.Drawing.Size(762, 403);
            this.DemandChangePage.TabIndex = 2;
            this.DemandChangePage.Text = "Demand change";
            this.DemandChangePage.UseVisualStyleBackColor = true;
            // 
            // MostPopularPage
            // 
            this.MostPopularPage.Controls.Add(this.MostPopularGridView);
            this.MostPopularPage.Location = new System.Drawing.Point(4, 22);
            this.MostPopularPage.Name = "MostPopularPage";
            this.MostPopularPage.Padding = new System.Windows.Forms.Padding(3);
            this.MostPopularPage.Size = new System.Drawing.Size(762, 403);
            this.MostPopularPage.TabIndex = 1;
            this.MostPopularPage.Text = "Most popular";
            this.MostPopularPage.UseVisualStyleBackColor = true;
            // 
            // MostPopularGridView
            // 
            this.MostPopularGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MostPopularGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.MostPopularGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostPopularGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PopularIDColumn,
            this.PopularNameColumn,
            this.PopularPriorityColumn,
            this.PopularTotalColumn});
            this.MostPopularGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MostPopularGridView.Location = new System.Drawing.Point(3, 3);
            this.MostPopularGridView.Name = "MostPopularGridView";
            this.MostPopularGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.MostPopularGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MostPopularGridView.Size = new System.Drawing.Size(756, 397);
            this.MostPopularGridView.TabIndex = 0;
            // 
            // PopularTotalColumn
            // 
            this.PopularTotalColumn.HeaderText = "Total sold";
            this.PopularTotalColumn.Name = "PopularTotalColumn";
            // 
            // PopularPriorityColumn
            // 
            this.PopularPriorityColumn.HeaderText = "Priority";
            this.PopularPriorityColumn.Name = "PopularPriorityColumn";
            // 
            // PopularNameColumn
            // 
            this.PopularNameColumn.HeaderText = "Name";
            this.PopularNameColumn.Name = "PopularNameColumn";
            // 
            // PopularIDColumn
            // 
            this.PopularIDColumn.HeaderText = "ID";
            this.PopularIDColumn.Name = "PopularIDColumn";
            // 
            // StatsTabControl
            // 
            this.StatsTabControl.Controls.Add(this.MostPopularPage);
            this.StatsTabControl.Controls.Add(this.DemandChangePage);
            this.StatsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsTabControl.Location = new System.Drawing.Point(3, 3);
            this.StatsTabControl.Name = "StatsTabControl";
            this.StatsTabControl.SelectedIndex = 0;
            this.StatsTabControl.Size = new System.Drawing.Size(770, 429);
            this.StatsTabControl.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(231, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(528, 397);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.chart1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(528, 397);
            this.panel8.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(528, 397);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Good:";
            // 
            // GoodComboBox
            // 
            this.GoodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodComboBox.FormattingEnabled = true;
            this.GoodComboBox.Location = new System.Drawing.Point(14, 129);
            this.GoodComboBox.Name = "GoodComboBox";
            this.GoodComboBox.Size = new System.Drawing.Size(200, 28);
            this.GoodComboBox.TabIndex = 7;
            // 
            // GetStatsButton
            // 
            this.GetStatsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GetStatsButton.Location = new System.Drawing.Point(0, 362);
            this.GetStatsButton.Name = "GetStatsButton";
            this.GetStatsButton.Size = new System.Drawing.Size(228, 35);
            this.GetStatsButton.TabIndex = 14;
            this.GetStatsButton.Text = "Retrieve data";
            this.GetStatsButton.UseVisualStyleBackColor = true;
            this.GetStatsButton.Click += new System.EventHandler(this.GetStatsButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.GetStatsButton);
            this.panel6.Controls.Add(this.GoodComboBox);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 397);
            this.panel6.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TabControls);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company DB";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControls.ResumeLayout(false);
            this.GoodsPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SalesPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.StatsPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.DemandChangePage.ResumeLayout(false);
            this.MostPopularPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MostPopularGridView)).EndInit();
            this.StatsTabControl.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControls;
        private System.Windows.Forms.TabPage GoodsPage;
        private System.Windows.Forms.TabPage SalesPage;
        private System.Windows.Forms.TabPage StatsPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewGoodButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NewSaleButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView GoodsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WH1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn WH2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateBTNColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBTNColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleGoodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SaleUpdateBTNColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SaleDeleteBTNColumn;
        private System.Windows.Forms.TabControl StatsTabControl;
        private System.Windows.Forms.TabPage MostPopularPage;
        private System.Windows.Forms.DataGridView MostPopularGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopularIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopularNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopularPriorityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopularTotalColumn;
        private System.Windows.Forms.TabPage DemandChangePage;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button GetStatsButton;
        private System.Windows.Forms.ComboBox GoodComboBox;
        private System.Windows.Forms.Label label1;
    }
}


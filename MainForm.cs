using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Coursework
{
    public partial class MainForm : Form
    {
        OracleConnection Connection;
        int UserID = -1;
        List<string[]> dataList;

        public MainForm(OracleConnection connection)
        {
            Connection = connection;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (LoginForm loginForm = new LoginForm(Connection))
            {
                Hide();
                loginForm.ShowDialog();
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    UserID = loginForm.UserID;
                    GetInfo();
                    Show();
                }
                else if (loginForm.DialogResult == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void GetGoodsInfo()
        {
            try
            {
                GoodsGridView.Rows.Clear();
                List<string[]> dataList = DataRetriever.GetGoodsInfo(Connection);
                foreach (string[] str in dataList)
                {
                    GoodsGridView.Rows.Add(str);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        private void GetSalesInfo()
        {
            try
            {
                SalesGridView.Rows.Clear();
                List<string[]> dataList = DataRetriever.GetSalesInfo(Connection);
                foreach (string[] str in dataList)
                {
                    SalesGridView.Rows.Add(str);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exception.StackTrace);
            }
            finally
            {
                Connection.Close();
            }
        }

        private void GetInfo()
        {
            GetGoodsInfo();
            GetSalesInfo();
            UpdateMostPopularStats();
            RefreshStats();
        }

        private void UpdateGoodInfo(int rowIndex)
        {
            try
            {
                int goodID = Convert.ToInt32(GoodsGridView.Rows[rowIndex].Cells["IDColumn"].Value);
                int priority = Convert.ToInt32(GoodsGridView.Rows[rowIndex].Cells["PriorityColumn"].Value);

                string WH1 = GoodsGridView.Rows[rowIndex].Cells["WH1Column"].Value.ToString();
                string WH2 = GoodsGridView.Rows[rowIndex].Cells["WH2Column"].Value.ToString();
                int wh1 = (WH1.Equals("null")) ? -1 : Convert.ToInt32(GoodsGridView.Rows[rowIndex].Cells["WH1Column"].Value);
                int wh2 = (WH2.Equals("null")) ? -1 : Convert.ToInt32(GoodsGridView.Rows[rowIndex].Cells["WH2Column"].Value);
                string name = GoodsGridView.Rows[rowIndex].Cells["NameColumn"].Value.ToString();

                UpdateGoodsForm form = new UpdateGoodsForm(Connection, goodID, name, priority, wh1, wh2);
                form.ShowDialog();
                GetGoodsInfo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateMostPopularStats()
        {
            MostPopularGridView.Rows.Clear();
            dataList = DataRetriever.GetMostPopular(Connection);
            foreach (string[] str in dataList)
            {
                MostPopularGridView.Rows.Add(str);
            }
        }

        private void DeleteGoodInfo(int rowIndex)
        {
            try
            {
                int goodID = Convert.ToInt32(GoodsGridView.Rows[rowIndex].Cells["IDColumn"].Value);
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = Connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "company_database_api.delete_good";
                    cmd.Parameters.Add("good_id", OracleDbType.Decimal).Value = goodID;
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    GetGoodsInfo();
                }    
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Connection.Close();
            }
        }

        private void UpdateSalesInfo(int rowIndex)
        {
            try
            {
                int saleID = Convert.ToInt32(SalesGridView.Rows[rowIndex].Cells["SaleIDColumn"].Value);

                UpdateSalesForm form = new UpdateSalesForm(Connection, saleID);
                form.ShowDialog();
                GetSalesInfo();
                Connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Connection.Close();
            }
        }

        private void DeleteSalesInfo(int rowIndex)
        {
            try
            {
                int saleID = Convert.ToInt32(SalesGridView.Rows[rowIndex].Cells["SaleIDColumn"].Value);
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = Connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "company_database_api.delete_sale";
                    cmd.Parameters.Add("sale_id", OracleDbType.Decimal).Value = saleID;
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    GetSalesInfo();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                Connection.Close();
            }
        }

        private void RefreshStats()
        {
            GoodComboBox.Items.Clear();
            dataList = DataRetriever.GetGoodsList(Connection);
            foreach (string[] str in dataList)
            {
                GoodComboBox.Items.Add(str[1]);
            }
        }

        private void RefreshPlot()
        {
            try
            {
                int goodID = int.Parse(dataList[GoodComboBox.SelectedIndex][0]);
                chart1.Series.Clear();
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = Connection;
                    cmd.CommandText = @"
                                SELECT create_date, SUM(good_count)
                                FROM sales
                                WHERE good_id = " + goodID.ToString() + @"
                                GROUP BY create_date
                                ORDER BY create_date ASC";
                    Connection.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Series series = new Series("Daily Demand");
                        series.ChartType = SeriesChartType.Line;
                        series.XValueType = ChartValueType.DateTime;
                        chart1.ChartAreas[0].AxisX.Title = "Date";
                        chart1.ChartAreas[0].AxisY.Title = "Sold item count";
                        chart1.Series.Add(series);
                        while (reader.Read())
                        {
                            chart1.Series["Daily Demand"].Points.AddXY(Convert.ToDateTime(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(1)));
                        }
                    }
                    reader.Close();
                    Connection.Close();
                }
                chart1.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }

        private void AddNewSale()
        {
            NewSaleForm form = new NewSaleForm(Connection);
            form.ShowDialog();
        }

        private void AddNewGood()
        {
            NewGoodForm form = new NewGoodForm(Connection);
            form.ShowDialog();
        }

        private void GoodsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = GoodsGridView.Columns[e.ColumnIndex].Name;
            if (columnName.Equals("UpdateBTNColumn"))
            {
                UpdateGoodInfo(e.RowIndex);
            }
            else if (columnName.Equals("DeleteBTNColumn"))
            {
                DeleteGoodInfo(e.RowIndex);
            }
        }

        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = SalesGridView.Columns[e.ColumnIndex].Name;
            if (columnName.Equals("SaleUpdateBTNColumn"))
            {
                UpdateSalesInfo(e.RowIndex);
            }
            else if (columnName.Equals("SaleDeleteBTNColumn"))
            {
                DeleteSalesInfo(e.RowIndex);
            }
        }

        private void NewSaleButton_Click(object sender, EventArgs e)
        {
            AddNewSale();
            GetSalesInfo();
            GetGoodsInfo();
            UpdateMostPopularStats();
            RefreshStats();
        }

        private void NewGoodButton_Click(object sender, EventArgs e)
        {
            AddNewGood();
            GetGoodsInfo();
            GetSalesInfo();
            UpdateMostPopularStats();
            RefreshStats();
        }

        private void GetStatsButton_Click(object sender, EventArgs e)
        {
            RefreshPlot();
        }
    }
}

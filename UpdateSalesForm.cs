using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class UpdateSalesForm : Form
    {
        OracleConnection Connection;
        int SaleID;
        List<string[]> dataList;

        public UpdateSalesForm(OracleConnection connection, int saleID)
        {
            InitializeComponent();
            Connection = connection;
            SaleID = saleID;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int goodID = int.Parse(dataList[GoodComboBox.SelectedIndex][0]);
                int goodCount = Convert.ToInt32(CountUpDown.Value);

                using (OracleCommand cmd = new OracleCommand())
                {
                    Connection.Open();
                    cmd.Connection = Connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "company_database_api.update_sale";
                    cmd.Parameters.Add("p_sale_id", OracleDbType.Decimal).Value = SaleID;
                    cmd.Parameters.Add("p_good_id", OracleDbType.Decimal).Value = goodID;
                    cmd.Parameters.Add("p_good_count", OracleDbType.Decimal).Value = goodCount;
                    cmd.ExecuteNonQuery();
                    Close();
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
        private void UpdateSalesForm_Load(object sender, EventArgs e)
        {
            try
            {
                GoodComboBox.Items.Clear();
                dataList = DataRetriever.GetGoodsList(Connection);
                foreach (string[] str in dataList)
                {
                    GoodComboBox.Items.Add(str[1]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

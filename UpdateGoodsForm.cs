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
    public partial class UpdateGoodsForm : Form
    {
        private OracleConnection Connection;
        private int GoodID;
        private int Priority;
        private int Warehouse1;
        private int Warehouse2;
        private string GoodName;

        public UpdateGoodsForm (
            OracleConnection connection,
            int goodID,
            string currentName,
            int currentPriority,
            int currentWH1,
            int currentWH2
        )
        {
            InitializeComponent();
            Connection = connection;
            GoodID = goodID;
            Priority = currentPriority;
            Warehouse1 = currentWH1;
            Warehouse2 = currentWH2;
            GoodName = currentName;
        }

        private void WH1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WH1CheckBox.Checked)
            {
                WH1Label.Enabled = true;
                WH1UpDown.Enabled = true;
            }
            else
            {
                WH1Label.Enabled = false;
                WH1UpDown.Enabled = false;
            }
        }

        private void WH2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WH2CheckBox.Checked)
            {
                WH2Label.Enabled = true;
                WH2UpDown.Enabled = true;
            }
            else
            {
                WH2Label.Enabled = false;
                WH2UpDown.Enabled = false;
            }
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriorityCheckBox.Checked)
            {
                PriorityLabel.Enabled = true;
                PriorityUpDown.Enabled = true;
            }
            else
            {
                PriorityLabel.Enabled = false;
                PriorityUpDown.Enabled = false;
            }
        }

        private void NameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NameCheckBox.Checked)
            {
                NameLabel.Enabled = true;
                NameTextBox.Enabled = true;
            }
            else
            {
                NameLabel.Enabled = false;
                NameTextBox.Enabled = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string newName = (NameCheckBox.Checked) ? NameTextBox.Text : GoodName;
            int newPriority = (PriorityCheckBox.Checked) ? Convert.ToInt32(PriorityUpDown.Value) : Priority;
            int newWarehouse1 = (WH1CheckBox.Checked) ? Convert.ToInt32(WH1UpDown.Value) : Warehouse1;
            int newWarehouse2 = (WH2CheckBox.Checked) ? Convert.ToInt32(WH2UpDown.Value) : Warehouse2;

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Please provide a name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newWarehouse1 < Warehouse1 || newWarehouse2 < Warehouse2)
            {
                MessageBox.Show("Operation is not permitted!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OracleCommand cmd = new OracleCommand())
            {
                try
                {
                    cmd.Connection = Connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "company_database_api.update_goods_info";
                    cmd.Parameters.Add("new_good_id", OracleDbType.Decimal).Value = GoodID;
                    cmd.Parameters.Add("new_good_name", OracleDbType.Varchar2, 50).Value = newName;
                    cmd.Parameters.Add("new_good_priority", OracleDbType.Decimal).Value = newPriority;
                    cmd.Parameters.Add("new_wh1_count", OracleDbType.Double).Value = newWarehouse1;
                    cmd.Parameters.Add("new_wh2_count", OracleDbType.Decimal).Value = newWarehouse2;
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                    Close();
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
        }
    }
}

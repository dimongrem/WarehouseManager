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
    public partial class NewGoodForm : Form
    {
        private OracleConnection Connection;

        public NewGoodForm(OracleConnection connection)
        {
            InitializeComponent();
            Connection = connection;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string newName = NameTextBox.Text;
            int newPriority = Convert.ToInt32(PriorityUpDown.Value);
            int newWarehouse1 = (WH1CheckBox.Checked) ? Convert.ToInt32(WH1UpDown.Value) : -1;
            int newWarehouse2 = (WH2CheckBox.Checked) ? Convert.ToInt32(WH2UpDown.Value) : -1;

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Please provide a name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (OracleCommand cmd = new OracleCommand())
            {
                try
                {
                    cmd.Connection = Connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "company_database_api.add_new_good";
                    cmd.Parameters.Add("good_name", OracleDbType.Varchar2, 50).Value = newName;
                    cmd.Parameters.Add("good_priority", OracleDbType.Decimal).Value = newPriority;
                    cmd.Parameters.Add("in_wh1", OracleDbType.Double).Value = newWarehouse1;
                    cmd.Parameters.Add("in_wh2", OracleDbType.Decimal).Value = newWarehouse2;
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

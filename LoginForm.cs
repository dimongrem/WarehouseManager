using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        private OracleConnection Connection;
        public int UserID = -1;

        public LoginForm(OracleConnection connection)
        {
            InitializeComponent();
            Connection = connection;
            DialogResult = DialogResult.None;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text)
                || string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                ErrorLabel.Text = "Please fill all the gaps!";
                ErrorLabel.Visible = true;
                return;
            }

            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            using (OracleCommand cmd = new OracleCommand())
            {
                cmd.Connection = Connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "company_database_api.get_user_info";
                cmd.Parameters.Add("p_login", OracleDbType.NVarchar2).Value = login;
                cmd.Parameters.Add("p_id", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("p_psw", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
                try
                {
                    Connection.Open();
                    int userID = -1;
                    string passwordHash = "";
                    cmd.ExecuteNonQuery();
                    userID = int.Parse(cmd.Parameters["p_id"].Value.ToString());
                    passwordHash = cmd.Parameters["p_psw"].Value.ToString();

                    if (userID == -1)
                    {
                        ErrorLabel.Text = "User not found!";
                        ErrorLabel.Visible = true;
                        Connection.Close();
                        return;
                    }

                    if (CryptoService.PasswordIsValid(password, passwordHash))
                    {
                        UserID = userID;
                        Close();
                    }
                    else
                    {
                        ErrorLabel.Text = "Invalid password!";
                        ErrorLabel.Visible = true;
                        return;
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
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserID != -1)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

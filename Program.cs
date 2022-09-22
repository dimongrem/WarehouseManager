using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionParams = "Data Source = localhost:1521/orcl; User ID = C##LOGIN; Password = Password123";
            OracleConnection Connection = new OracleConnection(connectionParams);
            try
            {
                Connection.Open();
                Connection.Close();
                Application.Run(new MainForm(Connection));
            }
            catch (Exception)
            {
                MessageBox.Show("No connection to server", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
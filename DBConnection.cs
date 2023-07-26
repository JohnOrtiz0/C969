using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_performance_assessment
{
    public static class DBConnection
    {
        public static MySqlConnection conn = null;
        public static void OpenConnection()
        {
            //get connection string
            string conStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            try
            {
                conn = new MySqlConnection(conStr);

                //open the connection
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            conn?.Close();
        }
    }
}

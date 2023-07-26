using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_performance_assessment
{
    public partial class UserControlDays : UserControl
    {

        public static string staticDay;

        public UserControlDays()
        {
            InitializeComponent();
        }

        public void Days(int numDay)
        {   
            dayLabel.Text = numDay + "";

            if (numDay  == DateTime.Now.Day && MainPageForm.staticMonth == DateTime.Now.Month) 
            {
                BackColor = Color.Lavender;
            }
        }

        private void UserControlDays_DoubleClick(object sender, EventArgs e)
        {
            staticDay = dayLabel.Text;

            CalenderClickForm calenderClickForm = new CalenderClickForm(staticDay);
            calenderClickForm.ShowDialog();
        }

        public void DisplayAppointment(int month, int day)
        {
            string monthString = Convert.ToString(month);
            string dayString = Convert.ToString(day);

            if (month > 0 && month < 10)
            {
                monthString = "0" + monthString;
            }
            if (day > 0 && day < 10)
            {
                dayString = "0" + dayString;
            }


            DBConnection.OpenConnection();

            string query = 
                $"SELECT COUNT(start) FROM client_schedule.appointment WHERE (start > '2023-{Convert.ToInt32(monthString)}-{Convert.ToInt32(dayString)} 00:00:00' " +
                $"&& start < '2023-{Convert.ToInt32(monthString)}-{Convert.ToInt32(dayString)} 20:00:00' );";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            object reader = cmd.ExecuteScalar();

            DBConnection.CloseConnection();

            if (reader != null)
            {
                try
                {
                    int total = Convert.ToInt32(reader);

                    if (total == 0)
                    {
                        appointmentLabel.Text = "";
                    }
                    else if (total == 1) 
                    {
                        appointmentLabel.Text = $"{total} appointment";
                    }
                    else
                    {
                        appointmentLabel.Text = $"{total} appointments";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UserControlDays_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Lavender;
        }

        private void UserControlDays_MouseLeave(object sender, EventArgs e)
        {
            if (dayLabel.Text != DateTime.Now.Day.ToString() || MainPageForm.staticMonth != DateTime.Now.Month)
            {
                BackColor = Color.White;
            }
        }
    }
}

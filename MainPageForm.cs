using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace C969_performance_assessment
{
    public partial class MainPageForm : Form
    {
        int month, year;

        public static int staticMonth, staticYear;

        public MainPageForm()
        {
            InitializeComponent();

            dayContainer.Controls.Clear();

            DisplayDays();

            //
            // Report for one additional report of choice
            AppointmentsThisMonth();

            //
            // Report for number of appointment types by month
            AppointmentTypes();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            //get month string and add the year
            monthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;

            //assign current month and year to static variables
            staticMonth = month;
            staticYear = year;

            //get first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            //get number of days in the month
            int days = DateTime.DaysInMonth(year, month);

            //convert startOfMonth to int
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //blank user control
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControl1 userControl = new UserControl1();
                dayContainer.Controls.Add(userControl);
            }

            //user control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                userControlDays.DisplayAppointment(month, i);
                dayContainer.Controls.Add(userControlDays);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //clear container
            dayContainer.Controls.Clear();

            //increment month
            month++;

            //assign current month and year to static variables
            staticMonth = month;
            staticYear = year;

            //get month string and add the year
            monthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;

            //get first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            //get number of days in the month
            int days = DateTime.DaysInMonth(year, month);

            //convert startOfMonth to int
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControl1 userControl = new UserControl1();
                dayContainer.Controls.Add(userControl);
            }

            //user control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                userControlDays.DisplayAppointment(month, i);
                dayContainer.Controls.Add(userControlDays);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            //clear container
            dayContainer.Controls.Clear();

            //decrement month
            month--;

            //assign current month and year to static variables
            staticMonth = month;
            staticYear = year;

            //get month string and add the year
            monthLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;


            //get first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            //get number of days in the month
            int days = DateTime.DaysInMonth(year, month);

            //convert startOfMonth to int
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            //blank usercontrol
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControl1 userControl = new UserControl1();
                dayContainer.Controls.Add(userControl);
            }

            //user control for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.Days(i);
                userControlDays.DisplayAppointment(month, i);
                dayContainer.Controls.Add(userControlDays);
            }
        }

        private void AppointmentsThisMonth()
        {
            DBConnection.OpenConnection();

            string month = "";

            if (staticMonth > 0 && staticMonth < 10)
            {
                month = $"0{staticMonth}";
            }

            string query = $"SELECT COUNT(start) FROM client_schedule.appointment WHERE (start > '{staticYear}-{month}-01 00:00:00' && start < '{staticYear}-{month}-{DateTime.DaysInMonth(staticYear, staticMonth)} 20:00:00');";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            object num = cmd.ExecuteScalar();

            label8.Text = $"{num} Appointments this month";
        }

        //
        // Report for the schedule for each consultant by week
        private void ViewAppointmentsButton_Click(object sender, EventArgs e)
        {
            WeekView weekView = new WeekView();
            weekView.ShowDialog();

            this.Close();

            MainPageForm mainPageForm = new MainPageForm();
            mainPageForm.ShowDialog();
        }

        private void CustomerRecordsButton_Click(object sender, EventArgs e)
        {
            CustomerRecordsForm customerRecordsForm = new CustomerRecordsForm();
            customerRecordsForm.ShowDialog();

            this.Close();

            MainPageForm mainPageForm = new MainPageForm(); 
            mainPageForm.ShowDialog();
        }

		private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppointmentTypes()
        {
            BindingList<string> list = new BindingList<string>();

            DBConnection.OpenConnection();

            string query = $"SELECT type FROM client_schedule.appointment WHERE ( start > '{DateTime.Now.Year}-{DateTime.Now.Month}-01 00:00:00' && start < '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)} 20:00:00');";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }
             
            DBConnection.CloseConnection();

            if (list.Count > 0)
            {
                DBConnection.OpenConnection();

				string query1 = $"SELECT COUNT(type) FROM client_schedule.appointment WHERE ( type = '{list[0]}');";

                MySqlCommand cmd1 = new MySqlCommand(query1, DBConnection.conn);

                object num1 = cmd1.ExecuteScalar();

				label11.Text = $"- {list[0]}: {Convert.ToInt32(num1)}";
            }
            if (list.Count > 1)
            {
				string query2 = $"SELECT COUNT(type) FROM client_schedule.appointment WHERE ( type = '{list[1]}');";

				MySqlCommand cmd2 = new MySqlCommand(query2, DBConnection.conn);

				object num2 = cmd2.ExecuteScalar();

				label12.Text = $"- {list[1]}: {Convert.ToInt32(num2)}";
			}
            if (list.Count > 2)
            {
				string query3 = $"SELECT COUNT(type) FROM client_schedule.appointment WHERE ( type = '{list[2]}');";

				MySqlCommand cmd3 = new MySqlCommand(query3, DBConnection.conn);

				object num3 = cmd3.ExecuteScalar();

				label13.Text = $"- {list[2]}: {Convert.ToInt32(num3)}";
			}
            if (list.Count > 3)
            {
				string query4 = $"SELECT COUNT(type) FROM client_schedule.appointment WHERE ( type = '{list[3]}');";

				MySqlCommand cmd4 = new MySqlCommand(query4, DBConnection.conn);

				object num4 = cmd4.ExecuteScalar();

				label14.Text = $"- {list[3]}: {Convert.ToInt32(num4)}";
			}
			if (list.Count > 4)
			{
				string query5 = $"SELECT COUNT(type) FROM client_schedule.appointment WHERE ( type = '{list[4]}');";

				MySqlCommand cmd5 = new MySqlCommand(query5, DBConnection.conn);

				object num5 = cmd5.ExecuteScalar();

				label15.Text = $"- {list[3]}: {Convert.ToInt32(num5)}";
			}

			DBConnection.CloseConnection();
        }

		private void MainPageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
            Application.Exit();
		}
	}
}

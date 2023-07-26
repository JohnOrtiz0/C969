using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace C969_performance_assessment
{
    public partial class WeekView : Form
    {
        private static readonly DateTime now = DateTime.Now;

        public string sunday = $"{now.AddDays(-(double)now.DayOfWeek):yyyy-MM-dd}";
        public string monday = $"{now.AddDays(-(double)now.DayOfWeek + 1):yyyy-MM-dd}";
        public string tuesday = $"{now.AddDays(-(double)now.DayOfWeek + 2):yyyy-MM-dd}";
        public string wednesday = $"{now.AddDays(-(double)now.DayOfWeek + 3):yyyy-MM-dd}";
        public string thursday = $"{now.AddDays(-(double)now.DayOfWeek + 4):yyyy-MM-dd}";
        public string friday = $"{now.AddDays(-(double)now.DayOfWeek + 5):yyyy-MM-dd}";
        public string saturday = $"{now.AddDays(-(double)now.DayOfWeek + 6):yyyy-MM-dd}";

        public WeekView()
        {
            InitializeComponent();

            DisplayToday();

            DisplayAppointments();
        }

        private void DisplayToday()
        {
            DateTime now = DateTime.Now;

            //get todays integer day of the week
            int today = Convert.ToInt32(now.DayOfWeek);

            //populate correct day in week label with todays date
            if (today == 0)
            {
                label0.Text = now.ToString("MM-dd-yyyy");
                label1.Text = now.AddDays(1).ToString("MM-dd-yyyy");
                label2.Text = now.AddDays(2).ToString("MM-dd-yyyy");
                label3.Text = now.AddDays(3).ToString("MM-dd-yyyy");
                label4.Text = now.AddDays(4).ToString("MM-dd-yyyy");
                label5.Text = now.AddDays(5).ToString("MM-dd-yyyy");
                label6.Text = now.AddDays(6).ToString("MM-dd-yyyy");
            }
            else if (today == 1)
            {
                label0.Text = now.AddDays(-1).ToString("MM-dd-yyyy");
                label1.Text = now.ToString("MM-dd-yyyy");
                label2.Text = now.AddDays(1).ToString("MM-dd-yyyy");
                label3.Text = now.AddDays(2).ToString("MM-dd-yyyy");
                label4.Text = now.AddDays(3).ToString("MM-dd-yyyy");
                label5.Text = now.AddDays(4).ToString("MM-dd-yyyy");
                label6.Text = now.AddDays(5).ToString("MM-dd-yyyy");
            }
            else if (today == 2)
            {
                label0.Text = now.AddDays(-2).ToString("MM-dd-yyyy");
                label1.Text = now.AddDays(-1).ToString("MM-dd-yyyy");
                label2.Text = now.ToString("MM-dd-yyyy");
                label3.Text = now.AddDays(1).ToString("MM-dd-yyyy");
                label4.Text = now.AddDays(2).ToString("MM-dd-yyyy");
                label5.Text = now.AddDays(3).ToString("MM-dd-yyyy");
                label6.Text = now.AddDays(4).ToString("MM-dd-yyyy");
            }
            else if (today == 3)
            {
                label0.Text = now.AddDays(-3).ToString("MM-dd-yyyy");
                label1.Text = now.AddDays(-2).ToString("MM-dd-yyyy");
                label2.Text = now.AddDays(-1).ToString("MM-dd-yyyy");
                label3.Text = now.ToString("MM-dd-yyyy");
                label4.Text = now.AddDays(1).ToString("MM-dd-yyyy");
                label5.Text = now.AddDays(2).ToString("MM-dd-yyyy");
                label6.Text = now.AddDays(3).ToString("MM-dd-yyyy");
            }
            else if (today == 4)
            {
                label0.Text = now.AddDays(-4).ToString("MM-dd-yyyy");
                label1.Text = now.AddDays(-3).ToString("MM-dd-yyyy");
                label2.Text = now.AddDays(-2).ToString("MM-dd-yyyy");
                label3.Text = now.AddDays(-1).ToString("MM-dd-yyyy");
                label4.Text = now.ToString("MM-dd-yyyy");
                label5.Text = now.AddDays(1).ToString("MM-dd-yyyy");
                label6.Text = now.AddDays(2).ToString("MM-dd-yyyy");
            }
            else if (today == 5)
            {
                label0.Text = now.AddDays(-5).ToString("MM-dd-yyyy");
                label1.Text = now.AddDays(-4).ToString("MM-dd-yyyy");
                label2.Text = now.AddDays(-3).ToString("MM-dd-yyyy");
                label3.Text = now.AddDays(-2).ToString("MM-dd-yyyy");
                label4.Text = now.AddDays(-1).ToString("MM-dd-yyyy");
                label5.Text = now.ToString("MM-dd-yyyy");
                label6.Text = now.AddDays(1).ToString("MM-dd-yyyy");
            }
            else if (today == 6)
            {
                label0.Text = now.AddDays(-6).ToString("MM-dd-yyyy");
                label1.Text = now.AddDays(-5).ToString("MM-dd-yyyy");
                label2.Text = now.AddDays(-4).ToString("MM-dd-yyyy");
                label3.Text = now.AddDays(-3).ToString("MM-dd-yyyy");
                label4.Text = now.AddDays(-2).ToString("MM-dd-yyyy");
                label5.Text = now.AddDays(-1).ToString("MM-dd-yyyy");
                label6.Text = now.ToString("MM-dd-yyyy");
            }
        }

        private void DisplayAppointments()
        {
            DisplaySunday();
            DisplayMonday();
            DisplayTuesday();
            DisplayWednesday();
            DisplayThursday();
            DisplayFriday();
            DisplaySaturday();
        }

        private void DisplaySunday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{sunday} 00:00:00' && start < '{sunday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader(); ;

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void DisplayMonday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{monday} 00:00:00' && start < '{monday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void DisplayTuesday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{tuesday} 00:00:00' && start < '{tuesday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void DisplayWednesday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{wednesday} 00:00:00' && start < '{wednesday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void DisplayThursday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{thursday} 00:00:00' && start < '{thursday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void DisplayFriday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{friday} 00:00:00' && start < '{friday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void DisplaySaturday()
        {
            DBConnection.OpenConnection();

            string query = $"SELECT TIME(start) FROM client_schedule.appointment WHERE (start > '{saturday} 00:00:00' && start < '{saturday} 20:00:00') ORDER BY start;";

            MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            WeekViewPopulator(reader);

            DBConnection.CloseConnection();
        }

        private void WeekViewPopulator(MySqlDataReader reader)
        {
            BindingList<string> list = new BindingList<string>();

            while (reader.Read())
            {
                list.Add(reader[0].ToString());
            }

            if (list.Count == 0)
            {
                Blank(16);
            }
            else if (list.Count == 1)
            {
                string reader0 = list[0].ToString();

                if (reader0 == "09:00:00")
                {
                    App();
                    Blank(14);
                }
                else if (reader0 == "09:30:00")
                {
                    Blank(1);
                    App();
                    Blank(13);
                }
                else if (reader0 == "10:00:00")
                {
                    Blank(2);
                    App();
                    Blank(12);
                }
                else if (reader0 == "10:30:00")
                {
                    Blank(3);
                    App();
                    Blank(11);
                }
                else if (reader0 == "11:00:00")
                {
                    Blank(4);
                    App();
                    Blank(10);
                }
                else if (reader0 == "11:30:00")
                {
                    Blank(5);
                    App();
                    Blank(9);
                }
                else if (reader0 == "12:00:00")
                {
                    Blank(6);
                    App();
                    Blank(8);
                }
                else if (reader0 == "12:30:00")
                {
                    Blank(7);
                    App();
                    Blank(7);
                }
                else if (reader0 == "13:00:00")
                {
                    Blank(8);
                    App();
                    Blank(6);
                }
                else if (reader0 == "13:30:00")
                {
                    Blank(9);
                    App();
                    Blank(5);
                }
                else if (reader0 == "14:00:00")
                {
                    Blank(10);
                    App();
                    Blank(4);
                }
                else if (reader0 == "14:30:00")
                {
                    Blank(11);
                    App();
                    Blank(3);
                }
                else if (reader0 == "15:00:00")
                {
                    Blank(12);
                    App();
                    Blank(2);
                }
                else if (reader0 == "15:30:00")
                {
                    Blank(13);
                    App();
                    Blank(1);
                }
                else if (reader0 == "16:00:00")
                {
                    Blank(14);
                    App();
                }
            }
            else if (list.Count == 2)
            {
                string reader0 = list[0].ToString();
                string reader1 = list[1].ToString();

                if (reader0 == "09:00:00")
                {
                    App();

                    if (reader1 == "10:00:00")
                    {
                        App();
                        Blank(12);
                    }
                    else if (reader1 == "10:30:00")
                    {
                        Blank(1);
                        App();
                        Blank(11);
                    }
                    else if (reader1 == "11:00:00")
                    {
                        Blank(1);
                        App();
                        Blank(11);
                    }
                    else if (reader1 == "11:30:00")
                    {
                        Blank(2);
                        App();
                        Blank(10);
                    }
                    else if (reader1 == "12:00:00")
                    {
                        Blank(3);
                        App();
                        Blank(9);
                    }
                    else if (reader1 == "12:30:00")
                    {
                        Blank(4);
                        App();
                        Blank(8);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(5);
                        App();
                        Blank(7);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(6);
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(7);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(8);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(9);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(10);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(11);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(12);
                        App();
                    }




                }
                else if (reader0 == "09:30:00")
                {
                    Blank(1);
                    App();

                    if (reader1 == "10:30:00")
                    {
                        App();
                        Blank(11);
                    }
                    else if (reader1 == "11:00:00")
                    {
                        Blank(1);
                        App();
                        Blank(10);
                    }
                    else if (reader1 == "11:30:00")
                    {
                        Blank(2);
                        App();
                        Blank(9);
                    }
                    else if (reader1 == "12:00:00")
                    {
                        Blank(3);
                        App();
                        Blank(8);
                    }
                    else if (reader1 == "12:30:00")
                    {
                        Blank(4);
                        App();
                        Blank(7);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(5);
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(6);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(7);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(8);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(9);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(10);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(11);
                        App();
                    }
                }
                else if (reader0 == "10:00:00")
                {
                    Blank(2);
                    App();

                    if (reader1 == "11:00:00")
                    {
                        App();
                        Blank(10);
                    }
                    else if (reader1 == "11:30:00")
                    {
                        Blank(1);
                        App();
                        Blank(9);
                    }
                    else if (reader1 == "12:00:00")
                    {
                        Blank(2);
                        App();
                        Blank(8);
                    }
                    else if (reader1 == "12:30:00")
                    {
                        Blank(3);
                        App();
                        Blank(7);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(4);
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(5);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(6);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(7);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(8);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(9);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(10);
                        App();
                    }
                }
                else if (reader0 == "10:30:00")
                {
                    Blank(3);
                    App();

                    if (reader1 == "11:30:00")
                    {
                        App();
                        Blank(9);
                    }
                    else if (reader1 == "12:00:00")
                    {
                        Blank(1);
                        App();
                        Blank(8);
                    }
                    else if (reader1 == "12:30:00")
                    {
                        Blank(2);
                        App();
                        Blank(7);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(3);
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(4);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(5);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(6);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(7);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(8);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(9);
                        App();
                    }
                }
                else if (reader0 == "11:00:00")
                {
                    Blank(4);
                    App();

                    if (reader1 == "12:00:00")
                    {
                        App();
                        Blank(8);
                    }
                    else if (reader1 == "12:30:00")
                    {
                        Blank(1);
                        App();
                        Blank(7);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(2);
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(3);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(4);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(5);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(6);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(7);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(8);
                        App();
                    }
                }
                else if (reader0 == "11:30:00")
                {
                    Blank(5);
                    App();

                    if (reader1 == "12:30:00")
                    {
                        App();
                        Blank(7);
                    }
                    else if (reader1 == "13:00:00")
                    {
                        Blank(1);
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(2);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(3);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(4);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(5);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(6);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(7);
                        App();
                    }
                }
                else if (reader0 == "12:00:00")
                {
                    Blank(6);
                    App();

                    if (reader1 == "13:00:00")
                    {
                        App();
                        Blank(6);
                    }
                    else if (reader1 == "13:30:00")
                    {
                        Blank(1);
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(2);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(3);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(4);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(5);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(6);
                        App();
                    }
                }
                else if (reader0 == "12:30:00")
                {
                    Blank(7);
                    App();

                    if (reader1 == "13:30:00")
                    {
                        App();
                        Blank(5);
                    }
                    else if (reader1 == "14:00:00")
                    {
                        Blank(1);
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(2);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(3);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(4);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(5);
                        App();
                    }
                }
                else if (reader0 == "13:00:00")
                {
                    Blank(8);
                    App();

                    if (reader1 == "14:00:00")
                    {
                        App();
                        Blank(4);
                    }
                    else if (reader1 == "14:30:00")
                    {
                        Blank(1);
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(2);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(3);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(4);
                        App();
                    }
                }
                else if (reader0 == "13:30:00")
                {
                    Blank(9);
                    App();

                    if (reader1 == "14:30:00")
                    {
                        App();
                        Blank(3);
                    }
                    else if (reader1 == "15:00:00")
                    {
                        Blank(1);
                        App();
                        Blank(2);
                    }
                    else if (reader1 == "15:30:00")
                    {
                        Blank(2);
                        App();
                        Blank(1);
                    }
                    else if (reader1 == "16:00:00")
                    {
                        Blank(3);
                        App();
                    }
                }
                else if (reader0 == "14:00:00")
                {
                    Blank(10);
                    App();

                    if (reader1 == "15:00:00")
                    {
                        App();
                        Blank(2);
                    }
                    if (reader1 == "15:30:00")
                    {
                        Blank(1);
                        App();
                        Blank(1);
                    }
                    if (reader1 == "16:00:00")
                    {
                        Blank(2);
                        App();
                    }
                }
                else if (reader0 == "14:30:00")
                {
                    Blank(11);
                    App();

                    if (reader1 == "15:30:00")
                    {
                        App();
                        Blank(1);
                    }
                    if (reader1 == "16:00:00")
                    {
                        Blank(1);
                        App();
                    }
                }
                else if (reader0 == "15:00:00")
                {
                    Blank(12);
                    App();

                    if (reader1 == "16:00:00")
                    {
                        App();
                    }
                }
            }
        }

        //adds and hour long appointment to the week view
        private void App()
        {
            //user control for appointments
            for (int i = 1; i < 3; i++)
            {
                UserControlAppointments UCAppointments = new UserControlAppointments();
                weekContainer.Controls.Add(UCAppointments);
            }
        }

        //adds blank user control to the week view
        private void Blank(int num)
        {
            //blank usercontrol
            for (int i = 1; i <= num; i++)
            {
                UserControl2 userControl = new UserControl2();
                weekContainer.Controls.Add(userControl);
            }
        }

		private void ExitButton_Click(object sender, EventArgs e)
		{
            this.Close();

            MainPageForm mainPageForm = new MainPageForm();
            mainPageForm.ShowDialog();
		}

        private void WeekViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPageForm mainPageForm = new MainPageForm();
            mainPageForm.ShowDialog();
        }
	}
}
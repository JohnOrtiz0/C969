using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace C969_performance_assessment
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm(int month, int year, string day)
        {
            InitializeComponent();

            int dayInt = Convert.ToInt32(day);

            if (month < 10 && dayInt < 10)
            {
                dateLabel.Text = $"{year}-0{month}-0{day}";
            }
            else if (month >= 10 && dayInt >= 10)
            {
                dateLabel.Text = $"{year}-{month}-{dayInt}";
            }
            else if (month >= 10 && dayInt < 10)
            {
                dateLabel.Text = $"{year}-{month}-0{dayInt}";
            }
            else if (month < 10 && dayInt >= 10)
            {
                dateLabel.Text = $"{year}-0{month}-{dayInt}";
            }
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            if (titleInput.Text != "")
            {
                if (typeInput.Text != "")
                {
                    if (locationInput.Text != "")
                    {
                        if (startBox.Text != "")
                        {
                            if (contactInput.Text != "")
                            {
                                if (urlInput.Text != "")
                                {
                                    if (descriptionInput.Text != "")
                                    {
                                        DBConnection.OpenConnection();

                                        //get customer ID
                                        string customerIdQuery = $"SELECT customerId FROM client_schedule.customer WHERE (customerName = '{nameInput.Text}');";

                                        MySqlCommand customerIdCmd = new MySqlCommand(customerIdQuery, DBConnection.conn);
                                        object customerId = customerIdCmd.ExecuteScalar();

                                        //check if customer exists in the database
                                        if (customerId != null)
                                        {
                                            DBConnection.OpenConnection();

                                            //get appointments and hour before and hour after requested time to check if the times overlap
                                            string appQuery = $"SELECT COUNT(start) FROM client_schedule.appointment WHERE (start >= '{dateLabel.Text} {GetTime(startBox.Text)}' && start <= '{dateLabel.Text} {GetEndTime(startBox.Text)}');";

                                            MySqlCommand appCmd = new MySqlCommand(appQuery, DBConnection.conn);
                                            int app = Convert.ToInt32(appCmd.ExecuteScalar());

                                            //check if the appointment overlaps with another
                                            if (app == 0)
                                            {
                                                //add appointment query
                                                string query =
                                                    $"INSERT INTO client_schedule.appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)\r\n" +
                                                    $"VALUES ('{customerId}', '1', '{titleInput.Text}', '{descriptionInput.Text}', '{locationInput.Text}', '{contactInput.Text}', '{typeInput.Text}', '{urlInput.Text}',\r\n" +
                                                    $"'{dateLabel.Text + " " + Convert.ToDateTime(startBox.Text).ToString("HH:mm:ss")}', '{dateLabel.Text + " " + Convert.ToDateTime(GetEndTime(startBox.Text)).ToString("HH:mm:ss")}', now(), 'test', now(), 'test');";

                                                MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

                                                cmd.ExecuteNonQuery();

                                                DBConnection.CloseConnection();
                                            }
                                            else
                                            {
                                                MessageBox.Show("There is already another appointment during this time.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Customer Does not exist. Please add customer to the database before adding an appointment.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("All fields must be filled out.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("All fields must be filled out.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("All fields must be filled out.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("All fields must be filled out.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("All fields must be filled out.");
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled out.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out.");
            }
            this.Close();

            CalenderClickForm calenderClickForm = new CalenderClickForm(UserControlDays.staticDay);
            calenderClickForm.ShowDialog();
        }

        private string GetTime(string time)
        {
            DateTime t = Convert.ToDateTime(time);

            return t.AddHours(-1).ToString("HH:mm:ss");
        }

        public static string GetEndTime(string startTime)
        {
			DateTime t = Convert.ToDateTime(startTime);

			return t.AddHours(1).ToString("HH:mm:ss");
		}
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace C969_performance_assessment
{
	public partial class UpdateAppointmentForm : Form
	{
		public UpdateAppointmentForm()
		{
			InitializeComponent();
		}

		private void UpdateAppointmentButton_Click(object sender, EventArgs e)
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
										string customerIdQuery = $"SELECT customerId FROM client_schedule.customer WHERE (customerName = '{label3.Text}');";

										MySqlCommand customerIdCmd = new MySqlCommand(customerIdQuery, DBConnection.conn);
										object customerId = customerIdCmd.ExecuteScalar();

										if (customerId != null)
										{
											DBConnection.OpenConnection();

											//update appointment query
											string query =
												$"UPDATE client_schedule.appointment SET title = '{titleInput.Text}', description = '{descriptionInput.Text}', " +
												$"location = '{locationInput.Text}', contact = '{contactInput.Text}', type = '{typeInput.Text}',  url = '{urlInput.Text}', " +
												$"start = '{dateLabel.Text + " " + startBox.Text}', end = '{dateLabel.Text + " " + AddAppointmentForm.GetEndTime(startBox.Text)}', lastUpdate = now(), lastUpdateBy = 'test'\r\n" +
												$"WHERE (appointmentId = {label2.Text});";

											MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

											cmd.ExecuteNonQuery();

											DBConnection.CloseConnection();
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
	}
}

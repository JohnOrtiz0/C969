using MySql.Data.MySqlClient;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_performance_assessment
{
	public partial class CalenderClickForm : Form
	{
		public static string calenderDay;
		public static string calenderMonth;

		public CalenderClickForm(string day)
		{
			InitializeComponent();

			calenderDay = day;

			if (MainPageForm.staticMonth > 0 && MainPageForm.staticMonth < 10)
			{
				calenderMonth = "0" + MainPageForm.staticMonth;
			}

			label2.Text = $"{calenderMonth}-{calenderDay}-{MainPageForm.staticYear}";

			DBConnection.OpenConnection();

			string query =
				$"SELECT appointment.appointmentId AS 'Appointment ID', customer.customerName AS 'Customer Name', appointment.title AS 'Title', appointment.description AS 'Description', " +
				$"appointment.location AS 'Location', appointment.contact AS 'Contact', appointment.type AS 'Type', appointment.url AS 'URL', appointment.start AS 'Date Time', " +
				$"DATE(appointment.createDate) AS 'Date Created', appointment.createdBy AS 'Created By'\r\n" +
				$"FROM client_schedule.appointment\r\n" +
				$"INNER JOIN customer\r\n" +
				$"ON customer.customerId = appointment.customerId\r\n" +
				$"WHERE(start > '{MainPageForm.staticYear}-{calenderMonth}-{calenderDay} 00:00:00' && start < '{MainPageForm.staticYear}-{calenderMonth}-{calenderDay} 20:00:00');";

			MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

			MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

			DataTable table = new DataTable();
			adapter.Fill(table);

			appointmentView.DataSource = table;

			for (int i = 0; i < table.Rows.Count; i++)
			{
				table.Rows[i]["Date Time"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["Date Time"], TimeZoneInfo.Local).ToString("HH:mm:ss");
			}

			DBConnection.CloseConnection();
		}

		private void AddAppointmentButton_Click(object sender, EventArgs e)
		{
			AddAppointmentForm addAppointmentForm = new AddAppointmentForm(MainPageForm.staticMonth, MainPageForm.staticYear, calenderDay);
			addAppointmentForm.ShowDialog();

			this.Close();
		}

		private void UpdateAppointmentButton_Click(object sender, EventArgs e)
		{
			UpdateAppointmentForm updateAppointmentForm = new UpdateAppointmentForm();
			try
			{
				DBConnection.OpenConnection();

				string query =
					$"SELECT COUNT(start) FROM client_schedule.appointment WHERE (start > '{MainPageForm.staticYear}-{MainPageForm.staticMonth}-{UserControlDays.staticDay} 00:00:00' && start < '{MainPageForm.staticYear}-{MainPageForm.staticMonth}-{UserControlDays.staticDay} 20:00:00');";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

				int reader = Convert.ToInt32(cmd.ExecuteScalar());

				DBConnection.CloseConnection();

				if (reader > 0)
				{
					int row = appointmentView.CurrentRow.Index;

					//
					// This is a LAMBDA expression used to populate the update appointment form with the data from the data grid view
					//
					updateAppointmentForm.Shown += (senderupdateAppointmentForm, eupdateAppointmentForm) =>
					{
						var ownerForm = (CalenderClickForm)updateAppointmentForm.Owner;
						updateAppointmentForm.label2.Text = ownerForm.appointmentView[0, row].Value.ToString();
						updateAppointmentForm.label3.Text = ownerForm.appointmentView[1, row].Value.ToString();
						updateAppointmentForm.titleInput.Text = ownerForm.appointmentView[2, row].Value.ToString();
						updateAppointmentForm.descriptionInput.Text = ownerForm.appointmentView[3, row].Value.ToString();
						updateAppointmentForm.locationInput.Text = ownerForm.appointmentView[4, row].Value.ToString();
						updateAppointmentForm.contactInput.Text = ownerForm.appointmentView[5, row].Value.ToString();
						updateAppointmentForm.typeInput.Text = ownerForm.appointmentView[6, row].Value.ToString();
						updateAppointmentForm.urlInput.Text = ownerForm.appointmentView[7, row].Value.ToString();
						updateAppointmentForm.startBox.Text = GetTime(ownerForm.appointmentView[8, row].Value.ToString());
						updateAppointmentForm.dateLabel.Text = $"{MainPageForm.staticYear}-{calenderMonth}-{calenderDay}";
					};
					updateAppointmentForm.ShowDialog(this);
				}
				else
				{
					MessageBox.Show("There are no appointments for this day");
				}
			}
			catch
			{
				MessageBox.Show("There are no appointments for this day");
			}
			this.Close();
		}

		private void DeleteAppoinmentButton_Click(object sender, EventArgs e)
		{
			string message = "Are you sure you want to delete this appointment?";
			string title = "Delete appointment";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(message, title, buttons);
			if (result == DialogResult.Yes)
			{
				DBConnection.OpenConnection();

				string query =
					$"SELECT COUNT(start) FROM client_schedule.appointment WHERE (start > '{MainPageForm.staticYear}-{MainPageForm.staticMonth}-{UserControlDays.staticDay} 00:00:00' && start < '{MainPageForm.staticYear}-{MainPageForm.staticMonth}-{UserControlDays.staticDay} 20:00:00');";

				MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

				int reader = Convert.ToInt32(cmd.ExecuteScalar());

				if (reader > 0)
				{
					int row = appointmentView.CurrentRow.Index;
					var appointmentId = appointmentView[0, row].Value;

					//customer query
					string deleteQuery =
						$"DELETE FROM client_schedule.appointment WHERE (appointmentId = {appointmentId});";

					MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, DBConnection.conn);

					deleteCmd.ExecuteNonQuery();

					DBConnection.CloseConnection();
				}
				else
				{
					MessageBox.Show("There are no appointments for this day");
				}
			}
			this.Close();

			CalenderClickForm calenderClickForm = new CalenderClickForm(calenderDay);
			calenderClickForm.ShowDialog();
		}

		private void CustomerRecordButton_Click(object sender, EventArgs e)
		{
			CustomerRecordsForm form = new CustomerRecordsForm();
			form.ShowDialog();

			this.Close();
		}

		private string GetTime(string time)
		{
			time = TimeZoneInfo.ConvertTimeFromUtc(Convert.ToDateTime(time), TimeZoneInfo.Local).ToString("HH:mm:ss");
			return time;
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();

			MainPageForm form = new MainPageForm();
			form.ShowDialog();
		}

		private void CalenderClickForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			MainPageForm mainPageForm = new MainPageForm();
			mainPageForm.ShowDialog();
		}
	}
}

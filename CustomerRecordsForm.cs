using MySql.Data.MySqlClient;
using ServiceStack;
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
	public partial class CustomerRecordsForm : Form
	{
		public CustomerRecordsForm()
		{
			InitializeComponent();

			DBConnection.OpenConnection();

			//customer query
			string query =
				"SELECT customer.customerId, customer.customerName, address.address, address.address2, city.city, address.postalCode, country.country, address.phone\r\n" +
				"FROM customer\r\n" +
				"INNER JOIN address\r\n" +
				"ON customer.addressId = address.addressId\r\n" +
				"INNER JOIN city\r\n" +
				"ON address.cityId = city.cityId\r\n" +
				"INNER JOIN country\r\n" +
				"ON city.countryId = country.countryId;";

			MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

			MySqlDataReader reader = cmd.ExecuteReader();

			DataTable table = new DataTable();
			table.Load(reader);

			//populate data grid
			CustomerRecordView.DataSource = table;

			DBConnection.CloseConnection();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			AddCustomerForm addCustomerForm = new AddCustomerForm();
			addCustomerForm.ShowDialog();

			this.Close();
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm();
			int row = CustomerRecordView.CurrentRow.Index;

			//
			// This is a LAMBDA expression used to populate the update customer form with the data from the data grid view
			//
			updateCustomerForm.Shown += (senderupdateCustomerForm, eupdateCustomerForm) =>
			{
				var ownerForm = (CustomerRecordsForm)updateCustomerForm.Owner;
				updateCustomerForm.customerId.Text = ownerForm.CustomerRecordView[0, row].Value.ToString();
				updateCustomerForm.customerNameInput.Text = ownerForm.CustomerRecordView[1, row].Value.ToString();
				updateCustomerForm.addressInput.Text = ownerForm.CustomerRecordView[2, row].Value.ToString();
				updateCustomerForm.address2Input.Text = ownerForm.CustomerRecordView[3, row].Value.ToString();
				updateCustomerForm.cityInput.Text = ownerForm.CustomerRecordView[4, row].Value.ToString();
				updateCustomerForm.postalCodeInput.Text = ownerForm.CustomerRecordView[5, row].Value.ToString();
				updateCustomerForm.countryInput.Text = ownerForm.CustomerRecordView[6, row].Value.ToString();
				updateCustomerForm.phoneInput.Text = ownerForm.CustomerRecordView[7, row].Value.ToString();
			};
			updateCustomerForm.ShowDialog(this);

			this.Close();

			CustomerRecordsForm form = new CustomerRecordsForm();
			form.ShowDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			string message = "Are you sure you want to delete this customer?";
			string title = "Delete Customer";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result = MessageBox.Show(message, title, buttons);
			if (result == DialogResult.Yes)
			{
				try
				{
					DBConnection.OpenConnection();

					int row = CustomerRecordView.CurrentRow.Index;
					var customerId = CustomerRecordView[0, row].Value;

					if (customerId != null)
					{
						//customer query
						string query =
							$"DELETE FROM client_schedule.customer WHERE (customerId ='{customerId}');\r\n" +
							$"DELETE FROM client_schedule.address WHERE (addressId ='{customerId}');\r\n" +
							$"DELETE FROM client_schedule.city WHERE (cityId = '{customerId}');\r\n" +
							$"DELETE FROM client_schedule.country WHERE (countryId = '{customerId}');";

						MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

						cmd.ExecuteNonQuery();

						DBConnection.CloseConnection();
					}
					else
					{
						MessageBox.Show("No customers exist in the database.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			this.Close();

			CustomerRecordsForm customerRecordsForm = new CustomerRecordsForm();
			customerRecordsForm.ShowDialog();
		}
	}
}
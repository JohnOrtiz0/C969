using MySql.Data.MySqlClient;
using ServiceStack.Script;
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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            if (addressInput.Text != "")
            {
                if (cityInput.Text != "")
                {
                    if (postalCodeInput.Text != "")
                    {
                        if (countryInput.Text != "")
                        {
                            if (phoneInput.Text != "")
                            {
                                if (address2Input.Text != " ")
                                {
                                    DBConnection.OpenConnection();

                                    //customer update query
                                    string query =
                                        $"UPDATE client_schedule.customer SET customerName = '{customerNameInput.Text}', lastUpdate = now() WHERE (customerId = '{customerId.Text}');\r\n" +
                                        $"UPDATE client_schedule.address SET address = '{addressInput.Text}', address2 = '{address2Input.Text}', postalCode = '{postalCodeInput.Text}', phone = '{phoneInput.Text}', lastUpdate = now() WHERE (addressId = '{customerId.Text}');\r\n" +
                                        $"UPDATE client_schedule.city SET city = '{cityInput.Text}', lastUpdate = now() WHERE (cityId = '{customerId.Text}');\r\n" +
                                        $"UPDATE client_schedule.country SET country = '{countryInput.Text}', lastUpdate = now() WHERE (countryId = '{customerId.Text}');";

                                    MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

                                    cmd.ExecuteNonQuery();

                                    DBConnection.CloseConnection();
                                }
                                else if (address2Input.Text == " ")
                                {
									DBConnection.OpenConnection();

									//customer update query
									string query =
										$"UPDATE client_schedule.customer SET customerName = '{customerNameInput.Text}', lastUpdate = now() WHERE (customerId = '{customerId.Text}');\r\n" +
										$"UPDATE client_schedule.address SET address = '{addressInput.Text}', address2 = ' ', postalCode = '{postalCodeInput.Text}', phone = '{phoneInput.Text}', lastUpdate = now() WHERE (addressId = '{customerId.Text}');\r\n" +
										$"UPDATE client_schedule.city SET city = '{cityInput.Text}', lastUpdate = now() WHERE (cityId = '{customerId.Text}');\r\n" +
										$"UPDATE client_schedule.country SET country = '{countryInput.Text}', lastUpdate = now() WHERE (countryId = '{customerId.Text}');";

									MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

									cmd.ExecuteNonQuery();

									DBConnection.CloseConnection();
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

            CustomerRecordsForm customerRecordsForm = new CustomerRecordsForm();
            customerRecordsForm.ShowDialog();
        }
	}
}

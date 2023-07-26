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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (customerNameInput.Text != "")
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

                                        //customer insert query
                                        string query =
                                            $"INSERT INTO country (country, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
                                            $"VALUES ('{countryInput.Text}', 'test', now(), now(), 'test');\r\n" +

                                            $"INSERT INTO city (city, countryId, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
                                            $"VALUES ('{cityInput.Text}', LAST_INSERT_ID(), 'test', now(), now(), 'test');\r\n" +

                                            $"INSERT INTO address (address, address2, cityId, postalCode, phone, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
                                            $"VALUES ('{addressInput.Text}', '{address2Input.Text}', LAST_INSERT_ID(), '{postalCodeInput.Text}', '{phoneInput.Text}', 'test', now(), now(), 'test');\r\n" +

                                            $"INSERT INTO customer (customerName, addressId, active, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
                                            $"VALUES ('{customerNameInput.Text}', LAST_INSERT_ID(), 1,  'test', now(), now(), 'test');";

                                        MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

                                        cmd.ExecuteNonQuery();

                                        DBConnection.CloseConnection();
                                    } 
                                    else if (address2Input.Text == " ")
                                    {
										DBConnection.OpenConnection();

										//customer insert query
										string query =
											$"INSERT INTO country (country, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
											$"VALUES ('{countryInput.Text}', 'test', now(), now(), 'test');\r\n" +

											$"INSERT INTO city (city, countryId, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
											$"VALUES ('{cityInput.Text}', LAST_INSERT_ID(), 'test', now(), now(), 'test');\r\n" +

											$"INSERT INTO address (address, address2, cityId, postalCode, phone, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
											$"VALUES ('{addressInput.Text}', ' ', LAST_INSERT_ID(), '{postalCodeInput.Text}', '{phoneInput.Text}', 'test', now(), now(), 'test');\r\n" +

											$"INSERT INTO customer (customerName, addressId, active, createdBy, createDate, lastUpdate, lastUpdateBy)\r\n" +
											$"VALUES ('{customerNameInput.Text}', LAST_INSERT_ID(), 1,  'test', now(), now(), 'test');";

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
            }
            else
            {
                MessageBox.Show("All fields must be filled out.");
            }
            this.Close();

            CustomerRecordsForm form = new CustomerRecordsForm();
            form.ShowDialog();
        }
	}
}

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using ServiceStack;
using System.CodeDom.Compiler;

namespace C969_performance_assessment
{
	public partial class LoginForm : Form
	{
		public string passwordError, usernameError;

		public LoginForm()
		{
			InitializeComponent();

			UserActivity();

			GetUserLocation();

			AppointmentWarning();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			DBConnection.OpenConnection();

			//username query
			string username =
				$"SELECT username FROM user WHERE username = '{usernameInput.Text}'";

			//password query
			string password =
				$"SELECT password FROM user WHERE password = '{passwordInput.Text}'";

			//get username and password and store in object
			MySqlCommand cmdUser = new MySqlCommand(username, DBConnection.conn);
			MySqlCommand cmdPass = new MySqlCommand(password, DBConnection.conn);
			
			object resultUser = cmdUser.ExecuteScalar();
			object resultPass = cmdPass.ExecuteScalar();

			//check if username exists in database
			if (resultUser != null)
			{

				//check if password exists in database
				if (resultPass != null)
				{
					if ((string)resultUser == usernameInput.Text)
					{
						if ((string)resultPass == passwordInput.Text)
						{
							MainPageForm mainPageForm = new MainPageForm();
							mainPageForm.ShowDialog();

							this.Close();
						}
						else
						{
							MessageBox.Show(passwordError);
						}
					}
					else
					{
						MessageBox.Show(usernameError);
					}
				}
				else
				{
					MessageBox.Show(passwordError);
				}
			}
			else
			{
				MessageBox.Show(usernameError);
			}

			DBConnection.CloseConnection();
		}

		private void GetUserLocation()
		{
			if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
			{
				passwordError = "Password does not match username.";
				usernameError = "Username does not exist";
			}
			if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
			{
				passwordError = "La contraseña no coincide con el nombre de usuario.";
				usernameError = "El usuario no existe.";
			}
		}

		private void UserActivity()
		{
			string fileName = @".\user_activity.txt";

			try
			{
				if (File.Exists(fileName))
				{
					File.AppendAllText(fileName, $"{DateTime.Now.ToLocalTime()}");
				}
				else
				{
					using (StreamWriter sw = File.CreateText(fileName))
					{
						sw.WriteLine($"{DateTime.Now.ToLocalTime()}");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AppointmentWarning()
		{
			DBConnection.OpenConnection();

			string query =
				$"SELECT COUNT(start) FROM client_schedule.appointment WHERE (start >= '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day} {DateTime.Now:HH:mm:ss}' " +
				$"&& start <= '{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day} {DateTime.Now.AddMinutes(20):HH:mm:ss}');";

			MySqlCommand cmd = new MySqlCommand(query, DBConnection.conn);

			int reader = Convert.ToInt32(cmd.ExecuteScalar());

			if (reader > 0)
			{
				MessageBox.Show("You have an appointment in the 15 minutes");
			}

			DBConnection.CloseConnection();
		}
	}
}

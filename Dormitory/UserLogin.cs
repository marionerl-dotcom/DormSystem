using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields", "Validation Error",
                    MessageBoxButtons.OK);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DormitoryDB;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT role FROM users WHERE username = @username AND password = @password", conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue ("password", password);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed",
                        MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    UserSession.CurrentRole = result.ToString();
                    MessageBox.Show("Login Successful!");

                    login loginForm = new login();
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            UserSignUp UserSignUpForm = new UserSignUp();
            UserSignUpForm.ShowDialog();
        }
    }
}

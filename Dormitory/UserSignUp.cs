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
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all feilds!", "Validation Error",
                    MessageBoxButtons.OK);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DormitoryDB;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM users WHERE username = @username", conn);
                checkCmd.Parameters.AddWithValue("@username", username);

                int userCount = (int)checkCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists!", "Error",
                        MessageBoxButtons.OK);
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO users VALUES (@username, @password, @role)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", "user");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully!", "Success",
                    MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

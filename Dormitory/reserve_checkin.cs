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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dormitory
{
    public partial class reserve_checkin : Form
    {
        public string inforoom { get; private set; }
        public string UserRole { get; set; }

        public reserve_checkin()
        {
            InitializeComponent();
        }

        private void reserve_checkin_Load(object sender, EventArgs e)
        {
            if (UserRole == "user")
            {
                btnRCI.Enabled = false;

                btnRCI.Text = "Admin Only";
            }
            else
            {
                btnRCI.Enabled = true;
            }
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string contactNo = txtNo.Text;
            if (!studentID.All(char.IsDigit))
            {
                MessageBox.Show("StudentID must be number only!!");
                return;
            }

            if (!contactNo.All(char.IsDigit))
            {
                MessageBox.Show("Contact Number must be number only!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFN.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtGuardianFN.Text))
            {
                MessageBox.Show("Need to fill", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DormitoryDB;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO tenant VALUES (@fullname, @email, @studentID, @contactNumber, @guardian, @gender)", conn);
                cmd.Parameters.AddWithValue("@fullname", (txtFN.Text));
                cmd.Parameters.AddWithValue("@email", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@studentID", int.Parse(txtStudentID.Text));
                cmd.Parameters.AddWithValue("@contactNumber", (txtNo.Text));
                cmd.Parameters.AddWithValue("@guardian", (txtGuardianFN.Text));
                cmd.Parameters.AddWithValue("@gender", (cmbGender.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved!");

                inforoom = "checked in";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            string contactNo = txtNo.Text;
            if (!studentID.All(char.IsDigit))
            {
                MessageBox.Show("StudentID must be number only!!");
                return;
            }

            if (!contactNo.All(char.IsDigit))
            {
                MessageBox.Show("Contact Number must be number only!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFN.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtGuardianFN.Text))
            {
                MessageBox.Show("Need to fill", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DormitoryDB;Integrated Security=True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO tenant VALUES (@fullname, @email, @studentID, @contactNumber, @guardian, @gender)", conn);
                cmd.Parameters.AddWithValue("@fullname", (txtFN.Text));
                cmd.Parameters.AddWithValue("@email", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@studentID", int.Parse(txtStudentID.Text));
                cmd.Parameters.AddWithValue("@contactNumber", (txtNo.Text));
                cmd.Parameters.AddWithValue("@guardian", (txtGuardianFN.Text));
                cmd.Parameters.AddWithValue("@gender", (cmbGender.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved!");

                inforoom = "reserved";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnRCI_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrWhiteSpace(txtFN.Text))
            {
                MessageBox.Show("Need to fill", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DormitoryDB;Integrated Security=True"))
            {
                conn.Open();

                
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tenant WHERE fullname = @fullname", conn);
                checkCmd.Parameters.AddWithValue("@fullname", txtFN.Text.Trim());

                int tenantCount = (int)checkCmd.ExecuteScalar();

                if (tenantCount == 0)
                {
                    MessageBox.Show("No tenant exist with this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    inforoom = "checked in";
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
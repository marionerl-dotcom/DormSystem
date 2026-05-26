using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        public void selectedRoom(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            if (selectedButton != null)
            {
                reserve_checkin form = new reserve_checkin(); //instance sa reserve_checkin form
                form.UserRole = UserSession.CurrentRole;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    if (form.inforoom == "checked in")
                    {
                        selectedButton.BackColor = Color.Red;
                        selectedButton.ForeColor = Color.White; 
                    }
                    else if (form.inforoom == "reserved")
                    {
                        selectedButton.BackColor = Color.Yellow;
                        selectedButton.ForeColor = Color.Black; 
                    }
                }
            }
        }
    }
}
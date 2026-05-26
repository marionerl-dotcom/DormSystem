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

    public partial class login : Form
    {
        private Form1 mainform = new Form1();
        public string User { get; private set; }
       
        public login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserSession.CurrentRole = "admin";
            mainform.ShowDialog();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserSession.CurrentRole = "user";
            mainform.ShowDialog();

        }
    }
}

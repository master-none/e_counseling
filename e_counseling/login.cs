using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_counseling
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String user = tb_username.Text;
            String password = tb_password.Text;

            if (user =="Admin" && password == "12345")
            {
                var newform = new HomePage();
                newform.Show();
            } else
            {
                var newform1 = new ErrorLogin();
                newform1.Show();
            }


        }
    }
}

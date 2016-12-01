using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopverk
{
    public partial class Admin_login : Form
    {
        int counter = 3;
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
            
                if (tb_username.Text == "Admin" && tb_password.Text == "password1234")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    counter = 3;
                    Close();
                }
                else
                {
                    
                    counter--;
                    MessageBox.Show("Wrong Username or Password "+ counter+" tries left");
                    if (counter == 0)
                    {
                        Form1 form = new Form1();
                        Close();
                    }
                }

            

        }

    }
}

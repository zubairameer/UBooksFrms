using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UBooksFrms
{
    public partial class log_Inlog : Form
    {
        public log_Inlog()
        {
            InitializeComponent();
        }

        public string email;
        public string password;

        private void button1_Click(object sender, EventArgs e)
        {
            email = textBox1.Text;
            password = textBox2.Text;

            if(password == "ubooks1")
            {
                admin ad = new admin();
                ad.ShowDialog();
            }
            else
            {
                Form1 f2 = new Form1();
                f2.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            rs.ShowDialog();
        }
    }
}

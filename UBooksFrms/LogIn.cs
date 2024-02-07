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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log_Inlog log = new log_Inlog();
            log.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log_Inlog sign = new log_Inlog();
            sign.ShowDialog();
        }
    }
}

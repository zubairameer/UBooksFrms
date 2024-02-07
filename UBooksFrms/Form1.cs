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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sell f2 = new Sell();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buy b1 = new Buy();
            b1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aboutFr ABT = new aboutFr();
            ABT.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin adFrm = new admin();
            adFrm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            about abt = new about();
            abt.ShowDialog();
        }
    }
}

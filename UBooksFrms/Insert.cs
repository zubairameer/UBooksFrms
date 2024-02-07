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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        public string ID;
        public string BN;
        public string condition;
        public string year;
        public string price;
            

        private void Insert_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ID = textBox1.Text;
            BN = textBox2.Text;
            condition = textBox3.Text;
            year = textBox4.Text;
            price = textBox5.Text;

            this.Close();
        }
    }
}

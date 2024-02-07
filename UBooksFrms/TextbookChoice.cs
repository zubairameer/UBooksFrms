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
    public partial class TextbookChoice : Form
    {
        public TextbookChoice()
        {
            InitializeComponent();
        }

        public void dgvChoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Buy b1 = new Buy();

           
        }

        private void TextbookChoice_Load(object sender, EventArgs e)
        {

            label1.Text = Buy.BookName;
            label2.Text = Buy.Cond;
            label3.Text = Buy.PurchaseYear;
            label4.Text = Buy.price;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you took a screenshot?");
            this.Close();
        }
    }
}

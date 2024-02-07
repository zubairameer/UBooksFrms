using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UBooksFrms
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        string conStr = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Desktop\CMPG 223\UBooksFrms\UBooksFrms\TBWork.mdf;Integrated Security=True");
        SqlConnection conn;

        SqlDataAdapter adap;
        DataSet ds;
        SqlCommand comm;

        public static string id = "";
        public static string BookName = "";
        public static string Cond = "";
        public static string PurchaseYear = "";
        public static string price = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

        }

        public void selectQ()
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 1";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }


        private void Buy_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectQ();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 2";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 3";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 4";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 5";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 6";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 7";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 8";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 9";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW WHERE ID = 10";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            textBox5.Text = selectedRow.Cells[4].Value.ToString();

            TextbookChoice frmTC = new TextbookChoice();

        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            BookName = textBox2.Text;
            Cond = textBox3.Text;
            PurchaseYear = textBox4.Text;
            price = textBox5.Text;

            TextbookChoice frmTC = new TextbookChoice();
            frmTC.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();

            this.Close();
        }
    }
}

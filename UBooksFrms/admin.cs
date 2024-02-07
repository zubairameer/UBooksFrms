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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        string conStr = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Desktop\CMPG 223\UBooksFrms\UBooksFrms\TBWork.mdf;Integrated Security=True");
        SqlConnection conn;

        SqlDataAdapter adap;
        DataSet ds;
        SqlCommand comm;

        private void admin_Load(object sender, EventArgs e)
        {
          
        }

        public void selectQBuy()
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM BuyW";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectQBuy();
        }

        public void selectQSell()
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM SellW";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectQSell();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void deleteQ()
        {

            string delete_query = "DELETE FROM BuyW WHERE Id ='" + textBox1.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(delete_query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            //adapter.DeleteCommand.ExecuteNonQuery();


            conn.Close();

            MessageBox.Show("Item deleted Successfully!");
        }

        public void deleteUser()
        {

            //string delete_query = "DELETE FROM User WHERE StudentNumber ='" + textBox4.Text + "'";
            conn.Open();
           // SqlCommand cmd = new SqlCommand(delete_query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.ExecuteNonQuery();


            conn.Close();

            MessageBox.Show("Item deleted Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteQ();
        }

        public void InsertQ()
        {
            Insert frmInsert = new Insert();
            frmInsert.ShowDialog();

            try
            {
                SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Desktop\CMPG 223\UBooksFrms\UBooksFrms\TBWork.mdf;Integrated Security=True");
                myCon.Open();

                SqlCommand sqlInsert = new SqlCommand($"INSERT INTO BuyW(Id,BookName,Condition,PurchaseYear,Price) VALUES ('{frmInsert.ID}','{frmInsert.BN}','{frmInsert.condition}','{frmInsert.year}','{frmInsert.price}')", myCon);
                SqlDataAdapter myadap = new SqlDataAdapter();

                myadap.InsertCommand = sqlInsert;
                myadap.InsertCommand.ExecuteNonQuery();

                myCon.Close();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }

        }

        public void SelectUsers()
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM Users";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SourceTable";

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectUsers();
        }

        private void sortDB(string value)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            DataView dv;

            string sql = "SELECT * FROM BuyW";
            cmd = new SqlCommand(sql, conn);
            adapter.SelectCommand = cmd;

            
            adapter.Fill(ds);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView1.DataSource = dv;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortDB(comboBox1.SelectedItem.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void UpdateQ()
        {
            
            conn.Open();

            String sql = "UPDATE BuyW SET Price = @Price WHERE Id = @num";
            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@Price", textBox2.Text);
            comm.Parameters.AddWithValue("num", textBox3.Text);
            comm.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Record Updated!");

            selectQBuy();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateQ();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

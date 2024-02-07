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

   

    public partial class Register : Form
    {
        string conStr = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Desktop\CMPG 223\UBooksFrms\UBooksFrms\TBWork.mdf;Integrated Security=True");
        SqlConnection conn;

        SqlDataAdapter adap;
        DataSet ds;
        SqlCommand comm;

        public Register()
        {
            InitializeComponent();
        }

        public string firstN;
        public string LastN;
        public string StudNum;
        public string email;
        public string phone;
       


        private void button1_Click(object sender, EventArgs e)
        {
            firstN = textBox1.Text;
            LastN = textBox2.Text;
            StudNum = txtSN.Text;
            email = txtE.Text;
            phone = txtP.Text;

            log_Inlog log = new log_Inlog();
            log.ShowDialog();

            InsertUsers();
          
        }

        public void InsertUsers()
        {

            try
            {
                SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Desktop\CMPG 223\UBooksFrms\UBooksFrms\TBWork.mdf;Integrated Security=True");
                myCon.Open();

                SqlCommand sqlInsert = new SqlCommand($"INSERT INTO Users(StudentNumber,Email,Phone) VALUES ('{txtSN.Text}','{txtE.Text}','{txtP.Text}')", myCon);
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

        private void Register_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("North West University");
        }
    }
}

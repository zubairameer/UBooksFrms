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
using System.IO;

namespace UBooksFrms
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zubai\Desktop\CMPG 223\UBooksFrms\UBooksFrms\TBWork.mdf;Integrated Security=True");

        string imgLocation = "";
        SqlCommand cmd;



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            conn.Open();
             
            String sqlQuery = "INSERT INTO SellW(StudentNum,BookName,image)VALUES('" + textBox1.Text + "','" + textBox2.Text + "' ,@images) ";
            cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            //int N = cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(" SuccessFully Saved!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();

            this.Close();
        }
    }
}

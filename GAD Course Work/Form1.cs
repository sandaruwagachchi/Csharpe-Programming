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

namespace GAD_Course_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=SANDARUWAGACHCH;" + "Initial Catalog=kingHoteldb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM tblLogin WHERE username=@username AND password=@password";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@username", this.textBox1.Text);
            com.Parameters.AddWithValue("@password", this.textBox2.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                this.lblMessage.Text = "Invalid User Name or Password";
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 register = new Form3();
            register.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

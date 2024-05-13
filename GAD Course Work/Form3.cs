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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=SANDARUWAGACHCH;" + "Initial Catalog=kingHoteldb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO tblLogin VALUES(@username,@password)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@username", this.textBox1.Text);
            com.Parameters.AddWithValue("@password", this.textBox4.Text);

            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of Records inserted" + ret);

            Form1 login = new Form1();
            login.Show();
            this.Hide();

            con.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 booking = new Form2();
            booking.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=SANDARUWAGACHCH;" + "Initial Catalog=kingHoteldb;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "INSERT INTO tblHotelBooking (first_name, telephone_no, number_of_guests, room_type, check_in_date, check_out_date, number_of_rooms) VALUES (@first_name, @telephone_no, @number_of_guests, @room_type, @check_in_date, @check_out_date, @number_of_rooms)";

            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@first_name", this.textBox1.Text);
            com.Parameters.AddWithValue("@telephone_no", this.textBox2.Text);
            com.Parameters.AddWithValue("@number_of_guests", (int)this.numericUpDown1.Value);
            com.Parameters.AddWithValue("@room_type", this.comboBox1.Text);
            com.Parameters.AddWithValue("@check_in_date", this.dateTimePicker1.Text);
            com.Parameters.AddWithValue("@check_out_date", this.dateTimePicker2.Text);
            com.Parameters.AddWithValue("@number_of_rooms", this.numericUpDown2.Value);
   


            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of Records inserted" + ret);


            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

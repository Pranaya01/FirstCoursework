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

namespace CoffeeShopManagement
{
    public partial class Coffee : Form
    {
        //Making Db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\CoffeeShopManagement\CoffeeShopManagement\coffee.mdf;Integrated Security=True");

        public Coffee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //showing stored data stored in database to datatable
            int count = 0;
            SqlCommand c = con.CreateCommand();
            c.CommandType = CommandType.Text;
            c.CommandText = "select * from coffee where Coffee_Name='"+ textBox1.Text+"'";
            c.ExecuteNonQuery();
            if (count == 0)
            {
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(c);
                da1.Fill(dt1);
                count = Convert.ToInt32(dt1.Rows.Count.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Coffee values( '" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";

            }
            else
            {
                MessageBox.Show("this Coffee is already added");
            }
        
         
            display();
        }

        private void Coffee_Load(object sender, EventArgs e)
        {
            //checks if connection is open or not
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }
        public void display()
        {
            //void method to dipslay data from sql database to datatable
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from coffee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button action for deletng the coffee data
            int id;
            id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from coffee where CoffeeId = "+id +"";
            cmd.ExecuteNonQuery();
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

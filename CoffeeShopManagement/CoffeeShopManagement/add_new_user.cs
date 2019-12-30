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
    public partial class add_new_user : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\CoffeeShopManagement\CoffeeShopManagement\Coffee.mdf;Integrated Security=True");
        public add_new_user()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //action of the button
            int i = 0;
            //creating command
            SqlCommand cmd = con.CreateCommand();
            //converting cmd.commandType to Text
            cmd.CommandType = CommandType.Text;
            //select query 
            cmd.CommandText = "select * from registration where username ='" + txctUsername.Text + "'";
            //executing the query
            cmd.ExecuteNonQuery();
            //creating new datatable obj dt
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //filling the sql database data into datatable
            da.Fill(dt);
            //convering row of datatable into String
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                //creating command cmd1 
                SqlCommand cmd1 = con.CreateCommand();
                //converting command m1 to text using CommandType
                cmd1.CommandType = CommandType.Text;
                //inserting the cm1 with insert querys
                cmd1.CommandText="insert into registration values('"+txtFirstName.Text+"','"+txtLastName.Text+"','"+txctUsername.Text+"','"+lblPass.Text+"','"+txtEmail.Text+"','"+txtContact.Text+"')";
                //executing the query
                cmd1.ExecuteNonQuery();
                txtFirstName.Text = ""; txtLastName.Text = "";
                txctUsername.Text = ""; lblPass.Text = "";
                txtEmail.Text = ""; txtContact.Text = ""; 
                MessageBox.Show("User added sucessfully");
            }
            else
            {
                MessageBox.Show("This username already exist please choose another");

            }
        }

        private void add_new_user_Load(object sender, EventArgs e)
        {
        //making connection close
        if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

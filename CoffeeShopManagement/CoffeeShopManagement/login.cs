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
    public partial class login : Form

    {
        //establishing database connection    
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\CoffeeShopManagement\CoffeeShopManagement\Coffee.mdf;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Action of Login button
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where username ='"+ txtUserName.Text + "' and password ='"+ textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            //SqlData Adapter is used to provide connection between dataset and sql database
            //establishing connection btw dataset and sql database
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            da.Fill(dt);
            //converting datatable row count from string to int
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            //checking username and password
            if (i == 0)
            {
                MessageBox.Show("username and password does not match");
             }
            else
            {
                this.Hide();
                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            //checking database connection is open or close

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}

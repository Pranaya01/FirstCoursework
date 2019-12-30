﻿using System;
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
    public partial class OrderForm : Form
    {
        //making connection with database
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\CoffeeShopManagement\CoffeeShopManagement\Coffee.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        int tot = 0;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //action of button order
            DataRow dr = dt.NewRow();
            dr["CoffeeName"] = cbCoffeeType.Text;
            dr["price"] = txtRate.Text;
            dr["volume"] = txrVolume.Text;
            dr["total"] = txtTotal.Text;
            dr["ro]
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
            tot = tot + Convert.ToInt32(dr["total"].ToString());
            lblAmount.Text = tot.ToString();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //checking database connection is open or close
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            //calling methods
            fill_coffeetype();
            fill_CoffeSize();
            dt.Clear();
            dt.Columns.Add("CoffeeName");
            dt.Columns.Add("price");
            dt.Columns.Add("volume");
            dt.Columns.Add("total");
        }
        public void fill_coffeetype()
        {
            cbCoffeeType.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Coffee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbCoffeeType.Items.Add(dr["Coffee_Name"].ToString());
            }
          
        }
        public void fill_CoffeSize()
        {
            cbCoffeeSize.Items.Clear();
            SqlCommand cmd= con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CupSize";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbCoffeeSize.Items.Add(dr["KeepCupSize"].ToString());
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Coffee where Coffee_Name='"+ cbCoffeeType.Text +"'";
            cmd.ExecuteNonQuery();
            SqlDataReader mreader;
            try
            {
               // con.Open();
                mreader = cmd.ExecuteReader();
                if(mreader != null)
                {
                    while (mreader.Read())
                    {
                        int rs = mreader.GetInt32(2);
                        txtRate.Text = rs.ToString();
                       
                    }
                }
                mreader.Close();
                mreader.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CupSize where KeepCupSize='" + cbCoffeeSize.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader mreader;
            try
            {
                // con.Open();
                mreader = cmd.ExecuteReader();
                if(mreader != null)
                {
                    while (mreader.Read())
                    {
                        int rs = mreader.GetInt32(2);
                        txrVolume.Text = rs.ToString();


                    }
                }
                mreader.Close();
                mreader.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtRate.Text) * Convert.ToInt32(txrVolume.Text));
            }
            catch(Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //action of delete button
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));
                foreach(DataRow dr1 in dt.Rows)
                {
                    tot = tot + Convert.ToInt32(dr1["total"].ToString());
                    lblAmount.Text = tot.ToString();
                }
            }
            catch(Exception ex)
            {

            }
        }
        //action of button save
        private void button2_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            
            cmd1.CommandText = "insert into Orders values('"+ txtCustomerName.Text +"','"+ dtOrderDate.Value.Date.ToString("yyyy/MM/dd") + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from Orders order by OrderId desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["OrderId"].ToString();
            }

            foreach(DataRow dr in dt.Rows)
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into orderdetails values('" + orderid.ToString() + "','"+ dr["CoffeeName"].ToString() +"','"+ dr["price"].ToString() +"','"+ dr["volume"].ToString() + "','"+ dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();
            }
            txtCustomerName.Text = "";
            txtRate.Text = "";
            txrVolume.Text = "";
            txtTotal.Text = "";
            lblAmount.Text = "0";
            dt.Clear();
            dataGridView1.DataSource = dt;
            MessageBox.Show("message inserted sucessfully");


        }


        #region save plus print
        private void button5_Click(object sender, EventArgs e)
        {
            /*string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;

            cmd1.CommandText = "insert into Orders values('" + textBox1.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyy/MM/dd") + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from Orders order by OrderId desc";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                orderid = dr2["OrderId"].ToString();
            }

            foreach (DataRow dr in dt.Rows)
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into orderdetails values('" + orderid.ToString() + "','" + dr["CoffeeName"].ToString() + "','" + dr["price"].ToString() + "','" + dr["volume"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            label7.Text = "0";
            dt.Clear();
            dataGridView1.DataSource = dt;
            //bill b = new bill();
            //b.get_value(Convert.ToInt32(orderid.ToString()));
            //b.Show();
        }
        */
        #endregion
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
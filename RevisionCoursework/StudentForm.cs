using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.ErrorProvider;

namespace RevisionCoursework
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();
            btnUpdate.Visible = false;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
             if (CheckValidation())
            {
                Student obj = new Student();

                string firstname = txtFName.Text;
                string lastname = txtLName.Text;
                obj.Name = firstname + " " + lastname;

                string gender = comboboxG.SelectedItem.ToString();
                obj.Gender = gender;

                obj.BirthDate = dtBirthDate.Value;

                string address = txtAddress.Text;
                obj.Address = address;

                string email = txtEmail.Text;
                obj.Email = email;

                string contact = txtContact.Text;
                obj.ContactNo = contact;

                string enroll = cbPEnroll.SelectedItem.ToString();
                obj.Enroll = enroll;

                obj.RegisterDate = dtRDate.Value;

                obj.Add(obj);
                BindGrid();
                btnUpdate.Visible = false;
                Clear();
            }
                   
        }
        private bool CheckValidation()
        {
            if (txtFName.Text == "")
            {
                MsgValidation(txtFName, "Please Enter student's First Name!!");
                return false;
            }
            if (txtLName.Text == "")
            {
                MsgValidation(txtLName, "Please Enter Student's Last Name!!");
                return false;
            }
            if (comboboxG.Text == "")
            {
                MsgValidation(comboboxG, "Please Select Student's Gender!!");
                return false;
            }
            if (DateTime.Today.AddYears(-18) < dtBirthDate.Value.Date)
            {
                MsgValidation(dtBirthDate, "Please Select Student's BirthDate!!");
                return false;
            }
            if (txtAddress.Text == "")
            {
                MsgValidation(txtAddress, "Please Enter Student's Address!!");
                return false;
            }
            if (txtEmail.Text == "")
            {
                MsgValidation(txtEmail, "Please Enter Student's Email Address!!");
                return false;
            }
            if (txtContact.Text == "")
            {
                MsgValidation(txtContact, "Please Enter Student's Contact Number!!");
                return false;
            }
            if (cbPEnroll.Text == "")
            {
                MsgValidation(cbPEnroll, "Please Select Student's enrollment program!!");
                return false;
            }
            if (dtRDate.Text == "")
            {
                MsgValidation(dtRDate, "Please Select Student's registered date!!");
                return false;
            }



            return true;
        }

        private void MsgValidation(Control ctrl, string MsgValidation)
        {
            ctrl.BackColor = Color.Red;
            MessageBox.Show(MsgValidation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ctrl.Focus();
        }
        public void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            studentDataGrid.DataSource = dt;
           // BindChart(listStudents);
        }

        private void Clear()
        {
            txtId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            dtBirthDate.Value = DateTime.Today;
            txtContact.Text = "";
            comboboxG.SelectedItem = null;
            cbPEnroll.SelectedItem = null;
            dtRDate.Value = DateTime.Today;
        }

        private void studentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            if(e.ColumnIndex == 0)
            {
                //getting the value of clicked rows id column
                string val = studentDataGrid[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(val))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(val);
                    Student stud = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    txtId.Text = stud.Id.ToString();
                    txtFName.Text = stud.Name.Split(' ')[0];
                    txtLName.Text = stud.Name.Split(' ')[1];
                    comboboxG.SelectedItem = stud.Gender;
                    dtBirthDate.Value = stud.BirthDate;
                    txtEmail.Text = stud.Email;
                    txtAddress.Text = stud.Address;
                    txtContact.Text = stud.ContactNo;
                    cbPEnroll.SelectedItem = stud.Enroll;
                    dtRDate.Value = stud.RegisterDate;
                    //btnSubmit.Visible = false;
                    btnUpdate.Visible = true;
                }
            }
            else if(e.ColumnIndex == 1)
            {
                string msg = "Do you want to Delete this record";
                string title = "Delete Confirmation";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(msg, title, btn);
                if (result == DialogResult.OK)
                {
                    string val = studentDataGrid[2, e.RowIndex].Value.ToString();
                    //int id = 1;
                    obj.Delete(int.Parse(val));
                    BindGrid();
                    MessageBox.Show("Record Successfully Deleted");
                }
               
            }
        }
  
        private void BindChart(List<Student> lst)
        {
            /*
            if (lst != null)
            {
                var result = lst
                .GroupBy(l => l.Gender)
                .Select(cl => new
                {
                    Gender = cl.First().Gender,
                    Count = cl.Count().ToString()
                }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chart1.DataSource = dt;
                chart1.Name = "Gender";
                chart1.Series["Series1"].XValueMember = "Gender";
                chart1.Series["Series1"].XValueMember = "Count";
                //chart1.Series["Series1"].XValueMember = "Gender";
                //removing the title because it is in array we only need one title
                this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
                this.chart1.Titles.Add("Weekly Enrollment Chart");
                chart1.Series["Series1"].IsValueShownAsLabel = true;
            }
            */
            
        }
       

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student obj = new Student();

            string firstname = txtFName.Text;
            string lastname = txtLName.Text;
            obj.Name = firstname + " " + lastname;
            obj.Gender = comboboxG.SelectedItem.ToString();
            obj.BirthDate = dtBirthDate.Value;

            string address = txtAddress.Text;
            obj.Address = address;

            string email = txtEmail.Text;
            obj.Email = email;

            string contact = txtContact.Text;
            obj.ContactNo = contact;

            string enroll = cbPEnroll.SelectedItem.ToString();
            obj.Enroll = enroll;

            obj.RegisterDate = dtRDate.Value;

            obj.Edit(obj);
            BindGrid();
            Clear();
        }

        
      

        private void lblProgramEnroll_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
        }

        private void TextChanged_Ctrl(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

       
    }
}

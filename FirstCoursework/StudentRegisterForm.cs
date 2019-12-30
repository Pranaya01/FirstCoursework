using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCourseWork
{
    public partial class StudentRegisterForm : Form
    {
        public StudentRegisterForm()
        {
            InitializeComponent();
            BindGrid();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentRegister studRegister = new StudentRegister();
            string first_name = txtFirstName.Text;
            string last_name = txtLastName.Text;
            studRegister.Name = first_name + " " + last_name;
            string address = txtAddress.Text;
            studRegister.Address = address;
            string email = txtEmail.Text;
            studRegister.Email = email;
            string contact_no = txtContactNo.Text;
            studRegister.ContactNo = contact_no;
            DateTime dateOfBirth = dtDateOfBirth.Value;
            studRegister.DateOfBirth = dateOfBirth;
            string gender = cbGender.SelectedItem.ToString();
            studRegister.Gender = gender;
            string course_enroll = cbCourseEnroll.SelectedItem.ToString();
            studRegister.CourseEnroll = course_enroll;
            DateTime register_date = dtRegisterDate.Value;
            studRegister.RegisterDate = register_date;
            studRegister.Add(studRegister);
            BindGrid();
            Clear();


        }
        public void Clear()
        {
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtContactNo.Text = "";
            dtDateOfBirth.Value = DateTime.Today;
            cbGender.SelectedItem = null;
            cbCourseEnroll.SelectedItem = null;
            dtRegisterDate.Value = DateTime.Today;

        }
        public void BindGrid()
        {
            StudentRegister studRegister = new StudentRegister();
            List<StudentRegister> studentLists = studRegister.List();
            DataTable dt = Utility.ConvertToDataTable(studentLists);
            dgStudentData.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentRegister studRegister = new StudentRegister();
            studRegister.StudentId = int.Parse(txtStudentId.Text);
            string first_name = txtFirstName.Text;
            //string 
        }
    }
}

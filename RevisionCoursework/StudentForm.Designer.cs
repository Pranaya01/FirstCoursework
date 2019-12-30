namespace RevisionCoursework
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblStudRegistration = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblProgramEnroll = new System.Windows.Forms.Label();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.comboboxG = new System.Windows.Forms.ComboBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cbPEnroll = new System.Windows.Forms.ComboBox();
            this.dtRDate = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudRegistration
            // 
            this.lblStudRegistration.AutoSize = true;
            this.lblStudRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudRegistration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStudRegistration.Location = new System.Drawing.Point(283, 13);
            this.lblStudRegistration.Name = "lblStudRegistration";
            this.lblStudRegistration.Size = new System.Drawing.Size(298, 33);
            this.lblStudRegistration.TabIndex = 1;
            this.lblStudRegistration.Text = "Student Registration";
            this.lblStudRegistration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(307, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 167);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Email Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Address:";
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Location = new System.Drawing.Point(307, 123);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(57, 13);
            this.lblBDate.TabIndex = 10;
            this.lblBDate.Text = "Birth Date:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(307, 167);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(64, 13);
            this.lblContactNo.TabIndex = 13;
            this.lblContactNo.Text = "Contact No:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(23, 122);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(347, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.studentDataGrid.Location = new System.Drawing.Point(12, 333);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.Size = new System.Drawing.Size(652, 167);
            this.studentDataGrid.TabIndex = 17;
            this.studentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGrid_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(450, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblProgramEnroll
            // 
            this.lblProgramEnroll.AutoSize = true;
            this.lblProgramEnroll.Location = new System.Drawing.Point(21, 242);
            this.lblProgramEnroll.Name = "lblProgramEnroll";
            this.lblProgramEnroll.Size = new System.Drawing.Size(78, 13);
            this.lblProgramEnroll.TabIndex = 19;
            this.lblProgramEnroll.Text = "Program Enroll:";
            this.lblProgramEnroll.Click += new System.EventHandler(this.lblProgramEnroll_Click);
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Location = new System.Drawing.Point(307, 242);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(92, 13);
            this.lblRegisterDate.TabIndex = 21;
            this.lblRegisterDate.Text = "Registration Date:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(107, 84);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(139, 20);
            this.txtFName.TabIndex = 25;
            this.txtFName.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            this.txtFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFName_Validating);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(406, 84);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(139, 20);
            this.txtLName.TabIndex = 27;
            this.txtLName.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            // 
            // comboboxG
            // 
            this.comboboxG.FormattingEnabled = true;
            this.comboboxG.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboboxG.Location = new System.Drawing.Point(107, 120);
            this.comboboxG.Name = "comboboxG";
            this.comboboxG.Size = new System.Drawing.Size(139, 21);
            this.comboboxG.TabIndex = 28;
            this.comboboxG.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(406, 120);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 199);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(139, 20);
            this.txtAddress.TabIndex = 31;
            this.txtAddress.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(406, 164);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(139, 20);
            this.txtContact.TabIndex = 32;
            this.txtContact.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            // 
            // cbPEnroll
            // 
            this.cbPEnroll.FormattingEnabled = true;
            this.cbPEnroll.Items.AddRange(new object[] {
            "Computing",
            "Multimedia Technologies",
            "Networking and Security"});
            this.cbPEnroll.Location = new System.Drawing.Point(105, 239);
            this.cbPEnroll.Name = "cbPEnroll";
            this.cbPEnroll.Size = new System.Drawing.Size(139, 21);
            this.cbPEnroll.TabIndex = 33;
            this.cbPEnroll.TextChanged += new System.EventHandler(this.TextChanged_Ctrl);
            // 
            // dtRDate
            // 
            this.dtRDate.Location = new System.Drawing.Point(406, 235);
            this.dtRDate.Name = "dtRDate";
            this.dtRDate.Size = new System.Drawing.Size(200, 20);
            this.dtRDate.TabIndex = 34;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(107, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(139, 20);
            this.txtId.TabIndex = 35;
            this.txtId.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(714, 60);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(1023, 544);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtRDate);
            this.Controls.Add(this.cbPEnroll);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.comboboxG);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblRegisterDate);
            this.Controls.Add(this.lblProgramEnroll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.studentDataGrid);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblBDate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudRegistration);
            this.Name = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label lblStudRegistration;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBDate;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblProgramEnroll;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.ComboBox comboboxG;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cbPEnroll;
        private System.Windows.Forms.DateTimePicker dtRDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}


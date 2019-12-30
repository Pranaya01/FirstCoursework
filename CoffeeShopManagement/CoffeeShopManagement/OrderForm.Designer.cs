namespace CoffeeShopManagement
{
    partial class OrderForm
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCoffeeSize = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbCoffeeType = new System.Windows.Forms.ComboBox();
            this.txrVolume = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCoffeeSize = new System.Windows.Forms.Label();
            this.lblCoffeeType = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotalO = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(36, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(320, 38);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(77, 15);
            this.lblOrderDate.TabIndex = 0;
            this.lblOrderDate.Text = "Order Date";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(152, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(150, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(414, 34);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtOrderDate.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbCoffeeSize);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.cbCoffeeType);
            this.panel1.Controls.Add(this.txrVolume);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.lblRate);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblCoffeeSize);
            this.panel1.Controls.Add(this.lblCoffeeType);
            this.panel1.Location = new System.Drawing.Point(34, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 156);
            this.panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 69);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrder.Location = new System.Drawing.Point(695, 117);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(695, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCoffeeSize
            // 
            this.cbCoffeeSize.FormattingEnabled = true;
            this.cbCoffeeSize.Location = new System.Drawing.Point(209, 45);
            this.cbCoffeeSize.Name = "cbCoffeeSize";
            this.cbCoffeeSize.Size = new System.Drawing.Size(121, 21);
            this.cbCoffeeSize.TabIndex = 1;
            this.cbCoffeeSize.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(668, 46);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(112, 20);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtTotal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox5_MouseDown);
            // 
            // cbCoffeeType
            // 
            this.cbCoffeeType.FormattingEnabled = true;
            this.cbCoffeeType.Location = new System.Drawing.Point(37, 44);
            this.cbCoffeeType.Name = "cbCoffeeType";
            this.cbCoffeeType.Size = new System.Drawing.Size(121, 21);
            this.cbCoffeeType.TabIndex = 1;
            this.cbCoffeeType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txrVolume
            // 
            this.txrVolume.Location = new System.Drawing.Point(506, 46);
            this.txrVolume.Name = "txrVolume";
            this.txrVolume.Size = new System.Drawing.Size(136, 20);
            this.txrVolume.TabIndex = 1;
            this.txrVolume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(365, 46);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(112, 20);
            this.txtRate.TabIndex = 1;
            this.txtRate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(362, 26);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(82, 15);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Rate per ml";
            this.lblRate.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(503, 22);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(112, 15);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "volume of coffee";
            this.lblVolume.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(665, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCoffeeSize
            // 
            this.lblCoffeeSize.AutoSize = true;
            this.lblCoffeeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeSize.Location = new System.Drawing.Point(206, 26);
            this.lblCoffeeSize.Name = "lblCoffeeSize";
            this.lblCoffeeSize.Size = new System.Drawing.Size(80, 15);
            this.lblCoffeeSize.TabIndex = 0;
            this.lblCoffeeSize.Text = "Coffee Size";
            this.lblCoffeeSize.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCoffeeType
            // 
            this.lblCoffeeType.AutoSize = true;
            this.lblCoffeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeType.Location = new System.Drawing.Point(34, 22);
            this.lblCoffeeType.Name = "lblCoffeeType";
            this.lblCoffeeType.Size = new System.Drawing.Size(78, 15);
            this.lblCoffeeType.TabIndex = 0;
            this.lblCoffeeType.Text = "CoffeeType";
            this.lblCoffeeType.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(537, 140);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTotalO
            // 
            this.lblTotalO.AutoSize = true;
            this.lblTotalO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalO.Location = new System.Drawing.Point(687, 255);
            this.lblTotalO.Name = "lblTotalO";
            this.lblTotalO.Size = new System.Drawing.Size(39, 15);
            this.lblTotalO.TabIndex = 0;
            this.lblTotalO.Text = "Total";
            this.lblTotalO.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(766, 255);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(39, 15);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "0000";
            this.lblAmount.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(691, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(577, 303);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 400);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblTotalO);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCoffeeSize;
        private System.Windows.Forms.ComboBox cbCoffeeType;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCoffeeSize;
        private System.Windows.Forms.Label lblCoffeeType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalO;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txrVolume;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblVolume;
    }
}
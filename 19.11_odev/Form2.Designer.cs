namespace _19._11_odev
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbEmployee = new ComboBox();
            cbShipper = new ComboBox();
            txtCity = new TextBox();
            btn2Add = new Button();
            dtpOrderDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 133);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ship City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 49);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 91);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Order Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 175);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 0;
            label4.Text = "Shipper";
            // 
            // cbEmployee
            // 
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(130, 46);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(151, 28);
            cbEmployee.TabIndex = 1;
            // 
            // cbShipper
            // 
            cbShipper.FormattingEnabled = true;
            cbShipper.Location = new Point(130, 172);
            cbShipper.Name = "cbShipper";
            cbShipper.Size = new Size(151, 28);
            cbShipper.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(130, 130);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(151, 27);
            txtCity.TabIndex = 2;
            // 
            // btn2Add
            // 
            btn2Add.Location = new Point(130, 226);
            btn2Add.Name = "btn2Add";
            btn2Add.Size = new Size(151, 29);
            btn2Add.TabIndex = 3;
            btn2Add.Text = "Add";
            btn2Add.UseVisualStyleBackColor = true;
            btn2Add.Click += btn2Add_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(130, 86);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(151, 27);
            dtpOrderDate.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 377);
            Controls.Add(dtpOrderDate);
            Controls.Add(btn2Add);
            Controls.Add(txtCity);
            Controls.Add(cbShipper);
            Controls.Add(cbEmployee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbEmployee;
        private ComboBox cbShipper;
        private TextBox txtCity;
        private Button btn2Add;
        private DateTimePicker dtpOrderDate;
    }
}
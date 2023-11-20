namespace _19._11_odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetOrder = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lstCustomer = new ListBox();
            dgvSiparisler = new DataGridView();
            lstShipper = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            SuspendLayout();
            // 
            // btnGetOrder
            // 
            btnGetOrder.Location = new Point(163, 37);
            btnGetOrder.Name = "btnGetOrder";
            btnGetOrder.Size = new Size(117, 29);
            btnGetOrder.TabIndex = 0;
            btnGetOrder.Text = "Get Order List";
            btnGetOrder.UseVisualStyleBackColor = true;
            btnGetOrder.Click += btnGetOrder_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(323, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(458, 37);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(601, 37);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstCustomer
            // 
            lstCustomer.FormattingEnabled = true;
            lstCustomer.Location = new Point(12, 37);
            lstCustomer.Name = "lstCustomer";
            lstCustomer.Size = new Size(145, 164);
            lstCustomer.TabIndex = 1;
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(163, 74);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.RowHeadersWidth = 51;
            dgvSiparisler.Size = new Size(532, 292);
            dgvSiparisler.TabIndex = 2;
            dgvSiparisler.CellClick += dgvSiparisler_CellClick;
            dgvSiparisler.CellDoubleClick += dgvSiparisler_CellDoubleClick;
            // 
            // lstShipper
            // 
            lstShipper.FormattingEnabled = true;
            lstShipper.Location = new Point(12, 242);
            lstShipper.Name = "lstShipper";
            lstShipper.Size = new Size(145, 124);
            lstShipper.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 408);
            Controls.Add(lstShipper);
            Controls.Add(dgvSiparisler);
            Controls.Add(lstCustomer);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrder);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetOrder;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListBox lstCustomer;
        private DataGridView dgvSiparisler;
        private ListBox lstShipper;
    }
}

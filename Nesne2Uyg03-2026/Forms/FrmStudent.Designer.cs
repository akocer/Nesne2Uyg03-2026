namespace Nesne2Uyg03_2026.Forms
{
    partial class FrmStudent
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
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtNumber = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dgStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 0;
            label1.Text = "Öğrenciler";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(888, 219);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(223, 29);
            txtPhone.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(755, 227);
            label6.Name = "label6";
            label6.Size = new Size(78, 22);
            label6.TabIndex = 78;
            label6.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(888, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 29);
            txtEmail.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(755, 195);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 76;
            label4.Text = "E-Posta";
            // 
            // txtName
            // 
            txtName.Location = new Point(888, 154);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 29);
            txtName.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(755, 162);
            label5.Name = "label5";
            label5.Size = new Size(102, 22);
            label5.TabIndex = 74;
            label5.Text = "Adı Soyadı";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(888, 122);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(223, 29);
            txtNumber.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(755, 130);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 72;
            label3.Text = "Öğrenci No";
            // 
            // txtId
            // 
            txtId.Location = new Point(888, 89);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(133, 29);
            txtId.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(755, 97);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 70;
            label2.Text = "Kayıt No";
            // 
            // dgStudent
            // 
            dgStudent.AllowUserToAddRows = false;
            dgStudent.AllowUserToDeleteRows = false;
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5 });
            dgStudent.Location = new Point(33, 79);
            dgStudent.Name = "dgStudent";
            dgStudent.ReadOnly = true;
            dgStudent.RowHeadersWidth = 62;
            dgStudent.RowTemplate.Height = 33;
            dgStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudent.Size = new Size(686, 363);
            dgStudent.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Öğr.No";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.OrangeRed;
            btnClear.Location = new Point(930, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 30);
            btnClear.TabIndex = 67;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.OrangeRed;
            btnDelete.Location = new Point(760, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 30);
            btnDelete.TabIndex = 68;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.OrangeRed;
            btnUpdate.Location = new Point(930, 265);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 30);
            btnUpdate.TabIndex = 65;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.OrangeRed;
            btnSave.Location = new Point(760, 265);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 30);
            btnSave.TabIndex = 66;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1161, 556);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtNumber);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgStudent);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.OrangeRed;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudent";
            Text = "FrmStudent";
            Load += FrmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtNumber;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
    }
}
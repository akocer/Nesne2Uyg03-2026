namespace Nesne2Uyg03_2026.Forms
{
    partial class FrmLesson
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
            txtCredit = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            txtCode = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            dgLesson = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(51, 24);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 2;
            label1.Text = "Dersler";
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(909, 193);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(203, 29);
            txtCredit.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(788, 202);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 89;
            label4.Text = "Kredi";
            // 
            // txtName
            // 
            txtName.Location = new Point(909, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 29);
            txtName.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(788, 165);
            label5.Name = "label5";
            label5.Size = new Size(85, 22);
            label5.TabIndex = 87;
            label5.Text = "Ders Adı";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(909, 119);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(203, 29);
            txtCode.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(788, 128);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 85;
            label3.Text = "Ders Kodu";
            // 
            // txtId
            // 
            txtId.Location = new Point(909, 82);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(121, 29);
            txtId.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(788, 91);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 83;
            label2.Text = "Kayıt No";
            // 
            // dgLesson
            // 
            dgLesson.AllowUserToAddRows = false;
            dgLesson.AllowUserToDeleteRows = false;
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgLesson.Location = new Point(51, 82);
            dgLesson.Name = "dgLesson";
            dgLesson.ReadOnly = true;
            dgLesson.RowHeadersWidth = 62;
            dgLesson.RowTemplate.Height = 33;
            dgLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLesson.Size = new Size(697, 412);
            dgLesson.TabIndex = 82;
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
            dataGridViewTextBoxColumn2.HeaderText = "Ders Kodu";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Ders Adı";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Kredi";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(947, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 34);
            btnClear.TabIndex = 80;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(793, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 34);
            btnDelete.TabIndex = 81;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(947, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 34);
            btnUpdate.TabIndex = 78;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(793, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 34);
            btnSave.TabIndex = 79;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmLesson
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1160, 531);
            Controls.Add(txtCredit);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(dgLesson);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.OrangeRed;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLesson";
            Text = "FrmLesson";
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtCredit;
        private Label label4;
        private TextBox txtName;
        private Label label5;
        private TextBox txtCode;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgLesson;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
    }
}
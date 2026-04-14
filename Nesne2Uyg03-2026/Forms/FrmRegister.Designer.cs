namespace Nesne2Uyg03_2026.Forms
{
    partial class FrmRegister
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgStudent = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dgLesson = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dgStudentLesson = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dgLessonStudent = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            removeStudent = new ToolStripMenuItem();
            btnRegister = new Button();
            txtLessonSearch = new TextBox();
            label3 = new Label();
            txtStudentSearch = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgStudentLesson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLessonStudent).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 4;
            label1.Text = "Dersler";
            // 
            // dgStudent
            // 
            dgStudent.AllowUserToAddRows = false;
            dgStudent.AllowUserToDeleteRows = false;
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5 });
            dgStudent.Location = new Point(566, 74);
            dgStudent.Name = "dgStudent";
            dgStudent.ReadOnly = true;
            dgStudent.RowHeadersWidth = 62;
            dgStudent.RowTemplate.Height = 33;
            dgStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudent.Size = new Size(686, 288);
            dgStudent.TabIndex = 70;
            dgStudent.CellClick += dgStudent_CellClick;
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
            // dgLesson
            // 
            dgLesson.AllowUserToAddRows = false;
            dgLesson.AllowUserToDeleteRows = false;
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgLesson.Location = new Point(12, 74);
            dgLesson.Name = "dgLesson";
            dgLesson.ReadOnly = true;
            dgLesson.RowHeadersWidth = 62;
            dgLesson.RowTemplate.Height = 33;
            dgLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLesson.Size = new Size(538, 288);
            dgLesson.TabIndex = 83;
            dgLesson.CellClick += dgLesson_CellClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Ders Kodu";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Ders Adı";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Kredi";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(566, 26);
            label2.Name = "label2";
            label2.Size = new Size(176, 45);
            label2.TabIndex = 4;
            label2.Text = "Öğrenciler";
            // 
            // dgStudentLesson
            // 
            dgStudentLesson.AllowUserToAddRows = false;
            dgStudentLesson.AllowUserToDeleteRows = false;
            dgStudentLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudentLesson.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dgStudentLesson.Location = new Point(714, 368);
            dgStudentLesson.Name = "dgStudentLesson";
            dgStudentLesson.ReadOnly = true;
            dgStudentLesson.RowHeadersWidth = 62;
            dgStudentLesson.RowTemplate.Height = 33;
            dgStudentLesson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStudentLesson.Size = new Size(538, 288);
            dgStudentLesson.TabIndex = 84;
            dgStudentLesson.CellClick += dgStudentLesson_CellClick;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Id";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Ders Kodu";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Ders Adı";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Kredi";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dgLessonStudent
            // 
            dgLessonStudent.AllowUserToAddRows = false;
            dgLessonStudent.AllowUserToDeleteRows = false;
            dgLessonStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLessonStudent.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17 });
            dgLessonStudent.ContextMenuStrip = contextMenuStrip1;
            dgLessonStudent.Location = new Point(12, 368);
            dgLessonStudent.Name = "dgLessonStudent";
            dgLessonStudent.ReadOnly = true;
            dgLessonStudent.RowHeadersWidth = 62;
            dgLessonStudent.RowTemplate.Height = 33;
            dgLessonStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLessonStudent.Size = new Size(686, 288);
            dgLessonStudent.TabIndex = 85;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Id";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Visible = false;
            dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Öğr.No";
            dataGridViewTextBoxColumn14.MinimumWidth = 8;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Adı Soyadı";
            dataGridViewTextBoxColumn15.MinimumWidth = 8;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn16.MinimumWidth = 8;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Telefon";
            dataGridViewTextBoxColumn17.MinimumWidth = 8;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { removeStudent });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(270, 69);
            // 
            // removeStudent
            // 
            removeStudent.Name = "removeStudent";
            removeStudent.Size = new Size(269, 32);
            removeStudent.Text = "Öğrenciyi Dersten Çıkar";
            removeStudent.Click += removeStudent_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.OrangeRed;
            btnRegister.Location = new Point(21, 679);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(231, 38);
            btnRegister.TabIndex = 86;
            btnRegister.Text = "Ders Kaydı Yap";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtLessonSearch
            // 
            txtLessonSearch.Location = new Point(400, 26);
            txtLessonSearch.Name = "txtLessonSearch";
            txtLessonSearch.Size = new Size(150, 31);
            txtLessonSearch.TabIndex = 87;
            txtLessonSearch.TextChanged += txtLessonSearch_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(309, 32);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 88;
            label3.Text = "Arama";
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.Location = new Point(1102, 26);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(150, 31);
            txtStudentSearch.TabIndex = 87;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(1011, 32);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 88;
            label4.Text = "Arama";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1301, 752);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStudentSearch);
            Controls.Add(txtLessonSearch);
            Controls.Add(btnRegister);
            Controls.Add(dgLessonStudent);
            Controls.Add(dgStudentLesson);
            Controls.Add(dgLesson);
            Controls.Add(dgStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegister";
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgStudentLesson).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLessonStudent).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dgLesson;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label2;
        private DataGridView dgStudentLesson;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridView dgLessonStudent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private Button btnRegister;
        private TextBox txtLessonSearch;
        private Label label3;
        private TextBox txtStudentSearch;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem removeStudent;
    }
}
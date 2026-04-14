namespace Nesne2Uyg03_2026
{
    partial class FrmMain
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            btnRegister = new Button();
            btnLesson = new Button();
            btnStudent = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1624, 121);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(342, 29);
            label1.Name = "label1";
            label1.Size = new Size(468, 54);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Takip Programı";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnLesson);
            panel2.Controls.Add(btnStudent);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 722);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.DeepSkyBlue;
            btnExit.Location = new Point(12, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(232, 47);
            btnExit.TabIndex = 0;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.DeepSkyBlue;
            btnRegister.Location = new Point(12, 187);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(232, 47);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Kayıt";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLesson
            // 
            btnLesson.FlatStyle = FlatStyle.Flat;
            btnLesson.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLesson.ForeColor = Color.DeepSkyBlue;
            btnLesson.Location = new Point(12, 134);
            btnLesson.Name = "btnLesson";
            btnLesson.Size = new Size(232, 47);
            btnLesson.TabIndex = 0;
            btnLesson.Text = "Dersler";
            btnLesson.UseVisualStyleBackColor = true;
            btnLesson.Click += btnLesson_Click;
            // 
            // btnStudent
            // 
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.DeepSkyBlue;
            btnStudent.Location = new Point(12, 81);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(232, 47);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Öğrenciler";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(262, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(1362, 722);
            panel3.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1624, 843);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            Text = "Öğrenci Takip";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegister;
        private Button btnLesson;
        private Button btnStudent;
        private Panel panel3;
        private Label label1;
        private Button btnExit;
    }
}

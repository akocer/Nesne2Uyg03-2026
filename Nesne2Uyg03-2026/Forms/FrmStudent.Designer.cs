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
            dgStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(72, 47);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 0;
            label1.Text = "Öğrenciler";
            // 
            // dgStudent
            // 
            dgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudent.Location = new Point(72, 108);
            dgStudent.Name = "dgStudent";
            dgStudent.RowHeadersWidth = 62;
            dgStudent.RowTemplate.Height = 33;
            dgStudent.Size = new Size(604, 419);
            dgStudent.TabIndex = 1;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1254, 632);
            Controls.Add(dgStudent);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudent";
            Text = "FrmStudent";
            ((System.ComponentModel.ISupportInitialize)dgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgStudent;
    }
}
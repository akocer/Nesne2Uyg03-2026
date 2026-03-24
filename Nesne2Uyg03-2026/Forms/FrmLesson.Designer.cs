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
            dgLesson = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLesson).BeginInit();
            SuspendLayout();
            // 
            // dgLesson
            // 
            dgLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLesson.Location = new Point(74, 100);
            dgLesson.Name = "dgLesson";
            dgLesson.RowHeadersWidth = 62;
            dgLesson.RowTemplate.Height = 33;
            dgLesson.Size = new Size(604, 419);
            dgLesson.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(74, 39);
            label1.Name = "label1";
            label1.Size = new Size(127, 45);
            label1.TabIndex = 2;
            label1.Text = "Dersler";
            // 
            // FrmLesson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1064, 584);
            Controls.Add(dgLesson);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLesson";
            Text = "FrmLesson";
            ((System.ComponentModel.ISupportInitialize)dgLesson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgLesson;
        private Label label1;
    }
}
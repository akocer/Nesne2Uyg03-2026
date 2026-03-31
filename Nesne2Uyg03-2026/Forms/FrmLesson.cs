using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nesne2Uyg03_2026.Models;

namespace Nesne2Uyg03_2026.Forms
{
    public partial class FrmLesson : Form
    {
        public FrmLesson()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        void GetLesson()
        {
            var lessons = db.Lessons.ToList();
            dgLesson.Rows.Clear();
            foreach (var lesson in lessons)
            {
                dgLesson.Rows.Add(lesson.Id, lesson.Code, lesson.Name, lesson.Credit);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "" || txtCredit.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Lessons.Count(c => c.Code == txtCode.Text) > 0)
            {
                MessageBox.Show("Girilen Ders Kodu Kayıtlıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lesson lesson = new Lesson
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Credit = Convert.ToInt32(txtCredit.Text),
                Created = DateTime.Now,
                Updated = DateTime.Now
            };

            db.Lessons.Add(lesson);
            db.SaveChanges();
            GetLesson();
            MessageBox.Show("Ders başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCode.Clear();
            txtName.Clear();
            txtCredit.Clear();
        }

        private void FrmLesson_Load(object sender, EventArgs e)
        {
            GetLesson();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtCode.Text == "" || txtName.Text == "" || txtCredit.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);

            if (db.Lessons.Count(c => c.Code == txtCode.Text && c.Id != id) > 0)
            {
                MessageBox.Show("Girilen Ders Kodu Kayıtlıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lesson = db.Lessons.Where(s => s.Id == id).SingleOrDefault();
            lesson.Code = txtCode.Text;
            lesson.Name = txtName.Text;
            lesson.Credit = Convert.ToInt32(txtCredit.Text);
            lesson.Updated = DateTime.Now;

            db.Lessons.Update(lesson);
            db.SaveChanges();
            GetLesson();
            MessageBox.Show("Ders başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }

        private void dgLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgLesson.CurrentRow.Cells[0].Value.ToString();
            txtCode.Text = dgLesson.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgLesson.CurrentRow.Cells[2].Value.ToString();
            txtCredit.Text = dgLesson.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" )
            {
                MessageBox.Show("Kayıt Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
                      
            var lesson = db.Lessons.Where(s => s.Id == id).SingleOrDefault();
            

            db.Lessons.Remove(lesson);
            db.SaveChanges();
            GetLesson();
            MessageBox.Show("Ders başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
        }
    }
}

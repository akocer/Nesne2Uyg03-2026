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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        void GetStudent()
        {
            var students = db.Students.ToList();
            dgStudent.Rows.Clear();
            foreach (var student in students)
            {
                dgStudent.Rows.Add(student.Id, student.Number, student.Name, student.Email, student.Phone);
            }
        }
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            GetStudent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Students.Count(c => c.Number == txtNumber.Text) > 0)
            {
                MessageBox.Show("Girilen Öğrenci Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            Student student = new Student
            {
                Number = txtNumber.Text,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
            GetStudent();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgStudent.CurrentRow.Cells[0].Value.ToString();
            txtNumber.Text = dgStudent.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgStudent.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgStudent.CurrentRow.Cells[3].Value.ToString();
            txtPhone.Text = dgStudent.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNumber.Text == "" || txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = int.Parse(txtId.Text);
            if (db.Students.Count(c => c.Number == txtNumber.Text && c.Id != id) > 0)
            {
                MessageBox.Show("Girilen Öğrenci Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var student = db.Students.Where(s => s.Id == id).SingleOrDefault();
            student.Number = txtNumber.Text;
            student.Name = txtName.Text;
            student.Email = txtEmail.Text;
            student.Phone = txtPhone.Text;
            student.Updated = DateTime.Now;

            db.Students.Update(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
            GetStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" )
            {
                MessageBox.Show("Lütfen kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = int.Parse(txtId.Text);
           
            var student = db.Students.Where(s => s.Id == id).SingleOrDefault();
           
            db.Students.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear.PerformClick();
            GetStudent();
        }
    }
}

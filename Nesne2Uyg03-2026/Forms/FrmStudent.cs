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
        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text=="" || txtName.Text=="" || txtEmail.Text=="" || txtPhone.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (db.Students.Count(c=>c.Number==txtNumber.Text) > 0)
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

        }
    }
}

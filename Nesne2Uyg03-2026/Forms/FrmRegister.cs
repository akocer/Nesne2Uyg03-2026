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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        void GetStudent(string st)
        {
            var students = db.Students.Where(s => s.Name.ToLower().Contains(st.ToLower())).ToList();
            dgStudent.Rows.Clear();
            foreach (var student in students)
            {
                dgStudent.Rows.Add(student.Id, student.Number, student.Name, student.Email, student.Phone);
            }
        }
        void GetLesson(string st)
        {
            var lessons = db.Lessons.Where(s => s.Name.ToLower().Contains(st.ToLower())).ToList();
            dgLesson.Rows.Clear();
            foreach (var lesson in lessons)
            {
                dgLesson.Rows.Add(lesson.Id, lesson.Code, lesson.Name, lesson.Credit);
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            GetStudent("");
            GetLesson("");
        }

        private void txtLessonSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            GetStudent(txtStudentSearch.Text);
        }

        private void txtLessonSearch_TextChanged_1(object sender, EventArgs e)
        {
            GetLesson(txtLessonSearch.Text);
        }

        private void dgLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var lessonId = Convert.ToInt32(dgLesson.CurrentRow.Cells[0].Value.ToString());

            var registers = db.Registers.Where(s => s.LessonId == lessonId).ToList();

            dgLessonStudent.Rows.Clear();
            foreach (var register in registers)
            {
                dgLessonStudent.Rows.Add(register.Id, register.Student.Number, register.Student.Name, register.Student.Email, register.Student.Phone);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var lessonId = Convert.ToInt32(dgLesson.CurrentRow.Cells[0].Value.ToString());
            var studentId = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value.ToString());

            var lessonName = dgLesson.CurrentRow.Cells[2].Value.ToString();
            var studentName = dgStudent.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show(studentName + " isimli öğrenciye " + lessonName + " dersi eklenecektir onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (db.Registers.Count(c => c.LessonId == lessonId && c.StudentId == studentId) > 0)
            {
                MessageBox.Show("Seçilen Öğrenci İlgli derse önceden kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var register = new Register();
            register.LessonId = lessonId;
            register.StudentId = studentId;
            register.Created = DateTime.Now;
            register.Updated = DateTime.Now;

            db.Registers.Add(register);
            db.SaveChanges();

            MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgStudentLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentId = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value.ToString());

            dgStudentLesson.Rows.Clear();
            var registers = db.Registers.Where(s => s.StudentId == studentId).ToList();
            foreach (var register in registers)
            {
                dgStudentLesson.Rows.Add(register.Id, register.Lesson.Code, register.Lesson.Name, register.Lesson.Credit);
            }
        }
    }
}

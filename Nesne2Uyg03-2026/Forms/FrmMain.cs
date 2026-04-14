using Nesne2Uyg03_2026.Forms;

namespace Nesne2Uyg03_2026
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        void OpenForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmStudent());
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmLesson());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRegister());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

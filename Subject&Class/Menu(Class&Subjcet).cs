namespace WFEND.Subject_Class
{
    public partial class Menu_Class_Subjcet_ : Form
    {
        public Menu_Class_Subjcet_()
        {
            InitializeComponent();
        }
        private void bt_Class_Click(object sender, EventArgs e)
        {
            p_Menux2.Visible = false;
            OpenChildForm(new DataShow("Class"));

        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Menu.Controls.Add(childForm);
            Menu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_subject_Click(object sender, EventArgs e)
        {
            p_Menux2.Visible = false;
            OpenChildForm(new DataShow("Subject"));
        }

        private void bt_ClasSubject_Click(object sender, EventArgs e)
        {
            p_Menux2.Visible = false;
            OpenChildForm(new WFEND.Subject_Class.ClassSubject());
        }
    }
}

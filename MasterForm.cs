using Microsoft.Data.SqlClient;
using System.Data;

namespace WFEND
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public string username;
        public string rank;
        public string classId;
        static string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";


        public Form1()
        {
            InitializeComponent();
            Instance = this;
            Customzedesign();
        }
        private void Customzedesign()
        {
            p_ministudents.Visible = false;
            p_minicourse.Visible = false;
            p_miniscore.Visible = false;
        }
        private void p_backLog_Paint(object sender, PaintEventArgs e)
        { }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Statistics());
            hidetaskbar();
            Option();
        }

        public void hidetaskbar()
        {
            if (p_ministudents.Visible == true) p_ministudents.Visible = false;
            if (p_minicourse.Visible == true) p_minicourse.Visible = false;
            if (p_miniscore.Visible == true) p_miniscore.Visible = false;
        }
        private void showtaskbar(Panel p_taskbar)
        {
            if (p_taskbar.Visible == false)
            {
                hidetaskbar();
                p_taskbar.Visible = true;
            }
            else
            {
                p_taskbar.Visible = false;
            }
        }

        // Big option
        private void b_students_Click(object sender, EventArgs e)
        {
            showtaskbar(p_ministudents);
        }
        private void b_students_MouseHover(object sender, EventArgs e)
        {
            b_students.BackColor = Color.FromArgb(39, 166, 155);
        }
        private void b_students_MouseLeave(object sender, EventArgs e)
        {
            b_students.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Teacher
        private void b_teacher_Click(object sender, EventArgs e)
        {
            showtaskbar(p_minicourse);
        }
        private void b_teacher_MouseHover(object sender, EventArgs e)
        {
            b_teacher.BackColor = Color.FromArgb(39, 166, 155);
        }
        private void b_teacher_MouseLeave(object sender, EventArgs e)
        {
            b_teacher.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Score
        private void b_score_Click(object sender, EventArgs e)
        {
            showtaskbar(p_miniscore);
        }
        private void b_score_MouseHover(object sender, EventArgs e)
        {
            b_score.BackColor = Color.FromArgb(39, 166, 155);
        }
        private void b_score_MouseLeave(object sender, EventArgs e)
        {
            b_score.BackColor = Color.FromArgb(38, 50, 56);
        }
        //Menu
        public void b_subject_Click(object sender, EventArgs e)
        {

        }
        private void b_subject_MouseHover(object sender, EventArgs e)
        {
            b_subject_Class.BackColor = Color.FromArgb(39, 166, 155);
        }

        private void b_subject_MouseLeave(object sender, EventArgs e)
        {
            b_subject_Class.BackColor = Color.FromArgb(38, 50, 56);
        }

        // MiniOption
        //students
        public void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataShow("Students"));
            hidetaskbar();
        }
        private void b_Managestudents_Click(object sender, EventArgs e)
        {
            hidetaskbar();
        }
        private void b_status_Click(object sender, EventArgs e)
        {
            hidetaskbar();
        }
        private void b_printStudents_Click(object sender, EventArgs e)
        {
            hidetaskbar();
        }

        //teacher
        private void b_newteacher_Click(object sender, EventArgs e)
        {
            hidetaskbar();
        }
        private void b_manageteacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataShow("Teacher"));
            hidetaskbar();
        }
        private void b_printteacher_Click(object sender, EventArgs e)
        {
            hidetaskbar();
        }

        //Score
        private void b_managescore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WFEND.Score.Score());
            hidetaskbar();
        }
        private void b_print_score_Click(object sender, EventArgs e)
        {
            hidetaskbar();
        }

        //Subject
        private void b_managesubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WFEND.Subject_Class.Menu_Class_Subjcet_());
            hidetaskbar();
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You Are Sure",
                "Uot System Student Manager",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void b_Exit_MouseHover(object sender, EventArgs e)
        {
            b_Exit.BackColor = Color.FromArgb(239, 80, 51);
        }
        private void b_Exit_MouseLeave(object sender, EventArgs e)
        {
            b_Exit.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Home
        private void b_home_MouseHover(object sender, EventArgs e)
        {
            b_home.BackColor = Color.FromArgb(39, 166, 155);
        }
        private void b_home_MouseLeave(object sender, EventArgs e)
        {
            b_home.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Menu Class - Subject
        private void b_subject_Class_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WFEND.Subject_Class.Menu_Class_Subjcet_());
            hidetaskbar();
        }
        private void b_subject_Class_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 166, 155);
        }
        private void b_subject_Class_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Attendance
        private void b_attendance_Click(object sender, EventArgs e)
        {
            Attendance _attendance = new Attendance(username);
            OpenChildForm(_attendance);
        }
        private void b_attendance_MouseHover(object sender, EventArgs e)
        {
            b_attendance.BackColor = Color.FromArgb(39, 166, 155);
        }

        private void b_attendance_MouseLeave(object sender, EventArgs e)
        {
            b_attendance.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Behavior
        private void b_Behavior_Click(object sender, EventArgs e)
        {
            var _behavior = new WFEND.Behavior.Behavior(username);
            OpenChildForm(_behavior);
        }
        private void b_Behavior_MouseHover(object sender, EventArgs e)
        {
            b_Behavior.BackColor = Color.FromArgb(39, 166, 155);
        }

        private void b_Behavior_MouseLeave(object sender, EventArgs e)
        {
            b_Behavior.BackColor = Color.FromArgb(38, 50, 56);
        }

        //Account
        private void bt_account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataShow("Users"));
        }
        private void bt_account_MouseHover(object sender, EventArgs e)
        {
            bt_account.BackColor = Color.FromArgb(39, 166, 155);
        }

        private void bt_account_MouseLeave(object sender, EventArgs e)
        {
            bt_account.BackColor = Color.FromArgb(38, 50, 56);
        }
        //Mini Screeen
        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void b_home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statistics());
            hidetaskbar();
        }

        // Phân quyền thao tác 
        private void Option()
        {
            if (rank != "GV") return;
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand("GetClassId", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", username);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string id = reader["ClassId"].ToString();
                string name = reader["NameClass"].ToString();
                classId = $"{id} {name}";
            }

            b_subject_Class.Visible = false;
            b_teacher.Visible = false;
            bt_account.Visible = false;
        }
    }
}

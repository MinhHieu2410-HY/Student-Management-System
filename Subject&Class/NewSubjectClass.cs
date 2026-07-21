using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using WFEND.Support;

namespace WFEND.Subject

{
    public partial class NewSubjectClass : Form
    {
        string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        private Action _refreshData;
        string form;
        Open _openInstance = new Open();

        public NewSubjectClass(string _form, Action refreshData)
        {
            InitializeComponent();
            form = _form;
            _refreshData = refreshData;
        }

        private void _Text()
        {
            if (form == "Class")
            {
                labelCus4.Text = "Add New Class";
                labelCus1.Text = "*Class Name";
                labelCus2.Text = "*Class Id";
                labelCus3.Text = "Academic Year Id";
                panel5.Visible = true;
                panel6.Visible = true;
            }
            else if (form == "Users")
            {
                labelCus4.Text = "Add Account";
                labelCus1.Text = "*Name Account";
                labelCus2.Text = "*Password";
                panel3.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                this.Size = new Size(836, 174);
            }
            else 
            {
                this.Size = new Size(836, 278);
            }
        }
        private void NewSubject_Load(object sender, EventArgs e)
        {
            _Text();
            string query;
            if (form == "Subject")
            {
                query = "SELECT NameGroup, TeacherGroupId FROM TeacherGroup";
                _openInstance.LoadComboBoxDataAsync(query, "TeacherGroupId", "NameGroup", cb_teachergroupid);
            }
            else
            {
                query = "SELECT AcademicYearId, YearStart FROM AcademicYear";
                _openInstance.LoadComboBoxDataAsync(query, "AcademicYearId", "YearStart", cb_teachergroupid);

                query = "SELECT TeacherId, FullName FROM Teacher";
                _openInstance.LoadComboBoxDataAsync(query, "TeacherId", "FullName", cb_homeroomTeacher);
            }
        }


        private void b_CloseRegi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_addnewsj_Click(object sender, EventArgs e)
        {
            if (form == "Subject")
            {
                addSubject();
            }
            else if (form == "Class")
            {
                addClass();
            }
            else
            {
                addAccount();
            }
        }

        private void addSubject()
        {
            try
            {
                string namesubject = tb_subjectname.Texts.Split(' ')[0]; 
                string Idsubject = t_subjectid.Texts.Split(' ')[0]; 
                string GroupId = cb_teachergroupid.Texts.Split(' ')[0]; 

                if (string.IsNullOrWhiteSpace(namesubject) || string.IsNullOrWhiteSpace(Idsubject) || string.IsNullOrWhiteSpace(GroupId))
                {
                    MessageBox.Show("Please enter all the required information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Subject (SubjectId, NameSubject, TeacherGroupId) VALUES (@SubjectId, @NameSubject, @TeacherGroupId)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectId", Idsubject);
                        cmd.Parameters.AddWithValue("@NameSubject", namesubject);
                        cmd.Parameters.AddWithValue("@TeacherGroupId", GroupId);
                        cmd.ExecuteNonQuery();
                    }
                }

                _refreshData?.Invoke(); // Cập nhật bảng sau khi thêm
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addClass()
        {
            try
            {
                if (!int.TryParse(textBoxCustom1.Texts, out int Grade) || Grade < 1 || Grade > 5)
                {
                    MessageBox.Show("Grade must be between 1 and 5.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO Class (ClassId, NameClass, AcademicYearId, Grade, HomeRoomTeacher) " +
                               "VALUES (@ClassId, @NameClass, @AcademicYearId, @Grade,@HomeRoomTeacher)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClassId", t_subjectid.Texts);
                        cmd.Parameters.AddWithValue("@NameClass", tb_subjectname.Texts);
                        cmd.Parameters.AddWithValue("@AcademicYearId", cb_teachergroupid.Texts.Split(' ')[0]);
                        cmd.Parameters.AddWithValue("@Grade", Grade);
                        cmd.Parameters.AddWithValue("@HomeRoomTeacher", cb_homeroomTeacher.Texts.Split(' ')[0]);
                        cmd.ExecuteNonQuery();
                    }
                }

                _refreshData?.Invoke();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addAccount()
        {
            try
            {
                string namesubject = tb_subjectname.Texts.Trim();
                string Idsubject = t_subjectid.Texts.Trim();

                if (string.IsNullOrWhiteSpace(namesubject) || string.IsNullOrWhiteSpace(Idsubject))
                {
                    MessageBox.Show("Please enter all the required information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "Insert into Users (UserName,Passwords,Rank)"+" Values (@UserName,@Passwords,@Rank)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Idsubject);
                        cmd.Parameters.AddWithValue("@Passwords", namesubject);
                        cmd.Parameters.AddWithValue("@Rank", "GV");
                        cmd.ExecuteNonQuery();
                    }
                }

                _refreshData?.Invoke(); // Cập nhật bảng sau khi thêm
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

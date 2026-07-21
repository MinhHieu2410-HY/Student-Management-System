using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;

namespace WFEND
{
    public partial class Register : Form
    {
        static string ConnectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";

        private string _parameter;
        private readonly Open _openInstance = new Open();

        private readonly Action _onSuccessCallback;

        public Register()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public Register(string parameter, Action onSuccessCallback)
        {
            InitializeComponent();
            this.Load += new EventHandler(Register_Load);
            LoadingDistinctive(parameter);
            _parameter = parameter;
            _onSuccessCallback = onSuccessCallback;
        }

        private void LoadingDistinctive(string Name)
        {
            if (Name != "Students")
            {
                labelClass.Text = "Teacher Group Id";
            }
        }

        private async void Register_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            pe_StudentProfile.Image = Properties.Resources.AddUser;

            string query = _parameter switch
            {
                "Students" => "SELECT ClassId, NameClass FROM Class",
                "Teacher" => "SELECT TeacherGroupId, NameGroup FROM TeacherGroup",
                _ => null
            };

            if (query != null)
                await _openInstance.LoadComboBoxDataAsync(query, _parameter == "Students" ? "ClassId" : "TeacherGroupId", _parameter == "Students" ? "NameClass" : "NameGroup", CB_Class);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void b_CloseRegi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string imgsource;

        private void pe_StudentProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                imgsource = opf.FileName;
                pe_StudentProfile.Image = Image.FromFile(imgsource);
            }
        }

        private void b_AddNewStudents_Click(object sender, EventArgs e)
        {
            string fullname = tB_FullName.Texts;
            string ageText = tB_Age.Texts;
            string ParentPhone = tB_Phone.Texts.Trim();
            DateTime birthday = DT_birthday.Value.Date;
            string gender = Ro_Male.Checked ? "male" : "female";
            string classroom = CB_Class.Texts.Split()[0];
            string address = tB_Address.Texts;
            string Gmail = tB_Gmail.Texts;

            byte[] imageData;
            try
            {
                imageData = File.ReadAllBytes(imgsource);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading image file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_parameter == "Students")
            {
                if (InsertStudent(fullname, ageText, ParentPhone, birthday, gender, classroom, address, imageData, Gmail))
                {
                    MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _onSuccessCallback?.Invoke();
                    Close();
                }
            }
            else
            {
                if (InsertTeacher(fullname, ageText, ParentPhone, birthday, gender, classroom, address, imageData, Gmail))
                {
                    label1.Text = "Add New Teacher";
                    MessageBox.Show("Teacher added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _onSuccessCallback?.Invoke();
                    Close();
                }
            }
        }

        private bool InsertStudent(string fullname, string ageText, string parentPhone, DateTime birthday, string gender, string classId, string address, byte[] profilePicture, string gmail)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                    INSERT INTO Students 
                    (FullName, Age, ParentPhone, Birthday, Gender, ClassId, Address, ProfilePicture, Gmail)
                    VALUES 
                    (@FullName, @Age, @ParentPhone, @Birthday, @Gender, @ClassId, @Address, @ProfilePicture, @Gmail)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullname);
                        cmd.Parameters.AddWithValue("@Age", ageText);
                        cmd.Parameters.AddWithValue("@ParentPhone", parentPhone);
                        cmd.Parameters.AddWithValue("@Birthday", birthday);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@ClassId", classId);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@ProfilePicture", profilePicture);
                        cmd.Parameters.AddWithValue("@Gmail", string.IsNullOrWhiteSpace(gmail) ? DBNull.Value : gmail);

                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool InsertTeacher(string fullname, string ageText, string ParentPhone, DateTime birthday, string gender, string classroom, string address, byte[] imageData, string Gmail)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "INSERT INTO Teacher(FullName, Age, Phone, Birthday, Gender, TeacherGroupId, Address, ProfilePicture, Gmail) VALUES (@FullName, @Age, @ParentPhone, @Birthday, @Gender, @TeacherGroupId, @Address, @ProfilePicture, @Gmail)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullname);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(ageText));
                    cmd.Parameters.AddWithValue("@ParentPhone", ParentPhone);
                    cmd.Parameters.AddWithValue("@Birthday", birthday);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@TeacherGroupId", classroom);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@ProfilePicture", imageData);
                    cmd.Parameters.AddWithValue("@Gmail", string.IsNullOrWhiteSpace(Gmail) ? DBNull.Value : Gmail);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private void DT_birthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDay = DT_birthday.Value;
            DateTime today = DateTime.Now;
            int age = today.Year - birthDay.Year;
            if (birthDay > today.AddYears(-age))
            {
                age--;
            }
            tB_Age.Texts = age.ToString();
        }
    }
}

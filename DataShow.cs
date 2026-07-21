using Microsoft.Data.SqlClient;
using System.Globalization;
using WFEND.Subject;


namespace WFEND
{
    public partial class DataShow : Form
    {
        Open _openInstance = new Open();
        static string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";

        string rank = Form1.Instance.rank;
        string classid = Form1.Instance.classId;
        string dataform;

        // Constructor nhận tham số để xác định loại dữ liệu cần hiển thị
        public DataShow(string dataformin)
        {
            InitializeComponent();
            dataform = dataformin;
            if (dataform == "Users")
            {
                B_Print.Visible = false;
            }
        }

        // Hiển thị dữ liệu và đặt tiêu đề
        private void DataShow_Load(object sender, EventArgs e)
        {
            if (rank == "AD")
            {
                IsAdmin();
            }
            else if (rank == "GV")
            {
                Isteacher();
            }
            l_text.Text = dataform switch
            {
                "Students" => "Manager Students",
                "Teacher" => "Manager Teacher",
                "Subject" => "Manager Subject",
                "Class" => "Manager Class",
                "Users" => "Manager Account",
                _ => "Manager Data"
            };
        }
        //Thay đổi nếu là admin
        private void IsAdmin()
        {
            if (dataform == "Class")
            {
                _openInstance.tabelname(dataform, data_Show, "Exec GetClass");
            }
            else if (dataform == "Students")
            {
                _openInstance.tabelname(dataform, data_Show, "Exec GetStudents");
            }
            else if (dataform == "Teacher")
            {
                _openInstance.tabelname(dataform, data_Show, "Exec GetTeacher");
            }
            else if (dataform == "Subject")
            {
                _openInstance.tabelname(dataform, data_Show, "Exec GetSubject");
            }
            else if (dataform == "Account")
            {
                _openInstance.tabelname(dataform, data_Show, "Exec GetAccount");
            }
            else
            {
                _openInstance.tabelname(dataform, data_Show);
            }
        }

        //Thay đổi nếu là giáo viên
        private void Isteacher()
        {
            _openInstance.tabelname(dataform, data_Show, $"EXEC GetStudents @ClassId = '{classid.Split()[0]}'");
            B_Add.Visible = false;
        }

        // Thay đổi add với mỗi form
        private void B_Add_Click(object sender, EventArgs e)
        {
            Form registerForm = dataform switch
            {
                "Students" => new Register("Students", LoadStudentData),
                "Teacher" => new Register("Teacher", LoadTeacherData),
                "Subject" => new NewSubjectClass("Subject", ReloadTable),
                "Class" => new NewSubjectClass("Class", ReloadTable),
                "Users" => new NewSubjectClass("Users", ReloadTable),
                _ => null
            };

            registerForm?.ShowDialog();
        }

        private void LoadStudentData()
        {
            _openInstance.tabelname(dataform, data_Show, "Exec GetStudents");
        }

        private void LoadTeacherData()
        {
            _openInstance.tabelname(dataform, data_Show, "Exec GetTeacher");
        }

        // Hàm cập nhật lại bảng sau khi thêm dữ liệu
        private void ReloadTable()
        {
            _openInstance.tabelname(dataform, data_Show);
        }


        // Double click để chuyển sang việc cập nhập
        private void data_Show_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataform != "Subject" && dataform != "Class" && dataform != "Users")
            {
                _openInstance.CellMouseDoubleClick(sender, e, data_Show, dataform);
            }
        }

        // Chuyển lại sau khi nhấn enter (chỉ nhìn)
        private void data_Show_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            data_Show.ReadOnly = true;
        }

        // Thay đổi giá trị trong bảng
        private void data_Show_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataform != "Subject" && dataform != "Class")
            {
                _openInstance.CellValueChanged(sender, e, dataform, data_Show, ValidateValueMethod);
            }
        }

        // Kiểm Tra Điều Kiện
        private bool ValidateValueMethod(string columnName, string value, out string errorMessage)
        {
            errorMessage = string.Empty;

            switch (columnName)
            {
                case "FullName":
                    if (string.IsNullOrWhiteSpace(value) || value.Length > 100 || System.Text.RegularExpressions.Regex.IsMatch(value, "[^a-zA-Zs]"))
                    {
                        errorMessage = "Full name must be less than 100 characters and not contain special characters.";
                        return false;
                    }
                    break;
                case "TeacherGroup":
                case "ClassName":
                    return true;
                case "Phone":
                case "ParentPhone":
                    if (value.Length != 10 || !value.All(char.IsDigit) || value[0] != '0')
                    {
                        errorMessage = "Phone number must be exactly 10 digits and start with 0.";
                        return false;
                    }
                    break;

                case "Birthday":
                    // Kiểm tra tuổi giáo viên
                    if (!DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthday))
                    {
                        errorMessage = "Date of birth must be in the format dd/MM/yyyy.";
                        return false;
                    }

                    if (birthday.Year < 1920 || birthday > DateTime.Today)
                    {
                        errorMessage = "Date of birth must be between the year 1920 and today.";
                        return false;
                    }

                    int age = DateTime.Today.Year - birthday.Year;
                    if (birthday > DateTime.Today.AddYears(-age)) age--;

                    // Kiểm tra Học sinh
                    if (dataform == "Students" && age < 5)
                    {
                        errorMessage = "Student must be at least 5 years old.";
                        return false;
                    }
                    else if (dataform == "Teacher" && age < 18)
                    {
                        errorMessage = "Teacher must be at least 18 years old.";
                        return false;
                    }
                    break;

                case "Gender":
                    if (!string.Equals(value, "Male", StringComparison.OrdinalIgnoreCase) &&
                        !string.Equals(value, "Female", StringComparison.OrdinalIgnoreCase))
                    {
                        errorMessage = "Invalid gender. Please specify 'Male' or 'Female'.";
                        return false;
                    }
                    break;

                case "Gmail":
                    if (!System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-zA-Z0-9._%+-]+@gmail\\.com$"))
                    {
                        errorMessage = "Please provide a valid Gmail address.";
                        return false;
                    }
                    break;
                case "Address":
                    return true;
                default:
                    errorMessage = "You cannot change the value of this column.";
                    return false;
            }
            return true;
        }

        private object SelectId;

        // Lấy Id 
        private void data_Show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = data_Show.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    data_Show.ClearSelection();
                    data_Show.Rows[hitTestInfo.RowIndex].Selected = true;

                    var cellValue = data_Show.Rows[hitTestInfo.RowIndex].Cells[0].Value;
                    SelectId = int.TryParse(cellValue?.ToString(), out int id) ? id : cellValue?.ToString();

                    contextMenuStrip1.Show(data_Show, e.Location);
                }
            }
        }

        // Xóa dữ liệu
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data_Show.SelectedRows.Count > 0 && SelectId != null)
            {
                string tableName = dataform;
                string keyColumn = dataform == "Students" ? "Id"
                 : dataform == "Subject" ? "SubjectId"
                 : dataform == "Class" ? "ClassId"
                 : dataform == "Users" ? "UserName"
                 : "TeacherId";

                if (MessageBox.Show($"Are you sure you want to delete this record from {tableName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"DELETE FROM {tableName} WHERE {keyColumn} = @KeyValue;";
                    ExecuteQuery(query, new Dictionary<string, object> { { "@KeyValue", SelectId } });
                    if (dataform == "Class")
                    {
                        _openInstance.tabelname(dataform, data_Show, "Exec GetClass");
                    }
                    else if (dataform == "Students")
                    {
                        _openInstance.tabelname(dataform, data_Show, "Exec GetStudents");
                    }
                    else if (dataform == "Teacher")
                    {
                        _openInstance.tabelname(dataform, data_Show, "Exec GetTeacher");
                    }
                    else if (dataform == "Subject")
                    {
                        _openInstance.tabelname(dataform, data_Show, "Exec GetSubject");
                    }
                    else if (dataform == "Account")
                    {
                        _openInstance.tabelname(dataform, data_Show, "Exec GetAccount");
                    }
                    else
                    {
                        _openInstance.tabelname(dataform, data_Show);
                    }
                }
            }
        }
        // Tìm kiếm
        private void Search_Click(object sender, EventArgs e)
        {
            string searchValue = textBox2.Text;
            string tableName = dataform;

            Open openInstance = new Open();
            openInstance.SearchData(tableName, searchValue, data_Show);
        }

        // Thực thi truy vấn SQL với tham số an toàn
        private void ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                        command.Parameters.AddWithValue(param.Key, param.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void B_Print_Click(object sender, EventArgs e)
        {
            P_Export.Visible = true;
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            P_Export.Visible = false;
        }
        string buttonSelected;
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            buttonSelected = clickedButton.Name;
        }
        
        private void B_accept_Click(object sender, EventArgs e)
        {
            var data = _openInstance.GetDataFromGrid(data_Show);
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data available to export.");
                return;
            }

            string fileType = buttonSelected?.ToLower();
            Action export = fileType switch
            {
                "csv" => () => _openInstance.ExportToCSV(data, P_Export),
                "xls" => () => _openInstance.ExportToExcel(data, P_Export),
                "docx" => () => _openInstance.ExportToWord(data, P_Export),
                "pdf" => () => _openInstance.ExportToPDF(data, P_Export),
                _ => null
            };

            if (export != null)
                export();
            else
                MessageBox.Show("Please select a valid file type to export.");
        }
    }
}

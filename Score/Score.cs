using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WFEND.Score
{
    public partial class Score : Form
    {
        private const string ConnectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        private readonly Open _openInstance = new Open();
        private System.Windows.Forms.Timer timer;
        string rank = Form1.Instance.rank;
        string classid = Form1.Instance.classId;
        string query;

        public Score()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += ChangeSize_Tick; ;
        }

        public void ScoreReload()
        {
            if (rank == "GV")
            {
                query = $"EXEC GetStudentScores @ClassId = '{classid.Split()[0]}';";
                LoadStudentScores(query);

                CB_Class.Items.Clear();
                CB_Class.Texts = $"{classid}";
                CB_Class.Items.Add($"{classid}");
            }
            else
            {
                query = "EXEC GetStudentScores;";
                LoadStudentScores(query);
            }
        }

        private void Score_Load(object sender, EventArgs e)
        {
            if (rank == "GV")
            {
                query = $"EXEC GetStudentScores @ClassId = '{classid.Split()[0]}';";
                LoadStudentScores(query);

                CB_Class.Items.Clear();
                CB_Class.Texts = $"{classid}";
                CB_Class.Items.Add($"{classid}");
            }
            else
            {
                query = "EXEC GetStudentScores;";
                LoadStudentScores(query);
            }
        }

        public void LoadStudentScores(string query)
        {
            using (var con = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                var table = new DataTable();
                con.Open();
                table.Load(cmd.ExecuteReader());
                data_Show.DataSource = table;

                data_Show.Columns["SubjectId"].Visible = false;
                data_Show.Columns["SemesterId"].Visible = false;
                data_Show.Columns["StudentId"].Visible = false;

                foreach (DataGridViewColumn column in data_Show.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void b_new_Click(object sender, EventArgs e)
        {
            var scorenew = new ScoreNew(this);
            scorenew.ShowDialog();
        }

        private void data_Show_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            _openInstance.CellMouseDoubleClick(sender, e, data_Show, "Score");
        }

        private void data_Show_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            data_Show.ReadOnly = true;
        }

        private void data_Show_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var newValue = data_Show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            var columnName = data_Show.Columns[e.ColumnIndex].HeaderText;

            var studentId = data_Show.Rows[e.RowIndex].Cells["StudentId"].Value.ToString();
            var subjectId = data_Show.Rows[e.RowIndex].Cells["SubjectId"].Value.ToString();
            var semesterId = data_Show.Rows[e.RowIndex].Cells["SemesterId"].Value.ToString();

            if (ValidateValue(columnName, newValue, out string errorMessage) &&
                int.TryParse(studentId, out int studentIdInt))
            {
                UpdateScore(columnName, newValue, studentIdInt, subjectId, semesterId);
            }
            else
            {
                ShowError(errorMessage ?? "Invalid StudentId format.");
            }
        }

        private bool ValidateValue(string columnName, string value, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(value))
            {
                errorMessage = "Value cannot be empty.";
                return false;
            }
            if (columnName.Equals("Score", StringComparison.OrdinalIgnoreCase) &&
                !decimal.TryParse(value, out _))
            {
                errorMessage = "Value Invalid. Must be a number.";
                return false;
            }
            return true;
        }

        private void UpdateScore(string column, string value, int studentId, string subjectId, string semesterId)
        {
            if (!float.TryParse(value, out float floatValue) || floatValue < 0 || floatValue > 10)
            {
                MessageBox.Show("Change Value Error!");
                ScoreReload();
                return;
            }

            const string query = "UPDATE Score SET {0} = @Value WHERE StudentsId = @StudentsId AND SubjectId = @SubjectId AND SemesterId = @SemesterId";

            ExecuteNonQuery(string.Format(query, column), new SqlParameter("@Value", value),
                new SqlParameter("@StudentsId", studentId),
                new SqlParameter("@SubjectId", subjectId),
                new SqlParameter("@SemesterId", semesterId));
            ScoreReload();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int StudentId;
        private string subjectId;
        private string semesterId;

        private void data_Show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = data_Show.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    data_Show.ClearSelection();
                    data_Show.Rows[hitTestInfo.RowIndex].Selected = true;

                    StudentId = Convert.ToInt32(data_Show.Rows[hitTestInfo.RowIndex].Cells["StudentId"].Value);
                    subjectId = data_Show.Rows[hitTestInfo.RowIndex].Cells["SubjectId"].Value.ToString();
                    semesterId = data_Show.Rows[hitTestInfo.RowIndex].Cells["SemesterId"].Value.ToString();

                    contextMenuStrip1.Show(data_Show, e.Location);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (StudentId > 0)
            {
                string query = "DELETE FROM Score WHERE StudentsId = @StudentsId AND SubjectId = @SubjectId AND SemesterId = @SemesterId";
                var dialogResult = MessageBox.Show("Do you want to delete this?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    ExecuteNonQuery(query,
                        new SqlParameter("@StudentsId", StudentId),
                        new SqlParameter("@SubjectId", subjectId),
                        new SqlParameter("@SemesterId", semesterId));

                    query = "EXEC GetStudentScores;";
                    LoadStudentScores(query);
                }
            }
        }

        private void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var con = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddRange(parameters);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ShowError($"Error executing command: {ex.Message}");
                }
            }
        }
        private const int MinHeight = 740;
        private int targetHeight;
        private bool isShrinking = true;

        private void Search_Click(object sender, EventArgs e)
        {
            if (isShrinking)
            {
                targetHeight = MinHeight;
            }
            else
            {
                targetHeight = 787;
            }
            timer.Start();
        }
        private void ChangeSize_Tick(object sender, EventArgs e)
        {
            if (isShrinking && p_data.Height > targetHeight)
            {
                p_data.Height -= 3;
                p_data.Top += 3;
            }
            else if (!isShrinking && p_data.Height < targetHeight)
            {
                p_data.Height += 3;
                p_data.Top -= 3;
            }
            else
            {
                timer.Stop();
                cb_value();
                isShrinking = !isShrinking;
            }
        }
        private async void cb_value()
        {
            var comboBoxConfigs = new[]
            {
        new { Query = "SELECT ClassId, NameClass FROM Class", Display = "ClassId", Value = "NameClass", ComboBox = CB_Class },
        new { Query = "SELECT SubjectId, NameSubject FROM Subject", Display = "SubjectId", Value = "NameSubject", ComboBox = cb_subject },
        new { Query = "SELECT SemesterId, NameSemester FROM Semester", Display = "SemesterId", Value = "NameSemester", ComboBox = cb_semester }
            };

            foreach (var config in comboBoxConfigs)
            {
                await _openInstance.LoadComboBoxDataAsync(config.Query, config.Display, config.Value, config.ComboBox);
            }
        }

        private void radiusButton2_Click(object sender, EventArgs e)
        {
            var searchParams = new Dictionary<string, string>
        {
        { "@SearchTerm", tb_Search.Texts.Trim() },
        { "@NameSemester", cb_semester.Texts.Trim().Split()[0] },
        { "@NameSubject", cb_subject.Texts.Trim().Split()[0] },
        { "@ClassId", CB_Class.Texts.Trim().Split()[0] }
        };

            string query = BuildQuery(searchParams);
            LoadStudentScores(query);
        }
        private string BuildQuery(Dictionary<string, string> parameters)
        {
            var queryParts = new List<string> { "EXEC GetStudentScores" };

            var paramList = parameters
                .Where(p => !string.IsNullOrEmpty(p.Value))
                .Select(p => $"{p.Key} = N'{p.Value}'");

            if (paramList.Any())
            {
                queryParts.Add(string.Join(", ", paramList));
            }
            else
            {
                queryParts.Add("@SearchTerm = NULL, @NameSemester = NULL, @NameSubject = NULL, @ClassId = NULL");
            }

            return string.Join(" ", queryParts);
        }
        private void B_Print_Click(object sender, EventArgs e)
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
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
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
        private void B_Reset_Click(object sender, EventArgs e)
        {
            LoadStudentScores("EXEC GetStudentScores;");
            tb_Search.Texts = CB_Class.Texts = cb_subject.Texts = cb_semester.Texts = string.Empty;
        }
    }
}


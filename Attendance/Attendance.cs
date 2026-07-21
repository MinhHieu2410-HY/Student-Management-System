using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WFEND
{
    public partial class Attendance : Form
    {
        private readonly Open _openInstance = new Open();
        private static readonly string ConnectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        public string Username;

        public Attendance(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            ComboValue();
        }

        private async Task ComboValue()
        {
            string rank = Form1.Instance.rank;
            string classid = Form1.Instance.classId;
            var comboBoxQueries = new[]
            {
        new { Query = "SELECT ClassId, NameClass FROM Class", Display = "ClassId", Value ="NameClass", ComboBox = CB_Class },
        new { Query = "SELECT SubjectId, NameSubject FROM Subject", Display = "SubjectId", Value = "NameSubject", ComboBox = Cb_subject }
            };
            foreach (var item in comboBoxQueries)
            {
                await _openInstance.LoadComboBoxDataAsync(item.Query, item.Display, item.Value, item.ComboBox);
            }
            if (rank == "GV")
            {
                CB_Class.Items.Clear();
                CB_Class.Texts = $"{classid}";
                CB_Class.Items.Add($"{classid}");
            }
        }


        private void LoadAttendanceData(string classId, string subjectId, DateTime date)
        {
            string session = cb_session.Texts;

            using var connection = new SqlConnection(ConnectionString);
            using var command = new SqlCommand("CreateAttendance", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@ClassId", classId);
            command.Parameters.AddWithValue("@SubjectId", subjectId);
            command.Parameters.AddWithValue("@Session", session);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@NameCreate", Username);

            try
            {
                connection.Open();
                using var adapter = new SqlDataAdapter(command);
                var attendanceTable = new DataTable();
                adapter.Fill(attendanceTable);
                data_Show.DataSource = attendanceTable;

                data_Show.Columns["StudentId"].Visible = false;
                data_Show.Columns["ClassId"].Visible = false;
                data_Show.Columns["SubjectId"].Visible = false;
                data_Show.Columns["NameCreate"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Data: {ex.Message}");
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            string classId = CB_Class.Texts.Split()[0];
            string subjectId = Cb_subject.Texts.Split()[0];
            DateTime date = DT_date.Value;

            using var connection = new SqlConnection(ConnectionString);
            using var command = new SqlCommand("CreateAttendance", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@ClassId", classId);
            command.Parameters.AddWithValue("@SubjectId", subjectId);
            command.Parameters.AddWithValue("@Session", cb_session.Texts);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@NameCreate", Username);

            bt_delete.Visible = true;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                LoadAttendanceData(classId, subjectId, date);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void data_Show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsEditableColumn(e.ColumnIndex))
            {
                data_Show.ReadOnly = false;
            }
        }

        private bool IsEditableColumn(int columnIndex)
        {
            string columnName = data_Show.Columns[columnIndex].HeaderText;
            return columnName != "Fullname" && columnName != "NameClass" && columnName != "NameSubject" && columnName != "Session" && columnName != "Date";
        }

        private void data_Show_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            data_Show.ReadOnly = true;
        }
        private async void data_Show_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            try
            {
                var status = data_Show.Rows[e.RowIndex].Cells["Status"].Value?.ToString();
                var notes = data_Show.Rows[e.RowIndex].Cells["Notes"].Value?.ToString();
                if (!int.TryParse(data_Show.Rows[e.RowIndex].Cells["StudentId"].Value?.ToString(), out int studentId))
                {
                    MessageBox.Show("Cannot retrieve Student ID. Please check the value.");
                    return;
                }

                var classId = CB_Class.Texts.Split(' ')[0].Trim();
                var subjectId = Cb_subject.Texts.Split(' ')[0].Trim();
                var session = cb_session.Texts;
                var date = DT_date.Value;

                await UpdateAttendanceStatusAsync(classId, subjectId, session, date, studentId, status, notes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while processing data: " + ex.Message);
            }
        }

        private async Task UpdateAttendanceStatusAsync(string classId, string subjectId, string session, DateTime date, int studentsId, string status, string notes)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = new SqlCommand("UpdateStatusNotes", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@ClassId", classId);
            command.Parameters.AddWithValue("@SubjectId", subjectId);
            command.Parameters.AddWithValue("@Session", session);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@NameCreate", Username);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@StudentId", studentsId);
            command.Parameters.AddWithValue("@Notes", notes);

            try
            {
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string nameCreate = Username;
            string classId = CB_Class.Texts.Split()[0];
            DateTime date = DT_date.Value;
            string session = cb_session.Texts;

            DeleteAttendance(nameCreate, session, date, classId);
        }
        private void DeleteAttendance(string nameCreate, string session, DateTime date, string classId)
        {
            DialogResult dialogResult = MessageBox.Show(
                   "Are you sure you want to delete this attendance record?",
                   "Confirm Deletion",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
               );

            if (dialogResult == DialogResult.Yes)
            {
                using var connection = new SqlConnection(ConnectionString);
                using var command = new SqlCommand("DeleteAttendance", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@NameCreate", nameCreate);
                command.Parameters.AddWithValue("@Session", session);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@ClassId", classId);

                try
                {
                    connection.Open();
                    int rowsAffected = (int)command.ExecuteScalar();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendance record deleted successfully.");
                        data_Show.Columns.Clear();
                        data_Show.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No records found to delete.");
                    }
                }
                catch (SqlException sqlEx)
                {

                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("Deletion cancelled.");
            }
        }
    }
}

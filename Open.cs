using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using PdfSharpCore.Drawing;
using System.Data;
using System.Globalization;
using WFEND.Support;
using Xceed.Words.NET;
using PdfSharpCore.Pdf;

namespace WFEND
{
    public class Open
    {
        static string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        public class ComboBoxItem
        {
            public string Display { get; set; }
            public string Value { get; set; }
            public override string ToString() => Display;
        }

        /* Lấy danh sách $$$ */
        public void tabelname(string tablename, DataGridView data_Show, string queryCustom = null)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query;

                if (!string.IsNullOrEmpty(queryCustom))
                {
                    query = queryCustom;
                }
                else
                {
                    switch (tablename.ToLower())
                    {
                        case "students":
                            query = "EXEC GetStudents";
                            break;
                        case "teacher":
                            query = "EXEC GetTeacher";
                            break;
                        case "class":
                            query = "EXEC GetClass";
                            break;
                        case "subject":
                            query = "EXEC GetSubject";
                            break;
                        default:
                            query = $"SELECT * FROM {tablename}";
                            break;
                    }
                }
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            data_Show.DataSource = table;

                            foreach (DataGridViewColumn column in data_Show.Columns)
                            {
                                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                                if (column.Name == "ID" || column.Name == "StudentId" || column.Name == "TeacherId" || column.Name == "TeacherGroupId"
                                    || column.Name == "SubjectId" || column.Name == "ClassId" || column.Name == "LogId" || column.Name == "HomeRoomTeacher"
                                    || column.Name == "Rank")
                                {
                                    column.Visible = false;
                                }
                            }

                            cusdatagridview(tablename, data_Show);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        /* Thay đổi ngoài */
        static void cusdatagridview(string table, DataGridView data_show)
        {
            switch (table)
            {
                case "teacher":
                    data_show.Columns[0].Width = 110;
                    data_show.Columns[2].Width = 110;
                    break;
                case "Students":
                    break;
            }
        }

        /* delete data */
        public void DeleteData(string query)
        {
            DialogResult dialogResult = MessageBox.Show(
                               $"Do you want to delete this ?",
                               "Confirm delete",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close() ;
                }
            }
        }

        /* Search */
        public void SearchData(string tableName, string searchValue, DataGridView dataGrid)
        {
            string rank = Form1.Instance.rank;

            using var con = new SqlConnection(connectionString);
            con.Open();

            using var cmd = new SqlCommand("SearchData", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@TableName", tableName);
            cmd.Parameters.AddWithValue("@TimKiem", searchValue);

            // So sánh đúng và kiểm tra an toàn
            if (rank == "GV")
            {
                string classid = Form1.Instance.classId;
                string[] parts = classid.Split();
                if (parts.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@ClassId", parts[0]);
                }
            }

            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            dataGrid.DataSource = table;

            // Ẩn cột nếu là bảng ClassSubject
            if (tableName == "ClassSubject")
            {
                if (dataGrid.Columns.Contains("ClassId"))
                    dataGrid.Columns["ClassId"].Visible = false;
                if (dataGrid.Columns.Contains("SubjectId"))
                    dataGrid.Columns["SubjectId"].Visible = false;
            }
        }


        /* Sưa dữ liệu */
        public delegate bool ValidateValueDelegate(string columnName, string value, out string errorMessage);
        public void CellValueChanged(object sender, DataGridViewCellEventArgs e, string table, DataGridView dataGrid, ValidateValueDelegate validateValue)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var newValue = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var value = newValue != null ? newValue.ToString() : string.Empty;

                int columnIndex = e.ColumnIndex;
                string columnName = dataGrid.Columns[columnIndex].HeaderText;

                var idValue = dataGrid.Rows[e.RowIndex].Cells[0].Value;
                int id = idValue != null ? Convert.ToInt32(idValue) : 0;

                if (validateValue(columnName, value, out string errorMessage))
                {
                    ChangeDataGridView(table, columnName, value, id , dataGrid);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabelname(table , dataGrid);
                }
            }
        }
        private void ChangeDataGridView(string table, string columnName, string value, int id, DataGridView dataGrid)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DateTime birthdayDate = DateTime.MinValue;
                int age = 0;

                // Xử lý trường ngày sinh
                if (columnName == "Birthday" && DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdayDate))
                {
                    age = DateTime.Now.Year - birthdayDate.Year;
                    if (DateTime.Now < birthdayDate.AddYears(age))
                        age--;
                }

                // Xác định tên procedure và query dựa trên bảng
                string procedureName;
                string query;
                (procedureName, query) = table switch
                {
                    "Students" => ("UpdateStudent", "Exec GetStudents"),
                    "Teacher" => ("UpdateTeacher", "Exec GetTeacher"),
                    _ => throw new ArgumentException("Tên bảng không hợp lệ")
                };

                using (SqlCommand cmd = new SqlCommand(procedureName, con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số ID và các tham số khác cho stored procedure
                        if (table == "Students")
                        {
                            cmd.Parameters.AddWithValue("@ID", id);
                        }
                        else if (table == "Teacher")
                        {
                            cmd.Parameters.AddWithValue("@TeacherId", id);
                        }

                        cmd.Parameters.AddWithValue("@ColumnName", columnName);
                        cmd.Parameters.AddWithValue("@Value", value);

                        // Nếu là trường ngày sinh, thêm ngày sinh và tuổi
                        if (columnName == "Birthday")
                        {
                            cmd.Parameters.AddWithValue("@Birthday", birthdayDate);
                            cmd.Parameters.AddWithValue("@Age", age);
                        }

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi chi tiết
                        MessageBox.Show($"Lỗi: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Có thể ghi log lỗi (ví dụ vào file hoặc log sự kiện)
                        // LogError(ex);
                    }
                }

                // Tải lại dữ liệu cho DataGridView sau khi cập nhật
                tabelname(table, dataGrid, query); // Truyền query để làm mới dữ liệu
            }
        }

        /* Xác định cột nào được sửa */
        public void CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e, DataGridView dataGrid , string table)
        {

            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            string columnName = dataGrid.Columns[columnIndex].HeaderText;
            if(rowIndex >= 0)
            {
                if (columnName != "ID" && columnName != "Age" && columnName != "TeacherId" &&  columnName != "StudentId" && columnName != "Fullname"  && columnName != "NameSubject" && columnName != "NameSemester" && columnName != "AverageScore" )
                {
                    dataGrid.ReadOnly = false;
                }

                if (columnName == "ProfilePicture")
                {
                    var studentId = dataGrid.Rows[rowIndex].Cells[0].Value;
                    string IdSelect = Convert.ToString(studentId);

                    ShowImage showImageForm = new ShowImage(IdSelect, dataGrid , table);
                    showImageForm.Show();
                }
            }
        }
        /* giá trị combobox */
        public async Task LoadComboBoxDataAsync(string query, string displayColumn, string valueColumn, ComboCus combo)
        {
            combo.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No data found.");
                            return;
                        }
                        while (await reader.ReadAsync())
                        {
                            var item = new ComboBoxItem
                            {
                                Display = $"{reader[displayColumn]}  {reader[valueColumn]}",
                                Value = reader[valueColumn].ToString()
                            };
                            bool exists = combo.Items.Cast<ComboBoxItem>().Any(i => i.Value == item.Value);
                            if (!exists)
                            {
                                combo.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void LoadData(string procedureName, DataGridView grid)
        {
            using var con = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(procedureName, con) { CommandType = CommandType.StoredProcedure };
            var dt = new DataTable();
            con.Open();
            dt.Load(cmd.ExecuteReader());
            grid.DataSource = dt;

            foreach (var col in new[] { "ClassId", "SubjectId" })
                if (grid.Columns.Contains(col)) grid.Columns[col].Visible = false;

            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        public void RuncodeSql(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Run Code SQL: {ex.Message}");
                }
            }
        }
        //lấy dữ liệu trước export
        public List<string[]> GetDataFromGrid(DataGridView dataGridView)
        {
            var data = new List<string[]>();

            // Lấy tên cột
            var headers = new string[dataGridView.Columns.Count - 1];
            for (int i = 1; i < dataGridView.Columns.Count; i++)
            {
                headers[i - 1] = dataGridView.Columns[i].HeaderText;
            }
            data.Add(headers);

            // Lấy dữ liệu từng dòng
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var values = new string[dataGridView.Columns.Count - 1];
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        values[i - 1] = row.Cells[i].Value?.ToString();
                    }
                    data.Add(values);
                }
            }

            return data;
        }
        /* File Csv */
        public void ExportToCSV(List<string[]> data, Control Panel)
        {
            using var sfd = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sfd.FileName, data.Select(row => string.Join(",", row)));
            }
            Panel.Visible = false;
        }

        /* File Excel */
        public void ExportToExcel(List<string[]> data, Control Panel)
        {
            if (data?.Count == 0) return;

            using var sfd = new SaveFileDialog { Filter = "Excel (*.xlsx)|*.xlsx" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Data");
            for (int i = 0; i < data.Count; i++)
                for (int j = 0; j < data[i].Length; j++)
                    ws.Cell(i + 1, j + 1).Value = data[i][j];

            wb.SaveAs(sfd.FileName);
            Panel.Visible = false;
        }

        /* File Word */
        public void ExportToWord(List<string[]> data, Control Panel)
        {
            if (data?.Count == 0) return;

            using var sfd = new SaveFileDialog { Filter = "Word (*.docx)|*.docx"};
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using var doc = DocX.Create(sfd.FileName);
            var table = doc.AddTable(data.Count, data[0].Length);
            for (int i = 0; i < data.Count; i++)
                for (int j = 0; j < data[i].Length; j++)
                    table.Rows[i].Cells[j].Paragraphs[0].Append(data[i][j]);

            doc.InsertTable(table);
            doc.Save();
            Panel.Visible = false;
        }

        /* File BPF */
        public void ExportToPDF(List<string[]> data, Control Panel)
        {
            if (data?.Count == 0) return;

            using var sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf"};
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var doc = new PdfDocument();
            var page = doc.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Arial", 10);
            double x = 20, y = 20, h = 20, w = 100;

            for (int i = 0; i < data.Count; i++)
                for (int j = 0; j < data[i].Length; j++)
                    gfx.DrawString(data[i][j], font, XBrushes.Black,
                        new XRect(x + j * w, y + i * h, w, h), XStringFormats.Center);

            doc.Save(sfd.FileName);
            Panel.Visible = false;
        }
    }
}



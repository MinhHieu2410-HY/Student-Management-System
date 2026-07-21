namespace WFEND.Subject_Class
{
    public partial class ClassSubject : Form
    {
        Open _openInstance = new Open();

        public ClassSubject()
        {
            InitializeComponent();
        }

        private async Task ComboValueAsync()
        {
            var comboBoxQueries = new[]
            {
        new { Query = "SELECT ClassId, NameClass FROM Class", ValueField = "ClassId", DisplayField = "NameClass", ComboBox = CB_Class },
        new { Query = "SELECT SubjectId, NameSubject FROM Subject", ValueField = "SubjectId", DisplayField = "NameSubject", ComboBox = Cb_subject }
        };

            foreach (var item in comboBoxQueries)
            {
                await _openInstance.LoadComboBoxDataAsync(item.Query, item.ValueField, item.DisplayField, item.ComboBox);
            }
        }


        private void ClassSubject_Load(object sender, EventArgs e)
        {
            ComboValueAsync();
            subjectclass();
        }
        public void subjectclass()
        {
            _openInstance.LoadData("GetClassSubjectDetails", data_Show);
        }

        private void radiusButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string _class = CB_Class.Texts.Split(' ')[0];
                string subject = Cb_subject.Texts.Split(' ')[0];

                if (string.IsNullOrWhiteSpace(_class) || string.IsNullOrWhiteSpace(subject))
                {
                    MessageBox.Show("Please enter all the required information.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "Insert ClassSubject (ClassId , SubjectId ) " +
                               $"Values ('{_class}' , '{subject}')";
                _openInstance.RuncodeSql(query);
                subjectclass();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string selectedClassId;
        private string selectedSubjectId;
        private bool isRightClick = false;
        private void data_Show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = data_Show.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    data_Show.ClearSelection();
                    data_Show.Rows[hitTestInfo.RowIndex].Selected = true;

                    selectedClassId = data_Show.Rows[hitTestInfo.RowIndex].Cells["ClassId"].Value?.ToString();
                    selectedSubjectId = data_Show.Rows[hitTestInfo.RowIndex].Cells["SubjectId"].Value?.ToString();

                    contextMenuStrip1.Show(data_Show, e.Location);
                    isRightClick = true;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isRightClick && !string.IsNullOrEmpty(selectedClassId) && !string.IsNullOrEmpty(selectedSubjectId))
            {
                string query = $"DELETE FROM ClassSubject WHERE ClassId = '{selectedClassId}' AND SubjectId = '{selectedSubjectId}'";
                _openInstance.RuncodeSql(query);
                subjectclass();
                isRightClick = false;
            }
            else
            {
                isRightClick = false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string textSearch = textBox2.Text.Trim();
            Open _openInstance = new Open();
            _openInstance.SearchData("ClassSubject",textSearch,data_Show);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}

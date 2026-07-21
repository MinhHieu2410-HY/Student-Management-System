using DocumentFormat.OpenXml.VariantTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFEND.Behavior
{
    public partial class Behavior : Form
    {
        private readonly Open _openInstance = new Open();
        private static readonly string ConnectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        public string Username;
        public Behavior(string username)
        {
            InitializeComponent();
            Username = username;
            ComboBoxValue();
        }
        private async void ComboBoxValue()
        {
            string rank = Form1.Instance.rank;
            string classid = Form1.Instance.classId;
            var comboBoxQueries = new[]
            {
            new { Query = "SELECT ClassId, NameClass FROM Class", ValueField = "ClassId", DisplayField = "NameClass", ComboBox = cb_Class },
            new { Query = "SELECT SemesterId, NameSemester FROM Semester", ValueField = "SemesterId", DisplayField = "NameSemester", ComboBox = cb_semester }
            };

            foreach (var item in comboBoxQueries)
            {
                await _openInstance.LoadComboBoxDataAsync(item.Query, item.ValueField, item.DisplayField, item.ComboBox);
            }
            if (rank == "GV")
            {
                cb_Class.Items.Clear();
                cb_Class.Texts = $"{classid}";
                cb_Class.Items.Add($"{classid}");
            }
        }
        private async void cb_Class_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var Class = cb_Class.Texts.Split()[0];
            string query = $"SELECT Id, FullName FROM Students WHERE ClassId = '{Class}'";
            await _openInstance.LoadComboBoxDataAsync(query, "Id", "FullName", cb_Students);
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            int selectedIndex = Tab_data.SelectedIndex;
            var Class = cb_Class.Texts.Split(' ')[0].Trim();
            var Students = cb_Students.Texts.Split(' ')[0].Trim();
            var semester = cb_semester.Texts.Split(' ')[0].Trim();

            if (selectedIndex == 0)
            {
                var query = (string.IsNullOrWhiteSpace(Students), string.IsNullOrWhiteSpace(semester)) switch
                {
                    (true, true) => $"SELECT * FROM BehaviorLog a WHERE a.ClassId = '{Class}'",
                    (true, false) => $"SELECT * FROM BehaviorLog a WHERE a.ClassId = '{Class}' AND a.SemesterId = '{semester}'",
                    (false, true) => $"SELECT * FROM BehaviorLog a WHERE a.StudentId = '{Students}'",
                    (false, false) => $"SELECT * FROM BehaviorLog a WHERE a.StudentId = '{Students}' AND a.SemesterId = '{semester}'",
                };
                _openInstance.tabelname("Behavior", data_Show1, query);
            }
            else
            {
                var query = (string.IsNullOrWhiteSpace(Students), string.IsNullOrWhiteSpace(semester)) switch
                {
                    (true, false) => $"EXEC GetBehaviorSummary '{Class}', '{semester}';",
                    (false, true) => $"EXEC GetBehaviorSummary @StudentId = '{Students}';",
                    (true, true) => $"",
                    (false, false) => $"EXEC GetBehaviorSummary @StudentId = '{Students}';",
                };
                _openInstance.tabelname("Behavior", data_Show2, query);
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            int selectedIndex = Tab_data.SelectedIndex;
            var Class = cb_Class.Texts.Split(' ')[0].Trim();
            var Students = cb_Students.Texts.Split(' ')[0].Trim();
            var semester = cb_semester.Texts.Split(' ')[0].Trim();
            var behavior = cb_behavior.Texts.Trim();
            var Date = DT_date.Text;
            var note = t_note.Texts;

            string query = "INSERT INTO BehaviorLog (StudentId, ClassId, SemesterId, UserName, Date, ViolationDescription, Note)" +
                           $"VALUES ({Students}, '{Class}', '{semester}', '{Username}', '{Date}', N'{behavior}', N'{note}');";
            _openInstance.tabelname("Behavior", data_Show2, query);
        }
    }
}

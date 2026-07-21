using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using WFEND.Support;

namespace WFEND.Score
{
    public partial class ScoreNew : Form
    {
        static string ConnectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        private Score scoreform;
        private readonly Open _openInstance = new Open();
        string rank = Form1.Instance.rank;
        string classid = Form1.Instance.classId;

        public ScoreNew(Score scoreForm)
        {
            InitializeComponent();
            scoreform = scoreForm;
        }
        private void b_CloseRegi_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void ScoreNew_Load(object sender, EventArgs e)
        {
            await _openInstance.LoadComboBoxDataAsync("SELECT Id, FullName FROM Students", "Id", "FullName", cb_Students);
            await _openInstance.LoadComboBoxDataAsync("SELECT SubjectId, NameSubject FROM Subject", "SubjectId", "NameSubject", cb_Subject);
            await _openInstance.LoadComboBoxDataAsync("SELECT SemesterId, NameSemester FROM Semester", "SemesterId", "NameSemester", cb_Semester);
            if (rank == "GV")
            {
                cb_Students.Items.Clear();
                await _openInstance.LoadComboBoxDataAsync($"SELECT Id, FullName FROM Students where classid = '{classid.Split()[0]}'", "Id", "FullName", cb_Students);
            }
        }

        private void b_Insert_Click(object sender, EventArgs e)
        {
            var firstValues = new[] { cb_Students.Texts, cb_Subject.Texts, cb_Semester.Texts }
                               .Select(s => s.Split(' ')[0])
                               .ToList();
            string StudentsId = firstValues[0].Split()[0];
            string SubjectId = firstValues[1].Split()[0];
            string SemesterId = firstValues[2].Split()[0];

            string score1 = string.IsNullOrEmpty(t_score1.Text) ? null : t_score1.Text;
            string score2 = string.IsNullOrEmpty(t_score2.Text) ? null : t_score2.Text;
            string score3 = string.IsNullOrEmpty(t_score3.Text) ? null : t_score3.Text;

            bool IsValidScore(string score) =>
            float.TryParse(score, out float s) && s > 0 && s < 10;

            if ((score1 != null && !IsValidScore(score1)) ||
                (score2 != null && !IsValidScore(score2)) ||
                (score3 != null && !IsValidScore(score3)))
            {
                MessageBox.Show("Scores must be numbers greater than 0 and less than 10.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Score (StudentsId, SubjectId, SemesterId, Score1, Score2, Score3) VALUES (@StudentsId, @SubjectId, @SemesterId, @Score1, @Score2, @Score3)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentsId", StudentsId);
                    command.Parameters.AddWithValue("@SubjectId", SubjectId);
                    command.Parameters.AddWithValue("@SemesterId", SemesterId);
                    command.Parameters.AddWithValue("@Score1", (object)score1 ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Score2", (object)score2 ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Score3", (object)score3 ?? DBNull.Value);

                    try
                    {
                        this.Close();
                        command.ExecuteNonQuery();
                        scoreform.ScoreReload(); 
                        MessageBox.Show("Insert successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Insert failed!");
                    }
                }
            }
        }

    }
}

using Microsoft.Data.SqlClient;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace WFEND
{
    public partial class Statistics : Form
    {
        public int TotalStudents, MaleStudents, FemaleStudents , Absent;
        public int APlus, A , BPlus , B , F;
        string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";


        public Statistics()
        {
            InitializeComponent();
        }

        private void StudentsHome_Load(object sender, EventArgs e)
        {
            GetNumberSudents();
            l_inttotalschool.Text = TotalStudents.ToString();
            l_intmale.Text = MaleStudents.ToString();
            l_intfemale.Text = FemaleStudents.ToString();
            l_intabsent.Text = Absent.ToString();

            StudentCount();
            UpdateChart();

        }
        private void GetNumberSudents()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM dbo.fn_StudentCounts();", connection);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TotalStudents = reader.GetInt32(0);
                    MaleStudents = reader.GetInt32(1);
                    FemaleStudents = reader.GetInt32(2);
                    Absent = reader.GetInt32(3);
                }
            }
        }

        private void StudentCount()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM dbo.fn_ScoreCount();", connection);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    try {APlus = reader.GetInt32(0);
                    A = reader.GetInt32(1);
                    BPlus = reader.GetInt32(2);
                    B = reader.GetInt32(3);
                    F = reader.GetInt32(4);
                    }
                    catch {
                        APlus = 0;
                        A = 0;
                        BPlus = 0;
                        B = 0;
                        F = 0;
                    }
                }
            }
        }
        private void UpdateChart()
        {
            pi_totalabsent.Series = new ISeries[]
            {
                new PieSeries<int> { Values = new[] { TotalStudents }, Name = "Total Students" },
                new PieSeries<int> { Values = new[] { Absent }, Name = "Absent" }
            };
            pi_score.Series = new ISeries[]
                        {
                new PieSeries<int> { Values = new[] { APlus }, Name = "Tier A Plus" },
                new PieSeries<int> { Values = new[] { A }, Name = "Tier A" },
                new PieSeries<int> { Values = new[] { BPlus }, Name = "Tier B Plus" },
                new PieSeries<int> { Values = new[] { B }, Name = "Tier B" },
                new PieSeries<int> { Values = new[] { F }, Name = "Tier F" }
                        };
        }
    }
}

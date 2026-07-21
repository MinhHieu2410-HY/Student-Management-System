using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WFEND
{
    public partial class ShowImage : Form
    {
        private string imgsource;
        private string Id;
        private DataGridView dataGrid;
        private string TableSelect;
        string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
        Open openInstance = new Open();
        string queryId;
        string queryUpdate;
        string What ;

        public ShowImage(string id, DataGridView dataGrid, string table)
        {
            InitializeComponent();
            Id = id;
            this.dataGrid = dataGrid;
            TableSelect = table;
            check(table);
            LoadImage(Id);
        }

        private void ShowImage_Load(object sender, EventArgs e)
        {
        }
        private void check(string table)
        {
            if (table == "Students")
            {
                queryId = "GetStudentProfilePicture";
                queryUpdate = "UpdateProfilePicture";
                What = "ID";
            }
            else
            {
                queryId = "GetTeacherProfilePicture";
                queryUpdate = "UpdateProfilePicture";
                What = "TeacherId";
            }
        }

        private void LoadImage(string id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("GetProfilePicture", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);

                    byte[] imageBytes = cmd.ExecuteScalar() as byte[];

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Bitmap bitmap = new Bitmap(ms);
                            Image.BackgroundImage = bitmap;
                            Image.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error loading image.");
                        return;
                    }
                }
            }
        }
        private void b_tick_Click(object sender, EventArgs e)
        {
            if (imgsource != null)
            {
                try
                {
                    byte[] imageBytes;
                    using (FileStream fs = new FileStream(imgsource, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            imageBytes = br.ReadBytes((int)fs.Length);
                        }
                    }

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UpdateProfilePicture", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                            cmd.Parameters.AddWithValue("@ID", Id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    this.Close();
                    MessageBox.Show("Done!");
                    openInstance.tabelname(TableSelect, dataGrid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading image: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No photos have been selected for upload yet.");
            }
        }
        private void b_CloseRegi_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void b_MaxSize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                b_zoom.Image = Properties.Resources.Mini;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                b_zoom.Image = Properties.Resources.Fullsize;
            }
        }

        private void radiusButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Chọn ảnh (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    imgsource = opf.FileName;
                    try
                    {
                        if (Image.Image != null) Image.Image.Dispose();
                        Image.SizeMode = PictureBoxSizeMode.StretchImage;
                        Image.Image = System.Drawing.Image.FromFile(imgsource);
                        b_tick.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("You have not selected any photos yet.");
                }
            }
        }


    }
}

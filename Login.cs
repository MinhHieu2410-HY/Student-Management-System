using LiveChartsCore.Kernel;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using WFEND.Support;

namespace WFEND
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1030);
        }
        private void radiusButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Focus(TextBoxCustom textBox, LabelCus label)
        {
            textBox.Location = new Point(40, 10);
            label.Text = null;
            if (textBox.Width != 270)
            {
                textBox.Width = 270;
                textBox.Invalidate();
                textBox.Update();
            }
            textBox.Focus();
        }
        private void ResetTextBox(TextBoxCustom textBox, LabelCus label, string placeholder, Point location, int width)
        {
            textBox.Location = location;
            label.Text = placeholder;
            if (textBox.Width != width)
            {
                textBox.Width = width;
                textBox.Invalidate();
                textBox.Update();
            }
        }
        private void textBoxCustom1_Enter(object sender, EventArgs e)
        {
            Focus(textBoxCustom1, labelCus2);
        }

        private void textBoxCustom2_Enter(object sender, EventArgs e)
        {
            Focus(textBoxCustom2, labelCus3);
        }

        private void textBoxCustom1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustom1.Texts))
            {
                ResetTextBox(textBoxCustom1, labelCus2, "Username", new Point(159, 10), 155);
            }
        }
        private void textBoxCustom2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustom2.Texts))
            {
                ResetTextBox(textBoxCustom2, labelCus3, "Password", new Point(156, 11), 155);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                string username = textBoxCustom1.Texts;
                string password = textBoxCustom2.Texts;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username and password cannot be empty.");
                    return;
                }
                string connectionString = "Data Source=HIEUNGUYEN;Initial Catalog=DataWDFEND;Integrated Security=True;Encrypt=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE UserName=@username AND Passwords=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string rank = reader["Rank"].ToString();

                            Attendance _attendance = new Attendance(username);
                            _attendance.Username = username;
                            this.Hide();

                            Form1 mainForm = new Form1();
                            mainForm.username = username;
                            mainForm.rank = rank;
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                        }
                    }
                }
            } catch {
                MessageBox.Show("Connect Fail","Error");
            }
            
        }
        private bool isPasswordVisible = false;
        private void bt_show_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                textBoxCustom2.PasswordChar = true;
                bt_show.Image = Properties.Resources.eyeshow;
            }
            else
            {
                textBoxCustom2.PasswordChar = false;
                bt_show.Image = Properties.Resources.eyehide;
            }
        }

        private void textBoxCustom2_KeyDownCustom(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(sender , e);
            }
        }
    }
}

using WFEND.Support;

namespace WFEND
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            p_taskbar = new Panel();
            bt_account = new Button();
            b_Behavior = new Button();
            b_attendance = new Button();
            b_subject_Class = new Button();
            p_miniscore = new Panel();
            b_managescore = new Button();
            b_score = new Button();
            p_minicourse = new Panel();
            b_managecourse = new Button();
            b_teacher = new Button();
            p_ministudents = new Panel();
            button1 = new Button();
            b_registration = new Button();
            b_students = new Button();
            b_Exit = new Button();
            b_home = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            t_female = new TextBox();
            panelMain = new Panel();
            p_taskbar.SuspendLayout();
            p_miniscore.SuspendLayout();
            p_minicourse.SuspendLayout();
            p_ministudents.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // p_taskbar
            // 
            p_taskbar.AutoScroll = true;
            p_taskbar.BackColor = Color.FromArgb(38, 50, 56);
            p_taskbar.Controls.Add(bt_account);
            p_taskbar.Controls.Add(b_Behavior);
            p_taskbar.Controls.Add(b_attendance);
            p_taskbar.Controls.Add(b_subject_Class);
            p_taskbar.Controls.Add(p_miniscore);
            p_taskbar.Controls.Add(b_score);
            p_taskbar.Controls.Add(p_minicourse);
            p_taskbar.Controls.Add(b_teacher);
            p_taskbar.Controls.Add(p_ministudents);
            p_taskbar.Controls.Add(b_students);
            p_taskbar.Controls.Add(b_Exit);
            p_taskbar.Controls.Add(b_home);
            p_taskbar.Dock = DockStyle.Left;
            p_taskbar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            p_taskbar.ForeColor = Color.White;
            p_taskbar.Location = new Point(0, 87);
            p_taskbar.Name = "p_taskbar";
            p_taskbar.Size = new Size(262, 913);
            p_taskbar.TabIndex = 0;
            p_taskbar.Paint += p_backLog_Paint;
            // 
            // bt_account
            // 
            bt_account.BackColor = Color.FromArgb(38, 50, 56);
            bt_account.Dock = DockStyle.Top;
            bt_account.FlatAppearance.BorderSize = 0;
            bt_account.FlatStyle = FlatStyle.Flat;
            bt_account.Font = new Font("Times New Roman", 13.2000008F);
            bt_account.ForeColor = Color.White;
            bt_account.Image = Properties.Resources.account1;
            bt_account.ImageAlign = ContentAlignment.MiddleLeft;
            bt_account.Location = new Point(0, 697);
            bt_account.Name = "bt_account";
            bt_account.Padding = new Padding(20, 0, 0, 0);
            bt_account.Size = new Size(262, 70);
            bt_account.TabIndex = 13;
            bt_account.Text = "   Account";
            bt_account.UseVisualStyleBackColor = false;
            bt_account.Click += bt_account_Click;
            bt_account.MouseLeave += bt_account_MouseLeave;
            bt_account.MouseHover += bt_account_MouseHover;
            // 
            // b_Behavior
            // 
            b_Behavior.BackColor = Color.FromArgb(38, 50, 56);
            b_Behavior.Dock = DockStyle.Top;
            b_Behavior.FlatAppearance.BorderSize = 0;
            b_Behavior.FlatStyle = FlatStyle.Flat;
            b_Behavior.Font = new Font("Times New Roman", 13.2000008F);
            b_Behavior.ForeColor = Color.White;
            b_Behavior.Image = (Image)resources.GetObject("b_Behavior.Image");
            b_Behavior.ImageAlign = ContentAlignment.MiddleLeft;
            b_Behavior.Location = new Point(0, 627);
            b_Behavior.Name = "b_Behavior";
            b_Behavior.Padding = new Padding(20, 0, 0, 0);
            b_Behavior.Size = new Size(262, 70);
            b_Behavior.TabIndex = 12;
            b_Behavior.Text = "   Behavior";
            b_Behavior.UseVisualStyleBackColor = false;
            b_Behavior.Click += b_Behavior_Click;
            b_Behavior.MouseLeave += b_Behavior_MouseLeave;
            b_Behavior.MouseHover += b_Behavior_MouseHover;
            // 
            // b_attendance
            // 
            b_attendance.BackColor = Color.FromArgb(38, 50, 56);
            b_attendance.Dock = DockStyle.Top;
            b_attendance.FlatAppearance.BorderSize = 0;
            b_attendance.FlatStyle = FlatStyle.Flat;
            b_attendance.Font = new Font("Times New Roman", 13.2000008F);
            b_attendance.ForeColor = Color.White;
            b_attendance.Image = (Image)resources.GetObject("b_attendance.Image");
            b_attendance.ImageAlign = ContentAlignment.MiddleLeft;
            b_attendance.Location = new Point(0, 557);
            b_attendance.Name = "b_attendance";
            b_attendance.Padding = new Padding(20, 0, 0, 0);
            b_attendance.Size = new Size(262, 70);
            b_attendance.TabIndex = 11;
            b_attendance.Text = "   Attendance";
            b_attendance.UseVisualStyleBackColor = false;
            b_attendance.Click += b_attendance_Click;
            b_attendance.MouseLeave += b_attendance_MouseLeave;
            b_attendance.MouseHover += b_attendance_MouseHover;
            // 
            // b_subject_Class
            // 
            b_subject_Class.BackColor = Color.FromArgb(38, 50, 56);
            b_subject_Class.Dock = DockStyle.Top;
            b_subject_Class.FlatAppearance.BorderSize = 0;
            b_subject_Class.FlatStyle = FlatStyle.Flat;
            b_subject_Class.Font = new Font("Times New Roman", 13.2000008F);
            b_subject_Class.ForeColor = Color.White;
            b_subject_Class.Image = (Image)resources.GetObject("b_subject_Class.Image");
            b_subject_Class.ImageAlign = ContentAlignment.MiddleLeft;
            b_subject_Class.Location = new Point(0, 487);
            b_subject_Class.Name = "b_subject_Class";
            b_subject_Class.Padding = new Padding(22, 0, 0, 0);
            b_subject_Class.Size = new Size(262, 70);
            b_subject_Class.TabIndex = 9;
            b_subject_Class.Text = "        Subject - Class";
            b_subject_Class.UseVisualStyleBackColor = false;
            b_subject_Class.Click += b_subject_Class_Click;
            b_subject_Class.MouseLeave += b_subject_Class_MouseLeave;
            b_subject_Class.MouseHover += b_subject_Class_MouseHover;
            // 
            // p_miniscore
            // 
            p_miniscore.BackColor = Color.FromArgb(93, 102, 106);
            p_miniscore.Controls.Add(b_managescore);
            p_miniscore.Dock = DockStyle.Top;
            p_miniscore.Font = new Font("Times New Roman", 13.2000008F);
            p_miniscore.Location = new Point(0, 417);
            p_miniscore.Name = "p_miniscore";
            p_miniscore.Size = new Size(262, 70);
            p_miniscore.TabIndex = 7;
            // 
            // b_managescore
            // 
            b_managescore.BackColor = Color.FromArgb(174, 179, 181);
            b_managescore.Dock = DockStyle.Top;
            b_managescore.FlatAppearance.BorderSize = 0;
            b_managescore.FlatStyle = FlatStyle.Flat;
            b_managescore.ForeColor = Color.White;
            b_managescore.Image = (Image)resources.GetObject("b_managescore.Image");
            b_managescore.ImageAlign = ContentAlignment.MiddleLeft;
            b_managescore.Location = new Point(0, 0);
            b_managescore.Name = "b_managescore";
            b_managescore.Padding = new Padding(20, 0, 0, 0);
            b_managescore.Size = new Size(262, 70);
            b_managescore.TabIndex = 2;
            b_managescore.Text = "    Manage Score";
            b_managescore.UseVisualStyleBackColor = false;
            b_managescore.Click += b_managescore_Click;
            // 
            // b_score
            // 
            b_score.BackColor = Color.FromArgb(38, 50, 56);
            b_score.Dock = DockStyle.Top;
            b_score.FlatAppearance.BorderSize = 0;
            b_score.FlatStyle = FlatStyle.Flat;
            b_score.Font = new Font("Times New Roman", 13.2000008F);
            b_score.ForeColor = Color.White;
            b_score.Image = (Image)resources.GetObject("b_score.Image");
            b_score.ImageAlign = ContentAlignment.MiddleLeft;
            b_score.Location = new Point(0, 347);
            b_score.Name = "b_score";
            b_score.Padding = new Padding(22, 0, 0, 0);
            b_score.Size = new Size(262, 70);
            b_score.TabIndex = 6;
            b_score.Text = "Score";
            b_score.UseVisualStyleBackColor = false;
            b_score.Click += b_score_Click;
            b_score.MouseLeave += b_score_MouseLeave;
            b_score.MouseHover += b_score_MouseHover;
            // 
            // p_minicourse
            // 
            p_minicourse.BackColor = Color.FromArgb(93, 102, 106);
            p_minicourse.Controls.Add(b_managecourse);
            p_minicourse.Dock = DockStyle.Top;
            p_minicourse.Font = new Font("Times New Roman", 13.2000008F);
            p_minicourse.Location = new Point(0, 276);
            p_minicourse.Name = "p_minicourse";
            p_minicourse.Size = new Size(262, 71);
            p_minicourse.TabIndex = 5;
            // 
            // b_managecourse
            // 
            b_managecourse.BackColor = Color.FromArgb(174, 179, 181);
            b_managecourse.Dock = DockStyle.Top;
            b_managecourse.FlatAppearance.BorderSize = 0;
            b_managecourse.FlatStyle = FlatStyle.Flat;
            b_managecourse.ForeColor = Color.White;
            b_managecourse.Image = (Image)resources.GetObject("b_managecourse.Image");
            b_managecourse.ImageAlign = ContentAlignment.MiddleLeft;
            b_managecourse.Location = new Point(0, 0);
            b_managecourse.Name = "b_managecourse";
            b_managecourse.Padding = new Padding(24, 0, 0, 0);
            b_managecourse.Size = new Size(262, 70);
            b_managecourse.TabIndex = 2;
            b_managecourse.Text = "   Manager ";
            b_managecourse.UseVisualStyleBackColor = false;
            b_managecourse.Click += b_manageteacher_Click;
            // 
            // b_teacher
            // 
            b_teacher.BackColor = Color.FromArgb(38, 50, 56);
            b_teacher.Dock = DockStyle.Top;
            b_teacher.FlatAppearance.BorderSize = 0;
            b_teacher.FlatStyle = FlatStyle.Flat;
            b_teacher.Font = new Font("Times New Roman", 13.2000008F);
            b_teacher.ForeColor = Color.White;
            b_teacher.Image = (Image)resources.GetObject("b_teacher.Image");
            b_teacher.ImageAlign = ContentAlignment.MiddleLeft;
            b_teacher.Location = new Point(0, 206);
            b_teacher.Name = "b_teacher";
            b_teacher.Padding = new Padding(20, 0, 0, 0);
            b_teacher.Size = new Size(262, 70);
            b_teacher.TabIndex = 2;
            b_teacher.Text = "Teacher";
            b_teacher.UseVisualStyleBackColor = false;
            b_teacher.Click += b_teacher_Click;
            b_teacher.MouseLeave += b_teacher_MouseLeave;
            b_teacher.MouseHover += b_teacher_MouseHover;
            // 
            // p_ministudents
            // 
            p_ministudents.BackColor = Color.FromArgb(93, 102, 106);
            p_ministudents.Controls.Add(button1);
            p_ministudents.Controls.Add(b_registration);
            p_ministudents.Dock = DockStyle.Top;
            p_ministudents.Font = new Font("Times New Roman", 13.2000008F);
            p_ministudents.Location = new Point(0, 134);
            p_ministudents.Name = "p_ministudents";
            p_ministudents.Size = new Size(262, 72);
            p_ministudents.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(174, 179, 181);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 72);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(262, 72);
            button1.TabIndex = 2;
            button1.Text = "Manager";
            button1.UseVisualStyleBackColor = false;
            // 
            // b_registration
            // 
            b_registration.BackColor = Color.FromArgb(174, 179, 181);
            b_registration.Dock = DockStyle.Top;
            b_registration.FlatAppearance.BorderSize = 0;
            b_registration.FlatStyle = FlatStyle.Flat;
            b_registration.ForeColor = Color.White;
            b_registration.Image = (Image)resources.GetObject("b_registration.Image");
            b_registration.ImageAlign = ContentAlignment.MiddleLeft;
            b_registration.Location = new Point(0, 0);
            b_registration.Name = "b_registration";
            b_registration.Padding = new Padding(25, 0, 0, 0);
            b_registration.Size = new Size(262, 72);
            b_registration.TabIndex = 1;
            b_registration.Text = "Manager";
            b_registration.UseVisualStyleBackColor = false;
            b_registration.Click += button2_Click;
            // 
            // b_students
            // 
            b_students.BackColor = Color.FromArgb(38, 50, 56);
            b_students.Dock = DockStyle.Top;
            b_students.FlatAppearance.BorderSize = 0;
            b_students.FlatStyle = FlatStyle.Flat;
            b_students.Font = new Font("Times New Roman", 13.2000008F);
            b_students.ForeColor = Color.White;
            b_students.Image = (Image)resources.GetObject("b_students.Image");
            b_students.ImageAlign = ContentAlignment.MiddleLeft;
            b_students.Location = new Point(0, 64);
            b_students.Name = "b_students";
            b_students.Padding = new Padding(20, 0, 0, 0);
            b_students.Size = new Size(262, 70);
            b_students.TabIndex = 1;
            b_students.Text = "Students";
            b_students.UseVisualStyleBackColor = false;
            b_students.Click += b_students_Click;
            b_students.MouseLeave += b_students_MouseLeave;
            b_students.MouseHover += b_students_MouseHover;
            // 
            // b_Exit
            // 
            b_Exit.BackColor = Color.FromArgb(38, 59, 56);
            b_Exit.Dock = DockStyle.Bottom;
            b_Exit.FlatAppearance.BorderSize = 0;
            b_Exit.FlatStyle = FlatStyle.Flat;
            b_Exit.Font = new Font("Times New Roman", 13.2000008F);
            b_Exit.ForeColor = Color.White;
            b_Exit.Image = (Image)resources.GetObject("b_Exit.Image");
            b_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            b_Exit.Location = new Point(0, 833);
            b_Exit.Name = "b_Exit";
            b_Exit.Padding = new Padding(26, 0, 0, 0);
            b_Exit.Size = new Size(262, 80);
            b_Exit.TabIndex = 8;
            b_Exit.Text = "Exit";
            b_Exit.UseVisualStyleBackColor = false;
            b_Exit.Click += b_Exit_Click;
            b_Exit.MouseLeave += b_Exit_MouseLeave;
            b_Exit.MouseHover += b_Exit_MouseHover;
            // 
            // b_home
            // 
            b_home.BackColor = Color.FromArgb(38, 50, 56);
            b_home.Dock = DockStyle.Top;
            b_home.FlatAppearance.BorderSize = 0;
            b_home.FlatStyle = FlatStyle.Flat;
            b_home.Font = new Font("Times New Roman", 13.2000008F);
            b_home.ForeColor = Color.White;
            b_home.Image = (Image)resources.GetObject("b_home.Image");
            b_home.ImageAlign = ContentAlignment.MiddleLeft;
            b_home.Location = new Point(0, 0);
            b_home.Name = "b_home";
            b_home.Padding = new Padding(20, 0, 0, 0);
            b_home.Size = new Size(262, 64);
            b_home.TabIndex = 4;
            b_home.Text = "Home";
            b_home.UseVisualStyleBackColor = false;
            b_home.Click += b_home_Click;
            b_home.MouseLeave += b_home_MouseLeave;
            b_home.MouseHover += b_home_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 65, 72);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1900, 87);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 65, 72);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 35);
            textBox1.TabIndex = 1;
            textBox1.Text = "Welcome Manage Students";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // t_female
            // 
            t_female.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            t_female.BackColor = Color.FromArgb(234, 0, 196);
            t_female.BorderStyle = BorderStyle.None;
            t_female.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_female.ForeColor = Color.White;
            t_female.Location = new Point(1005, 576);
            t_female.Name = "t_female";
            t_female.Size = new Size(638, 26);
            t_female.TabIndex = 2;
            t_female.Text = "Female";
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(262, 87);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1638, 913);
            panelMain.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1900, 1000);
            ControlBox = false;
            Controls.Add(panelMain);
            Controls.Add(t_female);
            Controls.Add(p_taskbar);
            Controls.Add(panel2);
            MinimumSize = new Size(1918, 1018);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            p_taskbar.ResumeLayout(false);
            p_miniscore.ResumeLayout(false);
            p_minicourse.ResumeLayout(false);
            p_ministudents.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p_taskbar;
        private Panel p_ministudents;
        private Button b_registration;
        private Panel p_minicourse;
        private Button b_managecourse;
        private Button b_home;
        private Panel p_miniscore;
        private Button b_managescore;
        private Button b_score;
        private Button b_Exit;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel1;
        private Button b_students;
        private Button b_teacher;
        private Panel p_male;
        private Panel p_showtotal;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox t_female;
        private Panel panelMain;
        private Button b_subject_Class;
        private Button b_attendance;
        private Button button1;
        private Button b_Behavior;
        private Button bt_account;
    }
}

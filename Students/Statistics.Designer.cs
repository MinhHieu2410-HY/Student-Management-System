namespace WFEND
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            p_male = new Support.RadiusPanel();
            l_intmale = new Label();
            pi_male = new PictureBox();
            l_male = new Label();
            p_totalStudents = new Support.RadiusPanel();
            l_inttotalschool = new Label();
            l_totalstudents = new Label();
            pi_totalstudents = new PictureBox();
            p_female = new Support.RadiusPanel();
            l_intfemale = new Label();
            l_female = new Label();
            pi_female = new PictureBox();
            p_absent = new Support.RadiusPanel();
            l_intabsent = new Label();
            l_absent = new Label();
            pi_absent = new PictureBox();
            totalschool = new Support.RadiusPanel();
            p_chart = new Support.RadiusPanel();
            labelCus2 = new Support.LabelCus();
            labelCus1 = new Support.LabelCus();
            p_pie2 = new Support.RadiusPanel();
            pi_score = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            p_pie1 = new Support.RadiusPanel();
            pi_totalabsent = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            labelCus3 = new Support.LabelCus();
            p_male.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pi_male).BeginInit();
            p_totalStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pi_totalstudents).BeginInit();
            p_female.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pi_female).BeginInit();
            p_absent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pi_absent).BeginInit();
            totalschool.SuspendLayout();
            p_chart.SuspendLayout();
            p_pie2.SuspendLayout();
            p_pie1.SuspendLayout();
            SuspendLayout();
            // 
            // p_male
            // 
            p_male.BackColor = Color.FromArgb(238, 82, 80);
            p_male.BackgroundColor = Color.FromArgb(238, 82, 80);
            p_male.BorderColor = Color.PaleVioletRed;
            p_male.BorderRadius = 5;
            p_male.BorderSize = 0;
            p_male.Controls.Add(l_intmale);
            p_male.Controls.Add(pi_male);
            p_male.Controls.Add(l_male);
            p_male.ForeColor = Color.White;
            p_male.Location = new Point(440, 10);
            p_male.Name = "p_male";
            p_male.Size = new Size(342, 111);
            p_male.TabIndex = 0;
            p_male.TextColor = Color.White;
            // 
            // l_intmale
            // 
            l_intmale.AutoSize = true;
            l_intmale.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_intmale.Location = new Point(211, 54);
            l_intmale.Name = "l_intmale";
            l_intmale.Size = new Size(56, 32);
            l_intmale.TabIndex = 8;
            l_intmale.Text = "###";
            l_intmale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pi_male
            // 
            pi_male.BackgroundImage = (Image)resources.GetObject("pi_male.BackgroundImage");
            pi_male.BackgroundImageLayout = ImageLayout.Center;
            pi_male.Dock = DockStyle.Left;
            pi_male.Location = new Point(0, 0);
            pi_male.Name = "pi_male";
            pi_male.Size = new Size(139, 111);
            pi_male.TabIndex = 3;
            pi_male.TabStop = false;
            // 
            // l_male
            // 
            l_male.AutoSize = true;
            l_male.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            l_male.Location = new Point(202, 19);
            l_male.Name = "l_male";
            l_male.Size = new Size(83, 32);
            l_male.TabIndex = 7;
            l_male.Text = "Male:";
            // 
            // p_totalStudents
            // 
            p_totalStudents.BackColor = Color.FromArgb(41, 183, 247);
            p_totalStudents.BackgroundColor = Color.FromArgb(41, 183, 247);
            p_totalStudents.BackgroundImageLayout = ImageLayout.Center;
            p_totalStudents.BorderColor = Color.PaleVioletRed;
            p_totalStudents.BorderRadius = 5;
            p_totalStudents.BorderSize = 0;
            p_totalStudents.Controls.Add(l_inttotalschool);
            p_totalStudents.Controls.Add(l_totalstudents);
            p_totalStudents.Controls.Add(pi_totalstudents);
            p_totalStudents.ForeColor = Color.White;
            p_totalStudents.Location = new Point(12, 10);
            p_totalStudents.Name = "p_totalStudents";
            p_totalStudents.Size = new Size(342, 111);
            p_totalStudents.TabIndex = 1;
            p_totalStudents.TextColor = Color.White;
            // 
            // l_inttotalschool
            // 
            l_inttotalschool.AutoSize = true;
            l_inttotalschool.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_inttotalschool.Location = new Point(201, 54);
            l_inttotalschool.Name = "l_inttotalschool";
            l_inttotalschool.Size = new Size(56, 32);
            l_inttotalschool.TabIndex = 9;
            l_inttotalschool.Text = "###";
            l_inttotalschool.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_totalstudents
            // 
            l_totalstudents.AutoSize = true;
            l_totalstudents.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            l_totalstudents.Location = new Point(149, 18);
            l_totalstudents.Name = "l_totalstudents";
            l_totalstudents.Size = new Size(186, 32);
            l_totalstudents.TabIndex = 5;
            l_totalstudents.Text = "Total Students";
            // 
            // pi_totalstudents
            // 
            pi_totalstudents.BackgroundImage = (Image)resources.GetObject("pi_totalstudents.BackgroundImage");
            pi_totalstudents.BackgroundImageLayout = ImageLayout.Center;
            pi_totalstudents.Dock = DockStyle.Left;
            pi_totalstudents.Location = new Point(0, 0);
            pi_totalstudents.Name = "pi_totalstudents";
            pi_totalstudents.Size = new Size(139, 111);
            pi_totalstudents.TabIndex = 2;
            pi_totalstudents.TabStop = false;
            // 
            // p_female
            // 
            p_female.BackColor = Color.FromArgb(103, 187, 107);
            p_female.BackgroundColor = Color.FromArgb(103, 187, 107);
            p_female.BorderColor = Color.PaleVioletRed;
            p_female.BorderRadius = 5;
            p_female.BorderSize = 0;
            p_female.Controls.Add(l_intfemale);
            p_female.Controls.Add(l_female);
            p_female.Controls.Add(pi_female);
            p_female.ForeColor = Color.White;
            p_female.Location = new Point(854, 10);
            p_female.Name = "p_female";
            p_female.Size = new Size(342, 111);
            p_female.TabIndex = 1;
            p_female.TextColor = Color.White;
            // 
            // l_intfemale
            // 
            l_intfemale.AutoSize = true;
            l_intfemale.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_intfemale.Location = new Point(216, 54);
            l_intfemale.Name = "l_intfemale";
            l_intfemale.Size = new Size(56, 32);
            l_intfemale.TabIndex = 9;
            l_intfemale.Text = "###";
            l_intfemale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_female
            // 
            l_female.AutoSize = true;
            l_female.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            l_female.Location = new Point(196, 22);
            l_female.Name = "l_female";
            l_female.Size = new Size(109, 32);
            l_female.TabIndex = 8;
            l_female.Text = "Female:";
            // 
            // pi_female
            // 
            pi_female.BackgroundImage = (Image)resources.GetObject("pi_female.BackgroundImage");
            pi_female.BackgroundImageLayout = ImageLayout.Center;
            pi_female.Dock = DockStyle.Left;
            pi_female.Location = new Point(0, 0);
            pi_female.Name = "pi_female";
            pi_female.Size = new Size(139, 111);
            pi_female.TabIndex = 3;
            pi_female.TabStop = false;
            // 
            // p_absent
            // 
            p_absent.BackColor = Color.FromArgb(93, 107, 193);
            p_absent.BackgroundColor = Color.FromArgb(93, 107, 193);
            p_absent.BorderColor = Color.PaleVioletRed;
            p_absent.BorderRadius = 5;
            p_absent.BorderSize = 0;
            p_absent.Controls.Add(l_intabsent);
            p_absent.Controls.Add(l_absent);
            p_absent.Controls.Add(pi_absent);
            p_absent.ForeColor = Color.White;
            p_absent.Location = new Point(1258, 10);
            p_absent.Name = "p_absent";
            p_absent.Size = new Size(342, 111);
            p_absent.TabIndex = 4;
            p_absent.TextColor = Color.White;
            // 
            // l_intabsent
            // 
            l_intabsent.AutoSize = true;
            l_intabsent.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_intabsent.Location = new Point(216, 54);
            l_intabsent.Name = "l_intabsent";
            l_intabsent.Size = new Size(56, 32);
            l_intabsent.TabIndex = 10;
            l_intabsent.Text = "###";
            l_intabsent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_absent
            // 
            l_absent.AutoSize = true;
            l_absent.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            l_absent.Location = new Point(195, 22);
            l_absent.Name = "l_absent";
            l_absent.Size = new Size(107, 32);
            l_absent.TabIndex = 9;
            l_absent.Text = "Absent:";
            // 
            // pi_absent
            // 
            pi_absent.BackgroundImage = (Image)resources.GetObject("pi_absent.BackgroundImage");
            pi_absent.BackgroundImageLayout = ImageLayout.Center;
            pi_absent.Dock = DockStyle.Left;
            pi_absent.Location = new Point(0, 0);
            pi_absent.Name = "pi_absent";
            pi_absent.Size = new Size(139, 111);
            pi_absent.TabIndex = 3;
            pi_absent.TabStop = false;
            // 
            // totalschool
            // 
            totalschool.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            totalschool.BackColor = Color.FromArgb(255, 254, 254);
            totalschool.BackgroundColor = Color.FromArgb(255, 254, 254);
            totalschool.BorderColor = Color.FromArgb(191, 194, 196);
            totalschool.BorderRadius = 5;
            totalschool.BorderSize = 1;
            totalschool.Controls.Add(p_absent);
            totalschool.Controls.Add(p_female);
            totalschool.Controls.Add(p_totalStudents);
            totalschool.Controls.Add(p_male);
            totalschool.ForeColor = Color.White;
            totalschool.Location = new Point(12, 12);
            totalschool.Name = "totalschool";
            totalschool.Size = new Size(1614, 130);
            totalschool.TabIndex = 20;
            totalschool.TextColor = Color.White;
            // 
            // p_chart
            // 
            p_chart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            p_chart.AutoScroll = true;
            p_chart.BackColor = Color.FromArgb(255, 254, 254);
            p_chart.BackgroundColor = Color.FromArgb(255, 254, 254);
            p_chart.BorderColor = Color.FromArgb(191, 194, 196);
            p_chart.BorderRadius = 5;
            p_chart.BorderSize = 1;
            p_chart.Controls.Add(labelCus3);
            p_chart.Controls.Add(labelCus2);
            p_chart.Controls.Add(labelCus1);
            p_chart.Controls.Add(p_pie2);
            p_chart.Controls.Add(p_pie1);
            p_chart.ForeColor = Color.White;
            p_chart.Location = new Point(12, 173);
            p_chart.Name = "p_chart";
            p_chart.Size = new Size(1614, 716);
            p_chart.TabIndex = 21;
            p_chart.TextColor = Color.White;
            // 
            // labelCus2
            // 
            labelCus2.Font = new Font("Times New Roman", 14F);
            labelCus2.font_size = 14;
            labelCus2.ForeColor = Color.Black;
            labelCus2.Location = new Point(960, 566);
            labelCus2.Name = "labelCus2";
            labelCus2.Size = new Size(450, 35);
            labelCus2.TabIndex = 26;
            labelCus2.Text = "Student Performance Chart in the School (%)";
            labelCus2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCus1
            // 
            labelCus1.Font = new Font("Times New Roman", 15F);
            labelCus1.font_size = 15;
            labelCus1.ForeColor = Color.Black;
            labelCus1.Location = new Point(161, 566);
            labelCus1.Name = "labelCus1";
            labelCus1.Size = new Size(450, 35);
            labelCus1.TabIndex = 24;
            labelCus1.Text = "Number of Absent Students per Day (%)";
            labelCus1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // p_pie2
            // 
            p_pie2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            p_pie2.BackColor = Color.FromArgb(255, 254, 254);
            p_pie2.BackgroundColor = Color.FromArgb(255, 254, 254);
            p_pie2.BorderColor = Color.FromArgb(191, 194, 196);
            p_pie2.BorderRadius = 5;
            p_pie2.BorderSize = 1;
            p_pie2.Controls.Add(pi_score);
            p_pie2.ForeColor = Color.White;
            p_pie2.Location = new Point(960, 113);
            p_pie2.Name = "p_pie2";
            p_pie2.Size = new Size(450, 450);
            p_pie2.TabIndex = 23;
            p_pie2.TextColor = Color.White;
            // 
            // pi_score
            // 
            pi_score.Dock = DockStyle.Fill;
            pi_score.InitialRotation = 0D;
            pi_score.IsClockwise = true;
            pi_score.Location = new Point(0, 0);
            pi_score.MaxAngle = 360D;
            pi_score.MaxValue = null;
            pi_score.MinValue = 0D;
            pi_score.Name = "pi_score";
            pi_score.Size = new Size(450, 450);
            pi_score.TabIndex = 25;
            // 
            // p_pie1
            // 
            p_pie1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            p_pie1.BackColor = Color.FromArgb(255, 254, 254);
            p_pie1.BackgroundColor = Color.FromArgb(255, 254, 254);
            p_pie1.BorderColor = Color.FromArgb(191, 194, 196);
            p_pie1.BorderRadius = 5;
            p_pie1.BorderSize = 1;
            p_pie1.Controls.Add(pi_totalabsent);
            p_pie1.ForeColor = Color.White;
            p_pie1.Location = new Point(161, 113);
            p_pie1.Name = "p_pie1";
            p_pie1.Size = new Size(450, 450);
            p_pie1.TabIndex = 22;
            p_pie1.TextColor = Color.White;
            // 
            // pi_totalabsent
            // 
            pi_totalabsent.Dock = DockStyle.Fill;
            pi_totalabsent.InitialRotation = 0D;
            pi_totalabsent.IsClockwise = true;
            pi_totalabsent.Location = new Point(0, 0);
            pi_totalabsent.MaxAngle = 360D;
            pi_totalabsent.MaxValue = null;
            pi_totalabsent.MinValue = 0D;
            pi_totalabsent.Name = "pi_totalabsent";
            pi_totalabsent.Size = new Size(450, 450);
            pi_totalabsent.TabIndex = 24;
            // 
            // labelCus3
            // 
            labelCus3.Font = new Font("Times New Roman", 22F);
            labelCus3.font_size = 22;
            labelCus3.ForeColor = Color.Black;
            labelCus3.Location = new Point(12, 16);
            labelCus3.Name = "labelCus3";
            labelCus3.Size = new Size(192, 49);
            labelCus3.TabIndex = 27;
            labelCus3.Text = "Statistics";
            labelCus3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentsHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1638, 913);
            Controls.Add(p_chart);
            Controls.Add(totalschool);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1638, 913);
            Name = "StudentsHome";
            Text = "SudentsHome";
            Load += StudentsHome_Load;
            p_male.ResumeLayout(false);
            p_male.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pi_male).EndInit();
            p_totalStudents.ResumeLayout(false);
            p_totalStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pi_totalstudents).EndInit();
            p_female.ResumeLayout(false);
            p_female.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pi_female).EndInit();
            p_absent.ResumeLayout(false);
            p_absent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pi_absent).EndInit();
            totalschool.ResumeLayout(false);
            p_chart.ResumeLayout(false);
            p_pie2.ResumeLayout(false);
            p_pie1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Support.RadiusPanel p_male;
        private Support.RadiusPanel p_totalStudents;
        private Support.RadiusPanel p_female;
        private PictureBox pi_male;
        private PictureBox pi_totalstudents;
        private PictureBox pi_female;
        private Support.RadiusPanel p_absent;
        private PictureBox pi_absent;
        private Label l_totalstudents;
        private Label l_male;
        private Label l_female;
        private Label l_absent;
        private Support.RadiusPanel totalschool;
        private Support.RadiusPanel p_chart;
        private Label l_intmale;
        private Label l_inttotalschool;
        private Label l_intfemale;
        private Label l_intabsent;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Support.RadiusPanel p_pie2;
        private Support.RadiusPanel p_pie1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pi_score;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pi_totalabsent;
        private Support.LabelCus labelCus2;
        private Support.LabelCus labelCus1;
        private Support.LabelCus labelCus3;
    }
}
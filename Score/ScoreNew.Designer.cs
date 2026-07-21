namespace WFEND.Score
{
    partial class ScoreNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreNew));
            panel1 = new Panel();
            b_Insert = new Support.RadiusButton();
            b_Close = new Support.RadiusButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            t_score3 = new TextBox();
            cb_Semester = new Support.ComboCus();
            label3 = new Label();
            t_score2 = new TextBox();
            cb_Subject = new Support.ComboCus();
            t_score1 = new TextBox();
            label2 = new Label();
            cb_Students = new Support.ComboCus();
            label1 = new Label();
            line1 = new Support.Line();
            L_Name = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(b_Insert);
            panel1.Controls.Add(b_Close);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(t_score3);
            panel1.Controls.Add(cb_Semester);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(t_score2);
            panel1.Controls.Add(cb_Subject);
            panel1.Controls.Add(t_score1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cb_Students);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(line1);
            panel1.Controls.Add(L_Name);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 387);
            panel1.TabIndex = 0;
            // 
            // b_Insert
            // 
            b_Insert.BackColor = SystemColors.Window;
            b_Insert.BackgroundColor = SystemColors.Window;
            b_Insert.BorderColor = Color.FromArgb(214, 219, 224);
            b_Insert.BorderRadius = 15;
            b_Insert.BorderSize = 1;
            b_Insert.FlatAppearance.BorderSize = 0;
            b_Insert.FlatStyle = FlatStyle.Flat;
            b_Insert.ForeColor = Color.White;
            b_Insert.Image = (Image)resources.GetObject("b_Insert.Image");
            b_Insert.Location = new Point(9, 5);
            b_Insert.Name = "b_Insert";
            b_Insert.Size = new Size(50, 50);
            b_Insert.TabIndex = 32;
            b_Insert.TextColor = Color.White;
            b_Insert.UseVisualStyleBackColor = false;
            b_Insert.Click += b_Insert_Click;
            // 
            // b_Close
            // 
            b_Close.BackColor = SystemColors.Window;
            b_Close.BackgroundColor = SystemColors.Window;
            b_Close.BorderColor = Color.FromArgb(214, 219, 224);
            b_Close.BorderRadius = 15;
            b_Close.BorderSize = 1;
            b_Close.FlatAppearance.BorderSize = 0;
            b_Close.FlatStyle = FlatStyle.Flat;
            b_Close.ForeColor = Color.White;
            b_Close.Image = (Image)resources.GetObject("b_Close.Image");
            b_Close.Location = new Point(676, 5);
            b_Close.Name = "b_Close";
            b_Close.Size = new Size(50, 50);
            b_Close.TabIndex = 31;
            b_Close.TextColor = Color.White;
            b_Close.UseVisualStyleBackColor = false;
            b_Close.Click += b_CloseRegi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(435, 273);
            label6.Name = "label6";
            label6.Size = new Size(82, 26);
            label6.TabIndex = 14;
            label6.Text = "Score 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(431, 182);
            label5.Name = "label5";
            label5.Size = new Size(82, 26);
            label5.TabIndex = 13;
            label5.Text = "Score 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(435, 94);
            label4.Name = "label4";
            label4.Size = new Size(82, 26);
            label4.TabIndex = 12;
            label4.Text = "Score 1";
            // 
            // t_score3
            // 
            t_score3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_score3.Location = new Point(431, 302);
            t_score3.Name = "t_score3";
            t_score3.Size = new Size(239, 30);
            t_score3.TabIndex = 11;
            // 
            // cb_Semester
            // 
            cb_Semester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Semester.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Semester.BackColor = Color.WhiteSmoke;
            cb_Semester.BorderColor = Color.MediumSlateBlue;
            cb_Semester.BorderSize = 1;
            cb_Semester.DropDownStyle = ComboBoxStyle.DropDown;
            cb_Semester.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Semester.ForeColor = Color.DimGray;
            cb_Semester.IconColor = Color.MediumSlateBlue;
            cb_Semester.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_Semester.ListTextColor = Color.DimGray;
            cb_Semester.Location = new Point(44, 299);
            cb_Semester.MinimumSize = new Size(200, 30);
            cb_Semester.Name = "cb_Semester";
            cb_Semester.Padding = new Padding(1);
            cb_Semester.Size = new Size(239, 30);
            cb_Semester.TabIndex = 10;
            cb_Semester.Texts = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 270);
            label3.Name = "label3";
            label3.Size = new Size(96, 26);
            label3.TabIndex = 9;
            label3.Text = "Semester";
            // 
            // t_score2
            // 
            t_score2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_score2.Location = new Point(431, 211);
            t_score2.Name = "t_score2";
            t_score2.Size = new Size(239, 30);
            t_score2.TabIndex = 8;
            // 
            // cb_Subject
            // 
            cb_Subject.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Subject.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Subject.BackColor = Color.WhiteSmoke;
            cb_Subject.BorderColor = Color.MediumSlateBlue;
            cb_Subject.BorderSize = 1;
            cb_Subject.DropDownStyle = ComboBoxStyle.DropDown;
            cb_Subject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Subject.ForeColor = Color.DimGray;
            cb_Subject.IconColor = Color.MediumSlateBlue;
            cb_Subject.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_Subject.ListTextColor = Color.DimGray;
            cb_Subject.Location = new Point(48, 208);
            cb_Subject.MinimumSize = new Size(200, 30);
            cb_Subject.Name = "cb_Subject";
            cb_Subject.Padding = new Padding(1);
            cb_Subject.Size = new Size(239, 30);
            cb_Subject.TabIndex = 7;
            cb_Subject.Texts = "";
            // 
            // t_score1
            // 
            t_score1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_score1.Location = new Point(431, 123);
            t_score1.Name = "t_score1";
            t_score1.Size = new Size(239, 30);
            t_score1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 179);
            label2.Name = "label2";
            label2.Size = new Size(81, 26);
            label2.TabIndex = 4;
            label2.Text = "Subject";
            // 
            // cb_Students
            // 
            cb_Students.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Students.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Students.BackColor = Color.WhiteSmoke;
            cb_Students.BorderColor = Color.MediumSlateBlue;
            cb_Students.BorderSize = 1;
            cb_Students.DropDownStyle = ComboBoxStyle.DropDown;
            cb_Students.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Students.ForeColor = Color.DimGray;
            cb_Students.IconColor = Color.MediumSlateBlue;
            cb_Students.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_Students.ListTextColor = Color.DimGray;
            cb_Students.Location = new Point(48, 120);
            cb_Students.MinimumSize = new Size(200, 30);
            cb_Students.Name = "cb_Students";
            cb_Students.Padding = new Padding(1);
            cb_Students.Size = new Size(239, 30);
            cb_Students.TabIndex = 3;
            cb_Students.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 91);
            label1.Name = "label1";
            label1.Size = new Size(92, 26);
            label1.TabIndex = 2;
            label1.Text = "Students";
            // 
            // line1
            // 
            line1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            line1.BackColor = Color.DimGray;
            line1.BorderWidth = 1;
            line1.Direction = Support.Line.EDIR.Horizontal;
            line1.DrawStyle = Support.Line.eStyle.Rect;
            line1.Location = new Point(-39, 56);
            line1.Name = "line1";
            line1.Size = new Size(771, 11);
            line1.TabIndex = 1;
            line1.Text = "line1";
            // 
            // L_Name
            // 
            L_Name.AutoSize = true;
            L_Name.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L_Name.Location = new Point(280, 12);
            L_Name.Name = "L_Name";
            L_Name.Size = new Size(170, 38);
            L_Name.TabIndex = 0;
            L_Name.Text = "New Score";
            // 
            // ScoreNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 71, 151);
            ClientSize = new Size(753, 408);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScoreNew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ScoreNew_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label L_Name;
        private Support.ComboCus cb_Students;
        private Label label1;
        private Support.Line line1;
        private TextBox t_score2;
        private Support.ComboCus cb_Subject;
        private TextBox t_score1;
        private Label label2;
        private TextBox t_score3;
        private Support.ComboCus cb_Semester;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Support.RadiusButton b_Close;
        private Support.RadiusButton b_Insert;
    }
}
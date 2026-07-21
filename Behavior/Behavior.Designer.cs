namespace WFEND.Behavior
{
    partial class Behavior
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            cb_Students = new WFEND.Support.ComboCus();
            cb_Class = new WFEND.Support.ComboCus();
            labelCus1 = new WFEND.Support.LabelCus();
            radiusPanel1 = new WFEND.Support.RadiusPanel();
            b_check = new WFEND.Support.RadiusButton();
            bt_submit = new WFEND.Support.RadiusButton();
            label9 = new Label();
            label8 = new Label();
            t_note = new TextBoxCustom();
            label7 = new Label();
            cb_behavior = new WFEND.Support.ComboCus();
            label6 = new Label();
            cb_semester = new WFEND.Support.ComboCus();
            label5 = new Label();
            Tab_data = new TabControl();
            tabPage1 = new TabPage();
            data_Show1 = new WFEND.Support.DataGridCus();
            tabPage2 = new TabPage();
            data_Show2 = new WFEND.Support.DataGridCus();
            DT_date = new WFEND.Support.CusDateTime();
            panel1.SuspendLayout();
            radiusPanel1.SuspendLayout();
            Tab_data.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(65, 71, 151);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 98);
            panel1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 28);
            label2.Name = "label2";
            label2.Size = new Size(161, 42);
            label2.TabIndex = 0;
            label2.Text = "Behavior";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(376, 114);
            label4.Name = "label4";
            label4.Size = new Size(116, 26);
            label4.TabIndex = 42;
            label4.Text = "* Students:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 41;
            label3.Text = "* Class:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 66);
            label1.Name = "label1";
            label1.Size = new Size(309, 19);
            label1.TabIndex = 40;
            label1.Text = "Select class, studentst, behavior, date time.";
            // 
            // cb_Students
            // 
            cb_Students.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_Students.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Students.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Students.BackColor = Color.WhiteSmoke;
            cb_Students.BorderColor = Color.MediumSlateBlue;
            cb_Students.BorderSize = 1;
            cb_Students.DropDownStyle = ComboBoxStyle.DropDown;
            cb_Students.Font = new Font("Segoe UI", 10F);
            cb_Students.ForeColor = Color.DimGray;
            cb_Students.IconColor = Color.MediumSlateBlue;
            cb_Students.Items.AddRange(new object[] { "" });
            cb_Students.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_Students.ListTextColor = Color.DimGray;
            cb_Students.Location = new Point(376, 143);
            cb_Students.MaximumSize = new Size(220, 35);
            cb_Students.MinimumSize = new Size(220, 35);
            cb_Students.Name = "cb_Students";
            cb_Students.Padding = new Padding(1);
            cb_Students.Size = new Size(220, 35);
            cb_Students.TabIndex = 37;
            cb_Students.Texts = "";
            // 
            // cb_Class
            // 
            cb_Class.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Class.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Class.BackColor = Color.WhiteSmoke;
            cb_Class.BorderColor = Color.MediumSlateBlue;
            cb_Class.BorderSize = 1;
            cb_Class.DropDownStyle = ComboBoxStyle.DropDown;
            cb_Class.Font = new Font("Segoe UI", 10F);
            cb_Class.ForeColor = Color.DimGray;
            cb_Class.IconColor = Color.MediumSlateBlue;
            cb_Class.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_Class.ListTextColor = Color.DimGray;
            cb_Class.Location = new Point(28, 142);
            cb_Class.MaximumSize = new Size(220, 35);
            cb_Class.MinimumSize = new Size(220, 35);
            cb_Class.Name = "cb_Class";
            cb_Class.Padding = new Padding(1);
            cb_Class.Size = new Size(220, 35);
            cb_Class.TabIndex = 36;
            cb_Class.Texts = "";
            cb_Class.OnSelectedIndexChanged += cb_Class_OnSelectedIndexChanged;
            // 
            // labelCus1
            // 
            labelCus1.Font = new Font("Times New Roman", 15F);
            labelCus1.font_size = 15;
            labelCus1.ForeColor = Color.Black;
            labelCus1.Location = new Point(29, 31);
            labelCus1.Name = "labelCus1";
            labelCus1.Size = new Size(176, 35);
            labelCus1.TabIndex = 0;
            labelCus1.Text = "Beharvior By";
            // 
            // radiusPanel1
            // 
            radiusPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radiusPanel1.BackColor = Color.FromArgb(255, 254, 254);
            radiusPanel1.BackgroundColor = Color.FromArgb(255, 254, 254);
            radiusPanel1.BorderColor = Color.FromArgb(191, 194, 196);
            radiusPanel1.BorderRadius = 5;
            radiusPanel1.BorderSize = 1;
            radiusPanel1.Controls.Add(b_check);
            radiusPanel1.Controls.Add(bt_submit);
            radiusPanel1.Controls.Add(label9);
            radiusPanel1.Controls.Add(label8);
            radiusPanel1.Controls.Add(t_note);
            radiusPanel1.Controls.Add(label7);
            radiusPanel1.Controls.Add(cb_behavior);
            radiusPanel1.Controls.Add(label6);
            radiusPanel1.Controls.Add(cb_semester);
            radiusPanel1.Controls.Add(label5);
            radiusPanel1.Controls.Add(DT_date);
            radiusPanel1.Controls.Add(label4);
            radiusPanel1.Controls.Add(label3);
            radiusPanel1.Controls.Add(label1);
            radiusPanel1.Controls.Add(cb_Students);
            radiusPanel1.Controls.Add(cb_Class);
            radiusPanel1.Controls.Add(labelCus1);
            radiusPanel1.ForeColor = Color.White;
            radiusPanel1.Location = new Point(50, 125);
            radiusPanel1.MaximumSize = new Size(631, 800);
            radiusPanel1.MinimumSize = new Size(631, 561);
            radiusPanel1.Name = "radiusPanel1";
            radiusPanel1.Size = new Size(631, 621);
            radiusPanel1.TabIndex = 29;
            radiusPanel1.TextColor = Color.White;
            // 
            // b_check
            // 
            b_check.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            b_check.BackColor = Color.MediumSlateBlue;
            b_check.BackgroundColor = Color.MediumSlateBlue;
            b_check.BorderColor = Color.FromArgb(189, 179, 246);
            b_check.BorderRadius = 10;
            b_check.BorderSize = 2;
            b_check.Cursor = Cursors.Hand;
            b_check.FlatAppearance.BorderSize = 0;
            b_check.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            b_check.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            b_check.FlatStyle = FlatStyle.Flat;
            b_check.ForeColor = Color.White;
            b_check.Location = new Point(390, 561);
            b_check.MouseDownBackColor = Color.CornflowerBlue;
            b_check.MouseOverBackColor = Color.LightBlue;
            b_check.Name = "b_check";
            b_check.Size = new Size(106, 45);
            b_check.TabIndex = 54;
            b_check.Text = "Check";
            b_check.TextColor = Color.White;
            b_check.UseVisualStyleBackColor = false;
            b_check.Click += b_check_Click;
            // 
            // bt_submit
            // 
            bt_submit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_submit.BackColor = Color.MediumSlateBlue;
            bt_submit.BackgroundColor = Color.MediumSlateBlue;
            bt_submit.BorderColor = Color.FromArgb(189, 179, 246);
            bt_submit.BorderRadius = 10;
            bt_submit.BorderSize = 2;
            bt_submit.Cursor = Cursors.Hand;
            bt_submit.FlatAppearance.BorderSize = 0;
            bt_submit.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            bt_submit.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            bt_submit.FlatStyle = FlatStyle.Flat;
            bt_submit.ForeColor = Color.White;
            bt_submit.Location = new Point(502, 561);
            bt_submit.MouseDownBackColor = Color.CornflowerBlue;
            bt_submit.MouseOverBackColor = Color.LightBlue;
            bt_submit.Name = "bt_submit";
            bt_submit.Size = new Size(106, 45);
            bt_submit.TabIndex = 53;
            bt_submit.Text = "Submit";
            bt_submit.TextColor = Color.White;
            bt_submit.UseVisualStyleBackColor = false;
            bt_submit.Click += bt_submit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(30, 380);
            label9.Name = "label9";
            label9.Size = new Size(203, 19);
            label9.TabIndex = 52;
            label9.Text = "Detailed behavioral profile";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(29, 341);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 51;
            label8.Text = "Note:";
            // 
            // t_note
            // 
            t_note.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            t_note.AutoSize = true;
            t_note.BackColor = SystemColors.Window;
            t_note.BorderColor = Color.Black;
            t_note.BorderFocusColor = Color.Black;
            t_note.BorderRadius = 0;
            t_note.BorderSize = 1;
            t_note.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_note.ForeColor = Color.DimGray;
            t_note.Location = new Point(31, 403);
            t_note.Margin = new Padding(4);
            t_note.Multiline = true;
            t_note.Name = "t_note";
            t_note.Padding = new Padding(7);
            t_note.PasswordChar = false;
            t_note.PlaceholderColor = Color.DarkGray;
            t_note.PlaceholderText = "";
            t_note.Size = new Size(577, 143);
            t_note.TabIndex = 50;
            t_note.Texts = "";
            t_note.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(376, 219);
            label7.Name = "label7";
            label7.Size = new Size(120, 26);
            label7.TabIndex = 49;
            label7.Text = "* Behavior:";
            // 
            // cb_behavior
            // 
            cb_behavior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_behavior.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_behavior.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_behavior.BackColor = Color.WhiteSmoke;
            cb_behavior.BorderColor = Color.MediumSlateBlue;
            cb_behavior.BorderSize = 1;
            cb_behavior.DropDownStyle = ComboBoxStyle.DropDown;
            cb_behavior.Font = new Font("Segoe UI", 10F);
            cb_behavior.ForeColor = Color.DimGray;
            cb_behavior.IconColor = Color.MediumSlateBlue;
            cb_behavior.Items.AddRange(new object[] { "Vô lễ với giáo viên", "Không mặc đồng phục", "Đi học muộn", "Khiêu khích, đánh nhau", "Không làm bài tập" });
            cb_behavior.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_behavior.ListTextColor = Color.DimGray;
            cb_behavior.Location = new Point(376, 248);
            cb_behavior.MaximumSize = new Size(220, 35);
            cb_behavior.MinimumSize = new Size(220, 35);
            cb_behavior.Name = "cb_behavior";
            cb_behavior.Padding = new Padding(1);
            cb_behavior.Size = new Size(220, 35);
            cb_behavior.TabIndex = 48;
            cb_behavior.Texts = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(28, 219);
            label6.Name = "label6";
            label6.Size = new Size(120, 26);
            label6.TabIndex = 47;
            label6.Text = "* Semester:";
            // 
            // cb_semester
            // 
            cb_semester.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_semester.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_semester.BackColor = Color.WhiteSmoke;
            cb_semester.BorderColor = Color.MediumSlateBlue;
            cb_semester.BorderSize = 1;
            cb_semester.DropDownStyle = ComboBoxStyle.DropDown;
            cb_semester.Font = new Font("Segoe UI", 10F);
            cb_semester.ForeColor = Color.DimGray;
            cb_semester.IconColor = Color.MediumSlateBlue;
            cb_semester.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_semester.ListTextColor = Color.DimGray;
            cb_semester.Location = new Point(28, 248);
            cb_semester.MaximumSize = new Size(220, 35);
            cb_semester.MinimumSize = new Size(220, 35);
            cb_semester.Name = "cb_semester";
            cb_semester.Padding = new Padding(1);
            cb_semester.Size = new Size(220, 35);
            cb_semester.TabIndex = 46;
            cb_semester.Texts = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(376, 314);
            label5.Name = "label5";
            label5.Size = new Size(78, 26);
            label5.TabIndex = 45;
            label5.Text = "* Date:";
            // 
            // Tab_data
            // 
            Tab_data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tab_data.Controls.Add(tabPage1);
            Tab_data.Controls.Add(tabPage2);
            Tab_data.Location = new Point(705, 125);
            Tab_data.Name = "Tab_data";
            Tab_data.SelectedIndex = 0;
            Tab_data.Size = new Size(873, 623);
            Tab_data.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(data_Show1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(865, 585);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Log";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // data_Show1
            // 
            data_Show1.AllowUserToAddRows = false;
            data_Show1.AllowUserToDeleteRows = false;
            data_Show1.AllowUserToOrderColumns = true;
            data_Show1.AllowUserToResizeColumns = false;
            data_Show1.AllowUserToResizeRows = false;
            data_Show1.AlternateRowColors = true;
            data_Show1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Show1.BackgroundColor = SystemColors.Window;
            data_Show1.BorderColor = Color.FromArgb(100, 191, 194, 196);
            data_Show1.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Show1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Show1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Show1.DefaultCellStyle = dataGridViewCellStyle2;
            data_Show1.Dock = DockStyle.Fill;
            data_Show1.EditMode = DataGridViewEditMode.EditOnEnter;
            data_Show1.FirstRowColor = Color.FromArgb(249, 249, 248);
            data_Show1.GridColor = SystemColors.Window;
            data_Show1.Location = new Point(3, 3);
            data_Show1.Name = "data_Show1";
            data_Show1.Opacity = 100;
            data_Show1.ReadOnly = true;
            data_Show1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Show1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Show1.RowHeadersVisible = false;
            data_Show1.RowHeadersWidth = 51;
            data_Show1.SecondRowColor = Color.FromArgb(242, 242, 242);
            data_Show1.SelectedCellColor = Color.FromArgb(117, 215, 222);
            data_Show1.SelectedTextColor = Color.Black;
            data_Show1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Show1.Size = new Size(859, 579);
            data_Show1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(data_Show2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(865, 590);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Summary";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // data_Show2
            // 
            data_Show2.AllowUserToAddRows = false;
            data_Show2.AllowUserToDeleteRows = false;
            data_Show2.AllowUserToOrderColumns = true;
            data_Show2.AllowUserToResizeColumns = false;
            data_Show2.AllowUserToResizeRows = false;
            data_Show2.AlternateRowColors = true;
            data_Show2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Show2.BackgroundColor = SystemColors.Window;
            data_Show2.BorderColor = Color.FromArgb(100, 191, 194, 196);
            data_Show2.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            data_Show2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            data_Show2.ColumnHeadersHeight = 50;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            data_Show2.DefaultCellStyle = dataGridViewCellStyle5;
            data_Show2.Dock = DockStyle.Fill;
            data_Show2.EditMode = DataGridViewEditMode.EditOnEnter;
            data_Show2.FirstRowColor = Color.FromArgb(249, 249, 248);
            data_Show2.GridColor = SystemColors.Window;
            data_Show2.Location = new Point(3, 3);
            data_Show2.Name = "data_Show2";
            data_Show2.Opacity = 100;
            data_Show2.ReadOnly = true;
            data_Show2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            data_Show2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            data_Show2.RowHeadersVisible = false;
            data_Show2.RowHeadersWidth = 51;
            data_Show2.SecondRowColor = Color.FromArgb(242, 242, 242);
            data_Show2.SelectedCellColor = Color.FromArgb(117, 215, 222);
            data_Show2.SelectedTextColor = Color.Black;
            data_Show2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Show2.Size = new Size(859, 584);
            data_Show2.TabIndex = 1;
            // 
            // DT_date
            // 
            DT_date.BorderColor = Color.PaleVioletRed;
            DT_date.BorderSize = 0;
            DT_date.Font = new Font("Segoe UI", 9.5F);
            DT_date.Format = DateTimePickerFormat.Short;
            DT_date.Location = new Point(373, 342);
            DT_date.MaximumSize = new Size(220, 35);
            DT_date.MinimumSize = new Size(220, 35);
            DT_date.Name = "DT_date";
            DT_date.Size = new Size(220, 35);
            DT_date.SkinColor = Color.MediumSlateBlue;
            DT_date.TabIndex = 44;
            DT_date.TextColor = Color.White;
            // 
            // Behavior
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1600, 760);
            Controls.Add(panel1);
            Controls.Add(Tab_data);
            Controls.Add(radiusPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 700);
            Name = "Behavior";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            radiusPanel1.ResumeLayout(false);
            radiusPanel1.PerformLayout();
            Tab_data.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Show1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Show2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Support.ComboCus cb_Students;
        private Support.ComboCus cb_Class;
        private Support.LabelCus labelCus1;
        private Support.RadiusPanel radiusPanel1;
        private Label label2;
        private Label label6;
        private Support.ComboCus cb_semester;
        private Label label5;
        private TextBoxCustom t_note;
        private Label label7;
        private Support.ComboCus cb_behavior;
        private Label label8;
        private Label label9;
        private TabControl Tab_data;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Support.DataGridCus data_Show1;
        private Support.DataGridCus data_Show2;
        private Support.RadiusButton bt_submit;
        private Support.RadiusButton b_check;
        private Support.CusDateTime DT_date;
    }
}
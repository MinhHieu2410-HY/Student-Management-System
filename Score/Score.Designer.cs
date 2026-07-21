namespace WFEND.Score
{
    partial class Score
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox2 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            p_data = new Panel();
            P_Export = new Panel();
            panel5 = new Panel();
            B_cancel = new Button();
            B_accept = new Button();
            pdf = new Button();
            csv = new Button();
            xls = new Button();
            docx = new Button();
            label1 = new Label();
            data_Show = new WFEND.Support.DataGridCus();
            ChangeSize = new System.Windows.Forms.Timer(components);
            p_Filter = new Panel();
            line1 = new WFEND.Support.Line();
            tb_Search = new TextBoxCustom();
            bt_Onfil = new WFEND.Support.RadiusButton();
            line6 = new WFEND.Support.Line();
            line5 = new WFEND.Support.Line();
            panel4 = new Panel();
            cb_semester = new WFEND.Support.ComboCus();
            line7 = new WFEND.Support.Line();
            labelCus3 = new WFEND.Support.LabelCus();
            panel3 = new Panel();
            cb_subject = new WFEND.Support.ComboCus();
            labelCus2 = new WFEND.Support.LabelCus();
            panel2 = new Panel();
            CB_Class = new WFEND.Support.ComboCus();
            labelCus1 = new WFEND.Support.LabelCus();
            B_Reset = new WFEND.Support.RadiusButton();
            t_filter = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            B_Print = new WFEND.Support.RadiusButton();
            radiusButton1 = new WFEND.Support.RadiusButton();
            b_new = new WFEND.Support.RadiusButton();
            contextMenuStrip1.SuspendLayout();
            p_data.SuspendLayout();
            P_Export.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show).BeginInit();
            p_Filter.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(61, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 32);
            textBox2.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // p_data
            // 
            p_data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_data.AutoSize = true;
            p_data.Controls.Add(P_Export);
            p_data.Controls.Add(data_Show);
            p_data.Location = new Point(12, 104);
            p_data.MaximumSize = new Size(1626, 800);
            p_data.Name = "p_data";
            p_data.Size = new Size(1618, 797);
            p_data.TabIndex = 24;
            // 
            // P_Export
            // 
            P_Export.BackColor = Color.FromArgb(65, 71, 151);
            P_Export.Controls.Add(panel5);
            P_Export.Location = new Point(484, 215);
            P_Export.Name = "P_Export";
            P_Export.Size = new Size(646, 322);
            P_Export.TabIndex = 6;
            P_Export.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(B_cancel);
            panel5.Controls.Add(B_accept);
            panel5.Controls.Add(pdf);
            panel5.Controls.Add(csv);
            panel5.Controls.Add(xls);
            panel5.Controls.Add(docx);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(17, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(613, 293);
            panel5.TabIndex = 0;
            // 
            // B_cancel
            // 
            B_cancel.Font = new Font("Times New Roman", 12F);
            B_cancel.Location = new Point(428, 236);
            B_cancel.Name = "B_cancel";
            B_cancel.Size = new Size(79, 43);
            B_cancel.TabIndex = 8;
            B_cancel.Text = "Cancel";
            B_cancel.UseVisualStyleBackColor = true;
            B_cancel.Click += B_cancel_Click;
            // 
            // B_accept
            // 
            B_accept.Font = new Font("Times New Roman", 12F);
            B_accept.Location = new Point(513, 236);
            B_accept.Name = "B_accept";
            B_accept.Size = new Size(79, 43);
            B_accept.TabIndex = 7;
            B_accept.Text = "Export";
            B_accept.UseVisualStyleBackColor = true;
            B_accept.Click += B_accept_Click;
            // 
            // pdf
            // 
            pdf.Font = new Font("Times New Roman", 13.2000008F);
            pdf.Image = (Image)resources.GetObject("pdf.Image");
            pdf.ImageAlign = ContentAlignment.MiddleLeft;
            pdf.Location = new Point(310, 150);
            pdf.Name = "pdf";
            pdf.Size = new Size(284, 74);
            pdf.TabIndex = 5;
            pdf.Text = "File.pdf";
            pdf.UseVisualStyleBackColor = true;
            pdf.Click += Button_Click;
            // 
            // csv
            // 
            csv.Font = new Font("Times New Roman", 13.2000008F);
            csv.Image = (Image)resources.GetObject("csv.Image");
            csv.ImageAlign = ContentAlignment.MiddleLeft;
            csv.Location = new Point(20, 150);
            csv.Name = "csv";
            csv.Size = new Size(284, 74);
            csv.TabIndex = 4;
            csv.Text = "Text.csv";
            csv.UseVisualStyleBackColor = true;
            csv.Click += Button_Click;
            // 
            // xls
            // 
            xls.Font = new Font("Times New Roman", 13.2000008F);
            xls.Image = (Image)resources.GetObject("xls.Image");
            xls.ImageAlign = ContentAlignment.MiddleLeft;
            xls.Location = new Point(310, 70);
            xls.Name = "xls";
            xls.Size = new Size(284, 74);
            xls.TabIndex = 3;
            xls.Text = "Excel.xls";
            xls.UseVisualStyleBackColor = true;
            xls.Click += Button_Click;
            // 
            // docx
            // 
            docx.BackgroundImageLayout = ImageLayout.None;
            docx.Font = new Font("Times New Roman", 13.2000008F);
            docx.Image = (Image)resources.GetObject("docx.Image");
            docx.ImageAlign = ContentAlignment.MiddleLeft;
            docx.Location = new Point(20, 70);
            docx.Name = "docx";
            docx.Size = new Size(284, 74);
            docx.TabIndex = 2;
            docx.Text = "Worl.docx";
            docx.UseVisualStyleBackColor = true;
            docx.Click += Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(134, 33);
            label1.TabIndex = 0;
            label1.Text = "Type File: ";
            // 
            // data_Show
            // 
            data_Show.AllowUserToAddRows = false;
            data_Show.AllowUserToDeleteRows = false;
            data_Show.AllowUserToOrderColumns = true;
            data_Show.AllowUserToResizeColumns = false;
            data_Show.AllowUserToResizeRows = false;
            data_Show.AlternateRowColors = true;
            data_Show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_Show.BackgroundColor = SystemColors.Window;
            data_Show.BorderColor = Color.FromArgb(100, 212, 212, 212);
            data_Show.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Show.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Show.DefaultCellStyle = dataGridViewCellStyle2;
            data_Show.Dock = DockStyle.Fill;
            data_Show.EditMode = DataGridViewEditMode.EditOnEnter;
            data_Show.FirstRowColor = Color.FromArgb(249, 249, 248);
            data_Show.Location = new Point(0, 0);
            data_Show.Name = "data_Show";
            data_Show.Opacity = 100;
            data_Show.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Show.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Show.RowHeadersVisible = false;
            data_Show.RowHeadersWidth = 51;
            data_Show.SecondRowColor = Color.FromArgb(242, 242, 242);
            data_Show.SelectedCellColor = Color.FromArgb(117, 215, 222);
            data_Show.SelectedTextColor = Color.Black;
            data_Show.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Show.Size = new Size(1618, 797);
            data_Show.TabIndex = 0;
            data_Show.CellEnter += data_Show_CellEnter;
            data_Show.CellMouseDoubleClick += data_Show_CellMouseDoubleClick_1;
            data_Show.CellValueChanged += data_Show_CellValueChanged;
            data_Show.MouseDown += data_Show_MouseDown;
            // 
            // ChangeSize
            // 
            ChangeSize.Tick += ChangeSize_Tick;
            // 
            // p_Filter
            // 
            p_Filter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_Filter.BackColor = SystemColors.Window;
            p_Filter.BorderStyle = BorderStyle.FixedSingle;
            p_Filter.Controls.Add(line1);
            p_Filter.Controls.Add(tb_Search);
            p_Filter.Controls.Add(bt_Onfil);
            p_Filter.Controls.Add(line6);
            p_Filter.Controls.Add(line5);
            p_Filter.Controls.Add(panel4);
            p_Filter.Controls.Add(panel3);
            p_Filter.Controls.Add(panel2);
            p_Filter.Location = new Point(12, 104);
            p_Filter.MaximumSize = new Size(1625, 51);
            p_Filter.MinimumSize = new Size(1618, 51);
            p_Filter.Name = "p_Filter";
            p_Filter.Size = new Size(1618, 51);
            p_Filter.TabIndex = 25;
            // 
            // line1
            // 
            line1.BackColor = Color.Black;
            line1.BorderWidth = 1;
            line1.Direction = Support.Line.EDIR.Vertical;
            line1.DrawStyle = Support.Line.eStyle.Rect;
            line1.IsVertical = true;
            line1.Location = new Point(278, -1);
            line1.Name = "line1";
            line1.Size = new Size(11, 50);
            line1.TabIndex = 12;
            line1.Text = "line1";
            // 
            // tb_Search
            // 
            tb_Search.BackColor = SystemColors.Window;
            tb_Search.BorderColor = Color.White;
            tb_Search.BorderFocusColor = Color.Black;
            tb_Search.BorderRadius = 0;
            tb_Search.BorderSize = 2;
            tb_Search.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_Search.ForeColor = Color.DimGray;
            tb_Search.Location = new Point(62, 7);
            tb_Search.Margin = new Padding(4);
            tb_Search.Multiline = false;
            tb_Search.Name = "tb_Search";
            tb_Search.Padding = new Padding(7);
            tb_Search.PasswordChar = false;
            tb_Search.PlaceholderColor = Color.DarkGray;
            tb_Search.PlaceholderText = "";
            tb_Search.Size = new Size(218, 35);
            tb_Search.TabIndex = 11;
            tb_Search.Texts = "";
            tb_Search.UnderlinedStyle = false;
            // 
            // bt_Onfil
            // 
            bt_Onfil.BackColor = Color.FromArgb(75, 73, 147);
            bt_Onfil.BackgroundColor = Color.FromArgb(75, 73, 147);
            bt_Onfil.BorderColor = Color.White;
            bt_Onfil.BorderRadius = 0;
            bt_Onfil.BorderSize = 0;
            bt_Onfil.Dock = DockStyle.Left;
            bt_Onfil.FlatAppearance.BorderSize = 0;
            bt_Onfil.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            bt_Onfil.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            bt_Onfil.FlatStyle = FlatStyle.Flat;
            bt_Onfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Onfil.ForeColor = Color.White;
            bt_Onfil.Image = (Image)resources.GetObject("bt_Onfil.Image");
            bt_Onfil.Location = new Point(0, 0);
            bt_Onfil.MouseDownBackColor = Color.CornflowerBlue;
            bt_Onfil.MouseOverBackColor = Color.LightBlue;
            bt_Onfil.Name = "bt_Onfil";
            bt_Onfil.Size = new Size(55, 49);
            bt_Onfil.TabIndex = 10;
            bt_Onfil.TextColor = Color.White;
            bt_Onfil.UseVisualStyleBackColor = false;
            bt_Onfil.Click += radiusButton2_Click;
            // 
            // line6
            // 
            line6.BackColor = Color.Black;
            line6.BorderWidth = 1;
            line6.Direction = Support.Line.EDIR.Vertical;
            line6.DrawStyle = Support.Line.eStyle.Rect;
            line6.IsVertical = true;
            line6.Location = new Point(1118, -1);
            line6.Name = "line6";
            line6.Size = new Size(11, 50);
            line6.TabIndex = 9;
            line6.Text = "line6";
            // 
            // line5
            // 
            line5.BackColor = Color.Black;
            line5.BorderWidth = 1;
            line5.Direction = Support.Line.EDIR.Vertical;
            line5.DrawStyle = Support.Line.eStyle.Rect;
            line5.IsVertical = true;
            line5.Location = new Point(674, 0);
            line5.Name = "line5";
            line5.Size = new Size(11, 50);
            line5.TabIndex = 8;
            line5.Text = "line5";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(cb_semester);
            panel4.Controls.Add(line7);
            panel4.Controls.Add(labelCus3);
            panel4.Location = new Point(1235, 0);
            panel4.MaximumSize = new Size(0, 50);
            panel4.MinimumSize = new Size(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 50);
            panel4.TabIndex = 7;
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
            cb_semester.Location = new Point(113, 7);
            cb_semester.MinimumSize = new Size(200, 30);
            cb_semester.Name = "cb_semester";
            cb_semester.Padding = new Padding(1);
            cb_semester.Size = new Size(211, 37);
            cb_semester.TabIndex = 37;
            cb_semester.Texts = "";
            // 
            // line7
            // 
            line7.BackColor = Color.Black;
            line7.BorderWidth = 1;
            line7.Direction = Support.Line.EDIR.Vertical;
            line7.DrawStyle = Support.Line.eStyle.Rect;
            line7.IsVertical = true;
            line7.Location = new Point(325, 0);
            line7.Name = "line7";
            line7.Size = new Size(11, 50);
            line7.TabIndex = 9;
            line7.Text = "line7";
            // 
            // labelCus3
            // 
            labelCus3.BackColor = Color.FromArgb(75, 73, 147);
            labelCus3.Dock = DockStyle.Left;
            labelCus3.Font = new Font("Times New Roman", 15F);
            labelCus3.font_size = 15;
            labelCus3.ForeColor = Color.White;
            labelCus3.Location = new Point(0, 0);
            labelCus3.Name = "labelCus3";
            labelCus3.Size = new Size(107, 50);
            labelCus3.TabIndex = 1;
            labelCus3.Text = "Semester";
            labelCus3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(cb_subject);
            panel3.Controls.Add(labelCus2);
            panel3.Location = new Point(793, 0);
            panel3.MaximumSize = new Size(0, 50);
            panel3.MinimumSize = new Size(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 50);
            panel3.TabIndex = 5;
            // 
            // cb_subject
            // 
            cb_subject.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_subject.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_subject.BackColor = Color.WhiteSmoke;
            cb_subject.BorderColor = Color.MediumSlateBlue;
            cb_subject.BorderSize = 1;
            cb_subject.DropDownStyle = ComboBoxStyle.DropDown;
            cb_subject.Font = new Font("Segoe UI", 10F);
            cb_subject.ForeColor = Color.DimGray;
            cb_subject.IconColor = Color.MediumSlateBlue;
            cb_subject.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_subject.ListTextColor = Color.DimGray;
            cb_subject.Location = new Point(93, 7);
            cb_subject.MinimumSize = new Size(200, 30);
            cb_subject.Name = "cb_subject";
            cb_subject.Padding = new Padding(1);
            cb_subject.Size = new Size(234, 37);
            cb_subject.TabIndex = 37;
            cb_subject.Texts = "";
            // 
            // labelCus2
            // 
            labelCus2.BackColor = Color.FromArgb(75, 73, 147);
            labelCus2.Dock = DockStyle.Left;
            labelCus2.Font = new Font("Times New Roman", 15F);
            labelCus2.font_size = 15;
            labelCus2.ForeColor = Color.White;
            labelCus2.Location = new Point(0, 0);
            labelCus2.Name = "labelCus2";
            labelCus2.Size = new Size(90, 50);
            labelCus2.TabIndex = 1;
            labelCus2.Text = "Subject";
            labelCus2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(CB_Class);
            panel2.Controls.Add(labelCus1);
            panel2.Location = new Point(349, 0);
            panel2.MaximumSize = new Size(0, 50);
            panel2.MinimumSize = new Size(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 50);
            panel2.TabIndex = 4;
            // 
            // CB_Class
            // 
            CB_Class.AutoCompleteMode = AutoCompleteMode.Suggest;
            CB_Class.AutoCompleteSource = AutoCompleteSource.ListItems;
            CB_Class.BackColor = Color.WhiteSmoke;
            CB_Class.BorderColor = Color.MediumSlateBlue;
            CB_Class.BorderSize = 1;
            CB_Class.DropDownStyle = ComboBoxStyle.DropDown;
            CB_Class.Font = new Font("Segoe UI", 10F);
            CB_Class.ForeColor = Color.DimGray;
            CB_Class.IconColor = Color.MediumSlateBlue;
            CB_Class.ListBackColor = Color.FromArgb(230, 228, 245);
            CB_Class.ListTextColor = Color.DimGray;
            CB_Class.Location = new Point(85, 7);
            CB_Class.MinimumSize = new Size(200, 30);
            CB_Class.Name = "CB_Class";
            CB_Class.Padding = new Padding(1);
            CB_Class.Size = new Size(234, 37);
            CB_Class.TabIndex = 36;
            CB_Class.Texts = "";
            // 
            // labelCus1
            // 
            labelCus1.BackColor = Color.FromArgb(75, 73, 147);
            labelCus1.Dock = DockStyle.Left;
            labelCus1.Font = new Font("Times New Roman", 17F);
            labelCus1.font_size = 17;
            labelCus1.ForeColor = Color.White;
            labelCus1.Location = new Point(0, 0);
            labelCus1.Name = "labelCus1";
            labelCus1.Size = new Size(79, 50);
            labelCus1.TabIndex = 0;
            labelCus1.Text = "Class";
            labelCus1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // B_Reset
            // 
            B_Reset.BackColor = Color.FromArgb(85, 88, 197);
            B_Reset.BackgroundColor = Color.FromArgb(85, 88, 197);
            B_Reset.BorderColor = Color.White;
            B_Reset.BorderRadius = 10;
            B_Reset.BorderSize = 2;
            B_Reset.FlatAppearance.BorderSize = 0;
            B_Reset.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            B_Reset.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            B_Reset.FlatStyle = FlatStyle.Flat;
            B_Reset.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Reset.ForeColor = Color.White;
            B_Reset.Image = (Image)resources.GetObject("B_Reset.Image");
            B_Reset.Location = new Point(1571, 19);
            B_Reset.MouseDownBackColor = Color.CornflowerBlue;
            B_Reset.MouseOverBackColor = Color.LightBlue;
            B_Reset.Name = "B_Reset";
            B_Reset.Size = new Size(55, 50);
            B_Reset.TabIndex = 13;
            B_Reset.TextColor = Color.White;
            B_Reset.UseVisualStyleBackColor = false;
            B_Reset.Click += B_Reset_Click;
            // 
            // t_filter
            // 
            t_filter.BorderStyle = BorderStyle.None;
            t_filter.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_filter.Location = new Point(61, 12);
            t_filter.Name = "t_filter";
            t_filter.Size = new Size(153, 23);
            t_filter.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 27);
            label2.Name = "label2";
            label2.Size = new Size(243, 42);
            label2.TabIndex = 0;
            label2.Text = "Manage Score";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(65, 71, 151);
            panel1.Controls.Add(B_Reset);
            panel1.Controls.Add(B_Print);
            panel1.Controls.Add(radiusButton1);
            panel1.Controls.Add(b_new);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 98);
            panel1.TabIndex = 23;
            // 
            // B_Print
            // 
            B_Print.BackColor = Color.FromArgb(85, 88, 197);
            B_Print.BackgroundColor = Color.FromArgb(85, 88, 197);
            B_Print.BorderColor = Color.White;
            B_Print.BorderRadius = 10;
            B_Print.BorderSize = 2;
            B_Print.FlatAppearance.BorderSize = 0;
            B_Print.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            B_Print.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            B_Print.FlatStyle = FlatStyle.Flat;
            B_Print.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Print.ForeColor = Color.White;
            B_Print.Location = new Point(1414, 19);
            B_Print.MaximumSize = new Size(75, 50);
            B_Print.MinimumSize = new Size(75, 50);
            B_Print.MouseDownBackColor = Color.CornflowerBlue;
            B_Print.MouseOverBackColor = Color.LightBlue;
            B_Print.Name = "B_Print";
            B_Print.Size = new Size(75, 50);
            B_Print.TabIndex = 26;
            B_Print.Text = "Print";
            B_Print.TextColor = Color.White;
            B_Print.UseVisualStyleBackColor = false;
            B_Print.Click += B_Print_Click;
            // 
            // radiusButton1
            // 
            radiusButton1.BackColor = Color.FromArgb(85, 88, 197);
            radiusButton1.BackgroundColor = Color.FromArgb(85, 88, 197);
            radiusButton1.BorderColor = Color.White;
            radiusButton1.BorderRadius = 10;
            radiusButton1.BorderSize = 2;
            radiusButton1.FlatAppearance.BorderSize = 0;
            radiusButton1.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton1.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            radiusButton1.FlatStyle = FlatStyle.Flat;
            radiusButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiusButton1.ForeColor = Color.White;
            radiusButton1.Location = new Point(1492, 19);
            radiusButton1.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton1.MouseOverBackColor = Color.LightBlue;
            radiusButton1.Name = "radiusButton1";
            radiusButton1.Size = new Size(75, 50);
            radiusButton1.TabIndex = 3;
            radiusButton1.Text = "Add";
            radiusButton1.TextColor = Color.White;
            radiusButton1.UseVisualStyleBackColor = false;
            radiusButton1.Click += b_new_Click;
            // 
            // b_new
            // 
            b_new.BackColor = Color.FromArgb(85, 88, 197);
            b_new.BackgroundColor = Color.FromArgb(85, 88, 197);
            b_new.BorderColor = Color.White;
            b_new.BorderRadius = 10;
            b_new.BorderSize = 2;
            b_new.FlatAppearance.BorderSize = 0;
            b_new.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            b_new.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            b_new.FlatStyle = FlatStyle.Flat;
            b_new.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_new.ForeColor = Color.White;
            b_new.Image = (Image)resources.GetObject("b_new.Image");
            b_new.Location = new Point(1356, 19);
            b_new.MouseDownBackColor = Color.CornflowerBlue;
            b_new.MouseOverBackColor = Color.LightBlue;
            b_new.Name = "b_new";
            b_new.Size = new Size(55, 50);
            b_new.TabIndex = 2;
            b_new.TextColor = Color.White;
            b_new.UseVisualStyleBackColor = false;
            b_new.Click += Search_Click;
            // 
            // Score
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 913);
            Controls.Add(p_data);
            Controls.Add(p_Filter);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Score";
            Text = "Score";
            Load += Score_Load;
            contextMenuStrip1.ResumeLayout(false);
            p_data.ResumeLayout(false);
            P_Export.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show).EndInit();
            p_Filter.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel p_data;
        private System.Windows.Forms.Timer ChangeSize;
        private Panel p_Filter;
        private Support.RadiusPanel _filter;
        private TextBox t_filter;
        private Support.RadiusButton b_filter;
        private Support.Line line1;
        private Label label2;
        private Support.RadiusButton b_new;
        private Support.RadiusButton Search;
        private Panel panel1;
        private Panel panel2;
        private Support.ComboCus cb_filClass;
        private Panel panel4;
        private Support.ComboCus cb_filsemester;
        private Panel panel3;
        private Support.ComboCus cb_filsebject;
        private Support.LabelCus labelCus1;
        private Support.LabelCus labelCus3;
        private Support.LabelCus labelCus2;
        private Support.Line line2;
        private Support.Line line4;
        private Support.Line line3;
        private Support.DataGridCus data_Show;
        private Support.RadiusButton radiusButton1;
        private Support.Line line6;
        private Support.Line line5;
        private Support.Line line7;
        private TextBoxCustom tb_Search;
        private Support.RadiusButton bt_Onfil;
        private Support.ComboCus cb_semester;
        private Support.ComboCus cb_subject;
        private Support.ComboCus CB_Class;
        private Support.RadiusButton B_Reset;
        private Support.RadiusButton B_Print;
        private Panel P_Export;
        private Panel panel5;
        private Button B_cancel;
        private Button B_accept;
        private Button pdf;
        private Button csv;
        private Button xls;
        private Button docx;
        private Label label1;
    }
}
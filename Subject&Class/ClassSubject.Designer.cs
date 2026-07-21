namespace WFEND.Subject_Class
{
    partial class ClassSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSubject));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            p_head = new Panel();
            p_searchadd = new Panel();
            radiusPanel2 = new WFEND.Support.RadiusPanel();
            textBox2 = new TextBox();
            Search = new WFEND.Support.RadiusButton();
            l_name = new WFEND.Support.LabelCus();
            b_new = new WFEND.Support.RadiusButton();
            p_SubjectClass = new Panel();
            data_Show = new WFEND.Support.DataGridCus();
            radiusPanel1 = new WFEND.Support.RadiusPanel();
            radiusButton1 = new WFEND.Support.RadiusButton();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            Cb_subject = new WFEND.Support.ComboCus();
            CB_Class = new WFEND.Support.ComboCus();
            labelCus1 = new WFEND.Support.LabelCus();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            p_head.SuspendLayout();
            p_searchadd.SuspendLayout();
            radiusPanel2.SuspendLayout();
            p_SubjectClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show).BeginInit();
            radiusPanel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // p_head
            // 
            p_head.BackColor = Color.FromArgb(65, 71, 151);
            p_head.Controls.Add(p_searchadd);
            p_head.Controls.Add(l_name);
            p_head.Dock = DockStyle.Top;
            p_head.Location = new Point(0, 0);
            p_head.MinimumSize = new Size(1093, 84);
            p_head.Name = "p_head";
            p_head.Size = new Size(1236, 84);
            p_head.TabIndex = 4;
            // 
            // p_searchadd
            // 
            p_searchadd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            p_searchadd.Controls.Add(radiusPanel2);
            p_searchadd.Location = new Point(988, 14);
            p_searchadd.Name = "p_searchadd";
            p_searchadd.Size = new Size(232, 52);
            p_searchadd.TabIndex = 7;
            // 
            // radiusPanel2
            // 
            radiusPanel2.BackColor = SystemColors.Window;
            radiusPanel2.BackgroundColor = SystemColors.Window;
            radiusPanel2.BorderColor = Color.White;
            radiusPanel2.BorderRadius = 5;
            radiusPanel2.BorderSize = 2;
            radiusPanel2.BorderStyle = BorderStyle.FixedSingle;
            radiusPanel2.Controls.Add(textBox2);
            radiusPanel2.Controls.Add(Search);
            radiusPanel2.Dock = DockStyle.Left;
            radiusPanel2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiusPanel2.ForeColor = Color.White;
            radiusPanel2.Location = new Point(0, 0);
            radiusPanel2.MaximumSize = new Size(229, 50);
            radiusPanel2.MinimumSize = new Size(229, 50);
            radiusPanel2.Name = "radiusPanel2";
            radiusPanel2.Size = new Size(229, 50);
            radiusPanel2.TabIndex = 4;
            radiusPanel2.TextColor = Color.White;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(61, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // Search
            // 
            Search.BackColor = Color.MediumSlateBlue;
            Search.BackgroundColor = Color.MediumSlateBlue;
            Search.BorderColor = Color.PaleVioletRed;
            Search.BorderRadius = 0;
            Search.BorderSize = 0;
            Search.FlatAppearance.BorderSize = 0;
            Search.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            Search.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            Search.FlatStyle = FlatStyle.Flat;
            Search.ForeColor = Color.White;
            Search.Image = (Image)resources.GetObject("Search.Image");
            Search.Location = new Point(0, 0);
            Search.MouseDownBackColor = Color.CornflowerBlue;
            Search.MouseOverBackColor = Color.LightBlue;
            Search.Name = "Search";
            Search.Size = new Size(55, 48);
            Search.TabIndex = 1;
            Search.TextColor = Color.White;
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // l_name
            // 
            l_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            l_name.Font = new Font("Times New Roman", 21F);
            l_name.font_size = 21;
            l_name.ForeColor = Color.White;
            l_name.Location = new Point(25, 19);
            l_name.Name = "l_name";
            l_name.Size = new Size(322, 47);
            l_name.TabIndex = 6;
            l_name.Text = "Create Class Subject";
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
            b_new.Location = new Point(108, 396);
            b_new.MaximumSize = new Size(85, 50);
            b_new.MinimumSize = new Size(85, 50);
            b_new.MouseDownBackColor = Color.CornflowerBlue;
            b_new.MouseOverBackColor = Color.LightBlue;
            b_new.Name = "b_new";
            b_new.Size = new Size(85, 50);
            b_new.TabIndex = 3;
            b_new.Text = "Add";
            b_new.TextColor = Color.White;
            b_new.UseVisualStyleBackColor = false;
            // 
            // p_SubjectClass
            // 
            p_SubjectClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_SubjectClass.AutoSize = true;
            p_SubjectClass.Controls.Add(data_Show);
            p_SubjectClass.Location = new Point(442, 98);
            p_SubjectClass.Name = "p_SubjectClass";
            p_SubjectClass.Size = new Size(737, 527);
            p_SubjectClass.TabIndex = 5;
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
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_Show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            data_Show.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            data_Show.DefaultCellStyle = dataGridViewCellStyle2;
            data_Show.Dock = DockStyle.Fill;
            data_Show.EditMode = DataGridViewEditMode.EditOnEnter;
            data_Show.FirstRowColor = Color.FromArgb(249, 249, 248);
            data_Show.GridColor = SystemColors.Window;
            data_Show.Location = new Point(0, 0);
            data_Show.Name = "data_Show";
            data_Show.Opacity = 100;
            data_Show.ReadOnly = true;
            data_Show.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(73, 70, 144);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_Show.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            data_Show.RowHeadersVisible = false;
            data_Show.RowHeadersWidth = 51;
            data_Show.SecondRowColor = Color.FromArgb(242, 242, 242);
            data_Show.SelectedCellColor = Color.FromArgb(117, 215, 222);
            data_Show.SelectedTextColor = Color.White;
            data_Show.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_Show.Size = new Size(737, 527);
            data_Show.TabIndex = 1;
            data_Show.MouseDown += data_Show_MouseDown;
            // 
            // radiusPanel1
            // 
            radiusPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radiusPanel1.BackColor = Color.FromArgb(255, 254, 254);
            radiusPanel1.BackgroundColor = Color.FromArgb(255, 254, 254);
            radiusPanel1.BorderColor = Color.FromArgb(191, 194, 196);
            radiusPanel1.BorderRadius = 5;
            radiusPanel1.BorderSize = 1;
            radiusPanel1.Controls.Add(radiusButton1);
            radiusPanel1.Controls.Add(label4);
            radiusPanel1.Controls.Add(label3);
            radiusPanel1.Controls.Add(label1);
            radiusPanel1.Controls.Add(Cb_subject);
            radiusPanel1.Controls.Add(CB_Class);
            radiusPanel1.Controls.Add(labelCus1);
            radiusPanel1.ForeColor = Color.White;
            radiusPanel1.Location = new Point(65, 98);
            radiusPanel1.Name = "radiusPanel1";
            radiusPanel1.Size = new Size(298, 527);
            radiusPanel1.TabIndex = 20;
            radiusPanel1.TextColor = Color.White;
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
            radiusButton1.Location = new Point(102, 449);
            radiusButton1.MaximumSize = new Size(100, 50);
            radiusButton1.MinimumSize = new Size(85, 50);
            radiusButton1.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton1.MouseOverBackColor = Color.LightBlue;
            radiusButton1.Name = "radiusButton1";
            radiusButton1.Size = new Size(95, 50);
            radiusButton1.TabIndex = 43;
            radiusButton1.Text = "Add";
            radiusButton1.TextColor = Color.White;
            radiusButton1.UseVisualStyleBackColor = false;
            radiusButton1.Click += radiusButton1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(44, 320);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 42;
            label4.Text = "* Subject:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(44, 190);
            label3.Name = "label3";
            label3.Size = new Size(85, 26);
            label3.TabIndex = 41;
            label3.Text = "* Class:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(76, 127);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 40;
            label1.Text = "Select class, subject.";
            // 
            // Cb_subject
            // 
            Cb_subject.Anchor = AnchorStyles.Top;
            Cb_subject.AutoCompleteMode = AutoCompleteMode.Suggest;
            Cb_subject.AutoCompleteSource = AutoCompleteSource.ListItems;
            Cb_subject.BackColor = Color.WhiteSmoke;
            Cb_subject.BorderColor = Color.MediumSlateBlue;
            Cb_subject.BorderSize = 1;
            Cb_subject.DropDownStyle = ComboBoxStyle.DropDown;
            Cb_subject.Font = new Font("Segoe UI", 10F);
            Cb_subject.ForeColor = Color.DimGray;
            Cb_subject.IconColor = Color.MediumSlateBlue;
            Cb_subject.ListBackColor = Color.FromArgb(230, 228, 245);
            Cb_subject.ListTextColor = Color.DimGray;
            Cb_subject.Location = new Point(44, 349);
            Cb_subject.MaximumSize = new Size(220, 35);
            Cb_subject.MinimumSize = new Size(220, 35);
            Cb_subject.Name = "Cb_subject";
            Cb_subject.Padding = new Padding(1);
            Cb_subject.Size = new Size(220, 35);
            Cb_subject.TabIndex = 37;
            Cb_subject.Texts = "";
            // 
            // CB_Class
            // 
            CB_Class.Anchor = AnchorStyles.Top;
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
            CB_Class.Location = new Point(44, 218);
            CB_Class.MaximumSize = new Size(220, 35);
            CB_Class.MinimumSize = new Size(220, 35);
            CB_Class.Name = "CB_Class";
            CB_Class.Padding = new Padding(1);
            CB_Class.Size = new Size(220, 35);
            CB_Class.TabIndex = 36;
            CB_Class.Texts = "";
            // 
            // labelCus1
            // 
            labelCus1.Anchor = AnchorStyles.Top;
            labelCus1.Font = new Font("Times New Roman", 14F);
            labelCus1.font_size = 14;
            labelCus1.ForeColor = Color.Black;
            labelCus1.Location = new Point(22, 88);
            labelCus1.Name = "labelCus1";
            labelCus1.Size = new Size(265, 35);
            labelCus1.TabIndex = 0;
            labelCus1.Text = "Select subjects for classes";
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
            // ClassSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1236, 637);
            Controls.Add(radiusPanel1);
            Controls.Add(p_SubjectClass);
            Controls.Add(p_head);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1236, 637);
            Name = "ClassSubject";
            Text = "ClassSubject";
            Load += ClassSubject_Load;
            p_head.ResumeLayout(false);
            p_searchadd.ResumeLayout(false);
            radiusPanel2.ResumeLayout(false);
            radiusPanel2.PerformLayout();
            p_SubjectClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Show).EndInit();
            radiusPanel1.ResumeLayout(false);
            radiusPanel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel p_head;
        private Support.LabelCus l_name;
        private Panel p_SubjectClass;
        private Support.DataGridCus data_Show;
        private Panel p_searchadd;
        private Support.RadiusPanel radiusPanel2;
        private TextBox textBox2;
        private Support.RadiusButton Search;
        private Support.RadiusButton b_new;
        private Support.RadiusPanel radiusPanel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Support.ComboCus Cb_subject;
        private Support.ComboCus CB_Class;
        private Support.LabelCus labelCus1;
        private Support.RadiusButton radiusButton1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
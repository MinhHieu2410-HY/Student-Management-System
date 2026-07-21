namespace WFEND
{
    partial class Attendance
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
            panel1 = new Panel();
            label2 = new Label();
            radiusPanel1 = new WFEND.Support.RadiusPanel();
            bt_delete = new WFEND.Support.RadiusButton();
            bt_submit = new WFEND.Support.RadiusButton();
            label6 = new Label();
            cb_session = new WFEND.Support.ComboCus();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            DT_date = new WFEND.Support.CusDateTime();
            Cb_subject = new WFEND.Support.ComboCus();
            CB_Class = new WFEND.Support.ComboCus();
            labelCus1 = new WFEND.Support.LabelCus();
            p_data = new Panel();
            data_Show = new WFEND.Support.DataGridCus();
            panel1.SuspendLayout();
            radiusPanel1.SuspendLayout();
            p_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show).BeginInit();
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
            panel1.Size = new Size(1200, 98);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 27);
            label2.Name = "label2";
            label2.Size = new Size(199, 42);
            label2.TabIndex = 0;
            label2.Text = "Attendance";
            // 
            // radiusPanel1
            // 
            radiusPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radiusPanel1.BackColor = Color.FromArgb(255, 254, 254);
            radiusPanel1.BackgroundColor = Color.FromArgb(255, 254, 254);
            radiusPanel1.BorderColor = Color.FromArgb(191, 194, 196);
            radiusPanel1.BorderRadius = 5;
            radiusPanel1.BorderSize = 1;
            radiusPanel1.Controls.Add(bt_delete);
            radiusPanel1.Controls.Add(bt_submit);
            radiusPanel1.Controls.Add(label6);
            radiusPanel1.Controls.Add(cb_session);
            radiusPanel1.Controls.Add(label5);
            radiusPanel1.Controls.Add(label4);
            radiusPanel1.Controls.Add(label3);
            radiusPanel1.Controls.Add(label1);
            radiusPanel1.Controls.Add(DT_date);
            radiusPanel1.Controls.Add(Cb_subject);
            radiusPanel1.Controls.Add(CB_Class);
            radiusPanel1.Controls.Add(labelCus1);
            radiusPanel1.ForeColor = Color.White;
            radiusPanel1.Location = new Point(50, 119);
            radiusPanel1.Name = "radiusPanel1";
            radiusPanel1.Size = new Size(1100, 167);
            radiusPanel1.TabIndex = 19;
            radiusPanel1.TextColor = Color.White;
            // 
            // bt_delete
            // 
            bt_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_delete.BackColor = Color.MediumSlateBlue;
            bt_delete.BackgroundColor = Color.MediumSlateBlue;
            bt_delete.BorderColor = Color.FromArgb(189, 179, 246);
            bt_delete.BorderRadius = 10;
            bt_delete.BorderSize = 2;
            bt_delete.Cursor = Cursors.Hand;
            bt_delete.FlatAppearance.BorderSize = 0;
            bt_delete.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            bt_delete.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            bt_delete.FlatStyle = FlatStyle.Flat;
            bt_delete.ForeColor = Color.White;
            bt_delete.Location = new Point(856, 16);
            bt_delete.MouseDownBackColor = Color.CornflowerBlue;
            bt_delete.MouseOverBackColor = Color.LightBlue;
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(106, 45);
            bt_delete.TabIndex = 47;
            bt_delete.Text = "Delete";
            bt_delete.TextColor = Color.White;
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Visible = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_submit
            // 
            bt_submit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            bt_submit.Location = new Point(968, 16);
            bt_submit.MouseDownBackColor = Color.CornflowerBlue;
            bt_submit.MouseOverBackColor = Color.LightBlue;
            bt_submit.Name = "bt_submit";
            bt_submit.Size = new Size(106, 45);
            bt_submit.TabIndex = 46;
            bt_submit.Text = "Submit";
            bt_submit.TextColor = Color.White;
            bt_submit.UseVisualStyleBackColor = false;
            bt_submit.Click += bt_submit_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(857, 85);
            label6.Name = "label6";
            label6.Size = new Size(107, 26);
            label6.TabIndex = 45;
            label6.Text = "* Session:";
            // 
            // cb_session
            // 
            cb_session.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_session.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_session.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_session.BackColor = Color.WhiteSmoke;
            cb_session.BorderColor = Color.MediumSlateBlue;
            cb_session.BorderSize = 1;
            cb_session.DropDownStyle = ComboBoxStyle.DropDown;
            cb_session.Font = new Font("Segoe UI", 10F);
            cb_session.ForeColor = Color.DimGray;
            cb_session.IconColor = Color.MediumSlateBlue;
            cb_session.Items.AddRange(new object[] { "M", "A" });
            cb_session.ListBackColor = Color.FromArgb(230, 228, 245);
            cb_session.ListTextColor = Color.DimGray;
            cb_session.Location = new Point(854, 113);
            cb_session.MaximumSize = new Size(220, 35);
            cb_session.MinimumSize = new Size(220, 35);
            cb_session.Name = "cb_session";
            cb_session.Padding = new Padding(1);
            cb_session.Size = new Size(220, 35);
            cb_session.TabIndex = 44;
            cb_session.Texts = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(631, 85);
            label5.Name = "label5";
            label5.Size = new Size(78, 26);
            label5.TabIndex = 43;
            label5.Text = "* Date:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(259, 85);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 42;
            label4.Text = "* Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 85);
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
            label1.Location = new Point(31, 56);
            label1.Name = "label1";
            label1.Size = new Size(225, 19);
            label1.TabIndex = 40;
            label1.Text = "Select class, subject, date time.";
            // 
            // DT_date
            // 
            DT_date.Anchor = AnchorStyles.None;
            DT_date.BorderColor = Color.PaleVioletRed;
            DT_date.BorderSize = 0;
            DT_date.Font = new Font("Segoe UI", 9.5F);
            DT_date.Format = DateTimePickerFormat.Short;
            DT_date.Location = new Point(628, 113);
            DT_date.MaximumSize = new Size(220, 35);
            DT_date.MinimumSize = new Size(220, 35);
            DT_date.Name = "DT_date";
            DT_date.Size = new Size(220, 35);
            DT_date.SkinColor = Color.MediumSlateBlue;
            DT_date.TabIndex = 39;
            DT_date.TextColor = Color.White;
            // 
            // Cb_subject
            // 
            Cb_subject.Anchor = AnchorStyles.None;
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
            Cb_subject.Location = new Point(256, 113);
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
            CB_Class.Location = new Point(30, 113);
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
            labelCus1.Font = new Font("Times New Roman", 15F);
            labelCus1.font_size = 15;
            labelCus1.ForeColor = Color.Black;
            labelCus1.Location = new Point(29, 21);
            labelCus1.Name = "labelCus1";
            labelCus1.Size = new Size(176, 35);
            labelCus1.TabIndex = 0;
            labelCus1.Text = "Attendance By";
            // 
            // p_data
            // 
            p_data.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            p_data.AutoSize = true;
            p_data.Controls.Add(data_Show);
            p_data.Location = new Point(50, 315);
            p_data.MaximumSize = new Size(1626, 800);
            p_data.Name = "p_data";
            p_data.Size = new Size(1100, 362);
            p_data.TabIndex = 27;
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
            data_Show.BorderColor = Color.FromArgb(100, 191, 194, 196);
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
            data_Show.Size = new Size(1100, 362);
            data_Show.TabIndex = 0;
            data_Show.CellDoubleClick += data_Show_CellDoubleClick;
            data_Show.CellEnter += data_Show_CellEnter;
            data_Show.CellValueChanged += data_Show_CellValueChanged;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1200, 700);
            Controls.Add(p_data);
            Controls.Add(radiusPanel1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 700);
            Name = "Attendance";
            Load += Attendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            radiusPanel1.ResumeLayout(false);
            radiusPanel1.PerformLayout();
            p_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Support.RadiusPanel radiusPanel1;
        private Support.LabelCus labelCus1;
        private Support.CusDateTime DT_date;
        private Support.ComboCus Cb_subject;
        private Support.ComboCus CB_Class;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Panel p_data;
        private Support.DataGridCus data_Show;
        private Label label6;
        private Support.ComboCus cb_session;
        private Support.RadiusButton bt_submit;
        private Support.RadiusButton bt_delete;
    }
}
namespace WFEND
{
    partial class DataShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataShow));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            B_Print = new WFEND.Support.RadiusButton();
            radiusPanel2 = new WFEND.Support.RadiusPanel();
            textBox2 = new TextBox();
            Search = new WFEND.Support.RadiusButton();
            B_Add = new WFEND.Support.RadiusButton();
            l_text = new Label();
            p_data = new Panel();
            P_Export = new Panel();
            panel4 = new Panel();
            B_cancel = new Button();
            B_accept = new Button();
            pdf = new Button();
            csv = new Button();
            xls = new Button();
            docx = new Button();
            label1 = new Label();
            data_Show = new WFEND.Support.DataGridCus();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            radiusPanel2.SuspendLayout();
            p_data.SuspendLayout();
            P_Export.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(65, 71, 151);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(l_text);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1236, 98);
            panel1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(B_Print);
            panel2.Controls.Add(radiusPanel2);
            panel2.Controls.Add(B_Add);
            panel2.Location = new Point(835, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 50);
            panel2.TabIndex = 4;
            // 
            // B_Print
            // 
            B_Print.BackColor = Color.FromArgb(85, 88, 197);
            B_Print.BackgroundColor = Color.FromArgb(85, 88, 197);
            B_Print.BorderColor = Color.White;
            B_Print.BorderRadius = 10;
            B_Print.BorderSize = 2;
            B_Print.Dock = DockStyle.Right;
            B_Print.FlatAppearance.BorderSize = 0;
            B_Print.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            B_Print.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            B_Print.FlatStyle = FlatStyle.Flat;
            B_Print.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Print.ForeColor = Color.White;
            B_Print.Location = new Point(239, 0);
            B_Print.MaximumSize = new Size(75, 50);
            B_Print.MinimumSize = new Size(75, 50);
            B_Print.MouseDownBackColor = Color.CornflowerBlue;
            B_Print.MouseOverBackColor = Color.LightBlue;
            B_Print.Name = "B_Print";
            B_Print.Size = new Size(75, 50);
            B_Print.TabIndex = 3;
            B_Print.Text = "Print";
            B_Print.TextColor = Color.White;
            B_Print.UseVisualStyleBackColor = false;
            B_Print.Click += B_Print_Click;
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
            radiusPanel2.MinimumSize = new Size(238, 50);
            radiusPanel2.Name = "radiusPanel2";
            radiusPanel2.Size = new Size(238, 50);
            radiusPanel2.TabIndex = 2;
            radiusPanel2.TextColor = Color.White;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(61, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 2;
            // 
            // Search
            // 
            Search.BackColor = Color.MediumSlateBlue;
            Search.BackgroundColor = Color.MediumSlateBlue;
            Search.BorderColor = Color.PaleVioletRed;
            Search.BorderRadius = 0;
            Search.BorderSize = 0;
            Search.Dock = DockStyle.Left;
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
            // B_Add
            // 
            B_Add.BackColor = Color.FromArgb(85, 88, 197);
            B_Add.BackgroundColor = Color.FromArgb(85, 88, 197);
            B_Add.BorderColor = Color.White;
            B_Add.BorderRadius = 10;
            B_Add.BorderSize = 2;
            B_Add.Dock = DockStyle.Right;
            B_Add.FlatAppearance.BorderSize = 0;
            B_Add.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            B_Add.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            B_Add.FlatStyle = FlatStyle.Flat;
            B_Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B_Add.ForeColor = Color.White;
            B_Add.Location = new Point(314, 0);
            B_Add.MaximumSize = new Size(70, 50);
            B_Add.MinimumSize = new Size(70, 50);
            B_Add.MouseDownBackColor = Color.CornflowerBlue;
            B_Add.MouseOverBackColor = Color.LightBlue;
            B_Add.Name = "B_Add";
            B_Add.Size = new Size(70, 50);
            B_Add.TabIndex = 1;
            B_Add.Text = "Add";
            B_Add.TextColor = Color.White;
            B_Add.UseVisualStyleBackColor = false;
            B_Add.Click += B_Add_Click;
            // 
            // l_text
            // 
            l_text.AutoSize = true;
            l_text.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_text.Location = new Point(28, 25);
            l_text.Name = "l_text";
            l_text.Size = new Size(214, 42);
            l_text.TabIndex = 0;
            l_text.Text = "Manage ###";
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
            p_data.Size = new Size(1212, 553);
            p_data.TabIndex = 27;
            // 
            // P_Export
            // 
            P_Export.BackColor = Color.FromArgb(65, 71, 151);
            P_Export.Controls.Add(panel4);
            P_Export.Location = new Point(503, 189);
            P_Export.Name = "P_Export";
            P_Export.Size = new Size(646, 322);
            P_Export.TabIndex = 5;
            P_Export.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(B_cancel);
            panel4.Controls.Add(B_accept);
            panel4.Controls.Add(pdf);
            panel4.Controls.Add(csv);
            panel4.Controls.Add(xls);
            panel4.Controls.Add(docx);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(17, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(613, 293);
            panel4.TabIndex = 0;
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
            data_Show.GridColor = SystemColors.Window;
            data_Show.Location = new Point(0, 0);
            data_Show.Name = "data_Show";
            data_Show.Opacity = 100;
            data_Show.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
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
            data_Show.Size = new Size(1212, 553);
            data_Show.TabIndex = 0;
            data_Show.CellEnter += data_Show_CellEnter;
            data_Show.CellMouseDoubleClick += data_Show_CellMouseDoubleClick;
            data_Show.CellValueChanged += data_Show_CellValueChanged;
            data_Show.MouseDown += data_Show_MouseDown;
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
            // DataShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1236, 669);
            Controls.Add(p_data);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1236, 669);
            Name = "DataShow";
            Text = "DataShow";
            Load += DataShow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            radiusPanel2.ResumeLayout(false);
            radiusPanel2.PerformLayout();
            p_data.ResumeLayout(false);
            P_Export.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_Show).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Support.RadiusPanel radiusPanel2;
        private TextBox textBox2;
        private Support.RadiusButton Search;
        private Support.RadiusButton B_Add;
        private Panel p_data;
        private Support.DataGridCus data_Show;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label l_text;
        private Support.RadiusButton B_Print;
        private Panel P_Export;
        private Panel panel4;
        private Label label1;
        private Button docx;
        private Button pdf;
        private Button csv;
        private Button xls;
        private Button B_cancel;
        private Button B_accept;
    }
}
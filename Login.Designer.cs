namespace WFEND
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            radiusButton1 = new Support.RadiusButton();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            radiusButton3 = new Support.RadiusButton();
            radiusPanel2 = new Support.RadiusPanel();
            bt_show = new Support.RadiusButton();
            textBoxCustom2 = new TextBoxCustom();
            labelCus3 = new Support.LabelCus();
            radiusPanel1 = new Support.RadiusPanel();
            textBoxCustom1 = new TextBoxCustom();
            labelCus2 = new Support.LabelCus();
            labelCus1 = new Support.LabelCus();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            radiusPanel2.SuspendLayout();
            radiusPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 243, 243);
            panel1.Controls.Add(radiusButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 59);
            panel1.TabIndex = 1;
            // 
            // radiusButton1
            // 
            radiusButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            radiusButton1.BackColor = Color.White;
            radiusButton1.BackgroundColor = Color.White;
            radiusButton1.BorderColor = Color.Black;
            radiusButton1.BorderRadius = 15;
            radiusButton1.BorderSize = 1;
            radiusButton1.FlatAppearance.BorderSize = 0;
            radiusButton1.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton1.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            radiusButton1.FlatStyle = FlatStyle.Flat;
            radiusButton1.ForeColor = Color.White;
            radiusButton1.Image = (Image)resources.GetObject("radiusButton1.Image");
            radiusButton1.Location = new Point(1238, 3);
            radiusButton1.MaximumSize = new Size(50, 50);
            radiusButton1.MinimumSize = new Size(50, 50);
            radiusButton1.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton1.MouseOverBackColor = Color.LightBlue;
            radiusButton1.Name = "radiusButton1";
            radiusButton1.Size = new Size(50, 50);
            radiusButton1.TabIndex = 0;
            radiusButton1.TextColor = Color.White;
            radiusButton1.UseVisualStyleBackColor = false;
            radiusButton1.Click += radiusButton1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(681, 302);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(681, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 636);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(radiusButton3);
            panel2.Controls.Add(radiusPanel2);
            panel2.Controls.Add(radiusPanel1);
            panel2.Controls.Add(labelCus1);
            panel2.Location = new Point(844, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 636);
            panel2.TabIndex = 3;
            // 
            // radiusButton3
            // 
            radiusButton3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radiusButton3.BackColor = Color.FromArgb(98, 76, 239);
            radiusButton3.BackgroundColor = Color.FromArgb(98, 76, 239);
            radiusButton3.BorderColor = Color.PaleVioletRed;
            radiusButton3.BorderRadius = 20;
            radiusButton3.BorderSize = 0;
            radiusButton3.Cursor = Cursors.Hand;
            radiusButton3.FlatAppearance.BorderSize = 0;
            radiusButton3.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton3.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            radiusButton3.FlatStyle = FlatStyle.Flat;
            radiusButton3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiusButton3.ForeColor = Color.White;
            radiusButton3.Location = new Point(166, 391);
            radiusButton3.MouseDownBackColor = Color.CornflowerBlue;
            radiusButton3.MouseOverBackColor = Color.LightBlue;
            radiusButton3.Name = "radiusButton3";
            radiusButton3.Size = new Size(133, 52);
            radiusButton3.TabIndex = 3;
            radiusButton3.Text = "Login Now";
            radiusButton3.TextColor = Color.White;
            radiusButton3.UseVisualStyleBackColor = false;
            radiusButton3.Click += btnLogin_Click;
            // 
            // radiusPanel2
            // 
            radiusPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radiusPanel2.BackColor = Color.FromArgb(242, 240, 255);
            radiusPanel2.BackgroundColor = Color.FromArgb(242, 240, 255);
            radiusPanel2.BorderColor = Color.PaleVioletRed;
            radiusPanel2.BorderRadius = 8;
            radiusPanel2.BorderSize = 0;
            radiusPanel2.Controls.Add(bt_show);
            radiusPanel2.Controls.Add(textBoxCustom2);
            radiusPanel2.Controls.Add(labelCus3);
            radiusPanel2.ForeColor = Color.White;
            radiusPanel2.Location = new Point(79, 272);
            radiusPanel2.Name = "radiusPanel2";
            radiusPanel2.Size = new Size(316, 56);
            radiusPanel2.TabIndex = 2;
            radiusPanel2.TextColor = Color.White;
            // 
            // bt_show
            // 
            bt_show.BackColor = Color.FromArgb(242, 240, 255);
            bt_show.BackgroundColor = Color.FromArgb(242, 240, 255);
            bt_show.BorderColor = Color.PaleVioletRed;
            bt_show.BorderRadius = 0;
            bt_show.BorderSize = 0;
            bt_show.Cursor = Cursors.Hand;
            bt_show.Dock = DockStyle.Right;
            bt_show.FlatAppearance.BorderSize = 0;
            bt_show.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            bt_show.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            bt_show.FlatStyle = FlatStyle.Flat;
            bt_show.ForeColor = Color.White;
            bt_show.Image = Properties.Resources.eyeshow;
            bt_show.Location = new Point(266, 0);
            bt_show.MouseDownBackColor = Color.CornflowerBlue;
            bt_show.MouseOverBackColor = Color.LightBlue;
            bt_show.Name = "bt_show";
            bt_show.Size = new Size(50, 56);
            bt_show.TabIndex = 3;
            bt_show.TextColor = Color.White;
            bt_show.UseVisualStyleBackColor = false;
            bt_show.Click += bt_show_Click;
            // 
            // textBoxCustom2
            // 
            textBoxCustom2.Anchor = AnchorStyles.Top;
            textBoxCustom2.AutoSize = true;
            textBoxCustom2.BackColor = Color.FromArgb(242, 240, 255);
            textBoxCustom2.BorderColor = Color.FromArgb(242, 240, 255);
            textBoxCustom2.BorderFocusColor = Color.Black;
            textBoxCustom2.BorderRadius = 0;
            textBoxCustom2.BorderSize = 2;
            textBoxCustom2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustom2.ForeColor = Color.DimGray;
            textBoxCustom2.Location = new Point(156, 11);
            textBoxCustom2.Margin = new Padding(4);
            textBoxCustom2.Multiline = false;
            textBoxCustom2.Name = "textBoxCustom2";
            textBoxCustom2.Padding = new Padding(7);
            textBoxCustom2.PasswordChar = true;
            textBoxCustom2.PlaceholderColor = Color.DarkGray;
            textBoxCustom2.PlaceholderText = "";
            textBoxCustom2.Size = new Size(100, 35);
            textBoxCustom2.TabIndex = 2;
            textBoxCustom2.Texts = "";
            textBoxCustom2.UnderlinedStyle = false;
            textBoxCustom2.KeyDownCustom += textBoxCustom2_KeyDownCustom;
            textBoxCustom2.Enter += textBoxCustom2_Enter;
            textBoxCustom2.Leave += textBoxCustom2_Leave;
            // 
            // labelCus3
            // 
            labelCus3.Font = new Font("Times New Roman", 15F);
            labelCus3.font_size = 15;
            labelCus3.ForeColor = Color.Black;
            labelCus3.Image = (Image)resources.GetObject("labelCus3.Image");
            labelCus3.ImageAlign = ContentAlignment.MiddleLeft;
            labelCus3.Location = new Point(3, 11);
            labelCus3.Name = "labelCus3";
            labelCus3.Size = new Size(149, 35);
            labelCus3.TabIndex = 1;
            labelCus3.Text = "Password";
            labelCus3.TextAlign = ContentAlignment.MiddleRight;
            labelCus3.Click += textBoxCustom2_Enter;
            // 
            // radiusPanel1
            // 
            radiusPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radiusPanel1.BackColor = Color.FromArgb(242, 240, 255);
            radiusPanel1.BackgroundColor = Color.FromArgb(242, 240, 255);
            radiusPanel1.BorderColor = Color.PaleVioletRed;
            radiusPanel1.BorderRadius = 8;
            radiusPanel1.BorderSize = 0;
            radiusPanel1.Controls.Add(textBoxCustom1);
            radiusPanel1.Controls.Add(labelCus2);
            radiusPanel1.ForeColor = Color.White;
            radiusPanel1.Location = new Point(76, 184);
            radiusPanel1.Name = "radiusPanel1";
            radiusPanel1.Size = new Size(319, 52);
            radiusPanel1.TabIndex = 1;
            radiusPanel1.TextColor = Color.White;
            // 
            // textBoxCustom1
            // 
            textBoxCustom1.Anchor = AnchorStyles.Top;
            textBoxCustom1.AutoSize = true;
            textBoxCustom1.BackColor = Color.FromArgb(242, 240, 255);
            textBoxCustom1.BorderColor = Color.FromArgb(242, 240, 255);
            textBoxCustom1.BorderFocusColor = Color.Black;
            textBoxCustom1.BorderRadius = 0;
            textBoxCustom1.BorderSize = 2;
            textBoxCustom1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustom1.ForeColor = Color.DimGray;
            textBoxCustom1.Location = new Point(159, 10);
            textBoxCustom1.Margin = new Padding(4);
            textBoxCustom1.Multiline = false;
            textBoxCustom1.Name = "textBoxCustom1";
            textBoxCustom1.Padding = new Padding(7);
            textBoxCustom1.PasswordChar = false;
            textBoxCustom1.PlaceholderColor = Color.DarkGray;
            textBoxCustom1.PlaceholderText = "";
            textBoxCustom1.Size = new Size(155, 35);
            textBoxCustom1.TabIndex = 1;
            textBoxCustom1.Texts = "";
            textBoxCustom1.UnderlinedStyle = false;
            textBoxCustom1.KeyDownCustom += textBoxCustom2_KeyDownCustom;
            textBoxCustom1.Enter += textBoxCustom1_Enter;
            textBoxCustom1.Leave += textBoxCustom1_Leave;
            // 
            // labelCus2
            // 
            labelCus2.Font = new Font("Times New Roman", 15F);
            labelCus2.font_size = 15;
            labelCus2.ForeColor = Color.Black;
            labelCus2.Image = (Image)resources.GetObject("labelCus2.Image");
            labelCus2.ImageAlign = ContentAlignment.MiddleLeft;
            labelCus2.Location = new Point(3, 10);
            labelCus2.Name = "labelCus2";
            labelCus2.Size = new Size(149, 35);
            labelCus2.TabIndex = 0;
            labelCus2.Text = "Username";
            labelCus2.TextAlign = ContentAlignment.MiddleRight;
            labelCus2.Click += textBoxCustom1_Enter;
            // 
            // labelCus1
            // 
            labelCus1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCus1.Font = new Font("Copperplate Gothic Light", 27F);
            labelCus1.font_size = 27;
            labelCus1.ForeColor = Color.Black;
            labelCus1.Location = new Point(141, 106);
            labelCus1.Name = "labelCus1";
            labelCus1.Size = new Size(185, 58);
            labelCus1.TabIndex = 0;
            labelCus1.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 695);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logirn";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            radiusPanel2.ResumeLayout(false);
            radiusPanel2.PerformLayout();
            radiusPanel1.ResumeLayout(false);
            radiusPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Support.RadiusButton radiusButton2;
        private Support.RadiusButton radiusButton1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Support.RadiusPanel radiusPanel2;
        private Support.RadiusPanel radiusPanel1;
        private Support.LabelCus labelCus1;
        private Support.LabelCus labelCus2;
        private Support.LabelCus labelCus3;
        private TextBoxCustom textBoxCustom2;
        private TextBoxCustom textBoxCustom1;
        private Support.RadiusButton radiusButton3;
        private Support.RadiusButton bt_show;
    }
}
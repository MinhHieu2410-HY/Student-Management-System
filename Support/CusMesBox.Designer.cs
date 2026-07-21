namespace WFEND
{
    partial class CusMesBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CusMesBox));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            labelCaption = new Label();
            labelMessage = new Label();
            panelTitleBar = new Panel();
            btnClose = new Support.RadiusButton();
            pictureBoxIcon = new PictureBox();
            panelButtons = new Panel();
            panelBody = new Panel();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelButtons.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(90, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.Location = new Point(182, 0);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCaption.Location = new Point(110, 12);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(131, 28);
            labelCaption.TabIndex = 3;
            labelCaption.Text = "labelCaption";
            labelCaption.Click += labelCaption_Click;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(110, 40);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(102, 19);
            labelMessage.TabIndex = 4;
            labelMessage.Text = "labelMessage";
            // 
            // panelTitleBar
            // 
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(pictureBoxIcon);
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(labelMessage);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(550, 110);
            panelTitleBar.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = SystemColors.Window;
            btnClose.BackgroundColor = SystemColors.Window;
            btnClose.BorderColor = Color.FromArgb(214, 219, 222);
            btnClose.BorderRadius = 15;
            btnClose.BorderSize = 1;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(494, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(44, 47);
            btnClose.TabIndex = 9;
            btnClose.TextColor = Color.White;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(12, 12);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(80, 80);
            pictureBoxIcon.TabIndex = 5;
            pictureBoxIcon.TabStop = false;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(button2);
            panelButtons.Controls.Add(button1);
            panelButtons.Location = new Point(133, 116);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(276, 41);
            panelButtons.TabIndex = 7;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(panelTitleBar);
            panelBody.Controls.Add(panelButtons);
            panelBody.Dock = DockStyle.Top;
            panelBody.Location = new Point(0, 0);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(550, 165);
            panelBody.TabIndex = 8;
            panelBody.Paint += panelBody_Paint;
            // 
            // CusMesBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 165);
            Controls.Add(panelBody);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CusMesBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CusMesBox";
            Load += CusMesBox_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelButtons.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label labelCaption;
        private Label labelMessage;
        private Panel panelTitleBar;
        private PictureBox pictureBoxIcon;
        private Panel panelButtons;
        private Panel panelBody;
        private Support.RadiusButton btnClose;
    }
}
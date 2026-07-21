namespace WFEND
{
    partial class ShowImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowImage));
            Image = new PictureBox();
            p_Tool = new Panel();
            b_tick = new Support.RadiusButton();
            radiusButton2 = new Support.RadiusButton();
            b_zoom = new Support.RadiusButton();
            b_Close = new Support.RadiusButton();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            p_Tool.SuspendLayout();
            SuspendLayout();
            // 
            // Image
            // 
            Image.BackgroundImageLayout = ImageLayout.Stretch;
            Image.BorderStyle = BorderStyle.FixedSingle;
            Image.Dock = DockStyle.Fill;
            Image.InitialImage = null;
            Image.Location = new Point(0, 0);
            Image.Name = "Image";
            Image.Size = new Size(818, 484);
            Image.SizeMode = PictureBoxSizeMode.AutoSize;
            Image.TabIndex = 0;
            Image.TabStop = false;
            // 
            // p_Tool
            // 
            p_Tool.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            p_Tool.BorderStyle = BorderStyle.FixedSingle;
            p_Tool.Controls.Add(b_tick);
            p_Tool.Controls.Add(radiusButton2);
            p_Tool.Controls.Add(b_zoom);
            p_Tool.Controls.Add(b_Close);
            p_Tool.Location = new Point(0, 0);
            p_Tool.Name = "p_Tool";
            p_Tool.Size = new Size(818, 73);
            p_Tool.TabIndex = 2;
            // 
            // b_tick
            // 
            b_tick.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            b_tick.BackColor = SystemColors.Window;
            b_tick.BackgroundColor = SystemColors.Window;
            b_tick.BorderColor = Color.FromArgb(214, 219, 224);
            b_tick.BorderRadius = 15;
            b_tick.BorderSize = 1;
            b_tick.FlatAppearance.BorderSize = 0;
            b_tick.FlatStyle = FlatStyle.Flat;
            b_tick.ForeColor = Color.White;
            b_tick.Image = (Image)resources.GetObject("b_tick.Image");
            b_tick.Location = new Point(68, 12);
            b_tick.Name = "b_tick";
            b_tick.Size = new Size(50, 47);
            b_tick.TabIndex = 34;
            b_tick.TextColor = Color.White;
            b_tick.UseVisualStyleBackColor = false;
            b_tick.Visible = false;
            b_tick.Click += b_tick_Click;
            // 
            // radiusButton2
            // 
            radiusButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            radiusButton2.BackColor = SystemColors.Window;
            radiusButton2.BackgroundColor = SystemColors.Window;
            radiusButton2.BorderColor = Color.FromArgb(214, 219, 224);
            radiusButton2.BorderRadius = 15;
            radiusButton2.BorderSize = 1;
            radiusButton2.FlatAppearance.BorderSize = 0;
            radiusButton2.FlatStyle = FlatStyle.Flat;
            radiusButton2.ForeColor = Color.White;
            radiusButton2.Image = (Image)resources.GetObject("radiusButton2.Image");
            radiusButton2.Location = new Point(12, 12);
            radiusButton2.Name = "radiusButton2";
            radiusButton2.Size = new Size(50, 47);
            radiusButton2.TabIndex = 33;
            radiusButton2.TextColor = Color.White;
            radiusButton2.UseVisualStyleBackColor = false;
            radiusButton2.Click += radiusButton2_Click;
            // 
            // b_zoom
            // 
            b_zoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            b_zoom.BackColor = SystemColors.Window;
            b_zoom.BackgroundColor = SystemColors.Window;
            b_zoom.BorderColor = Color.FromArgb(214, 219, 224);
            b_zoom.BorderRadius = 15;
            b_zoom.BorderSize = 1;
            b_zoom.FlatAppearance.BorderSize = 0;
            b_zoom.FlatStyle = FlatStyle.Flat;
            b_zoom.ForeColor = Color.White;
            b_zoom.Image = Properties.Resources.Fullsize;
            b_zoom.Location = new Point(698, 12);
            b_zoom.Name = "b_zoom";
            b_zoom.Size = new Size(50, 47);
            b_zoom.TabIndex = 32;
            b_zoom.TextColor = Color.White;
            b_zoom.UseVisualStyleBackColor = false;
            b_zoom.Click += b_MaxSize;
            // 
            // b_Close
            // 
            b_Close.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            b_Close.BackColor = SystemColors.Window;
            b_Close.BackgroundColor = SystemColors.Window;
            b_Close.BorderColor = Color.FromArgb(214, 219, 224);
            b_Close.BorderRadius = 15;
            b_Close.BorderSize = 1;
            b_Close.FlatAppearance.BorderSize = 0;
            b_Close.FlatStyle = FlatStyle.Flat;
            b_Close.ForeColor = Color.White;
            b_Close.Image = (Image)resources.GetObject("b_Close.Image");
            b_Close.Location = new Point(754, 12);
            b_Close.Name = "b_Close";
            b_Close.Size = new Size(50, 47);
            b_Close.TabIndex = 31;
            b_Close.TextColor = Color.White;
            b_Close.UseVisualStyleBackColor = false;
            b_Close.Click += b_CloseRegi_Click;
            // 
            // ShowImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 484);
            Controls.Add(p_Tool);
            Controls.Add(Image);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "ShowImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowImage";
            Load += ShowImage_Load;
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            p_Tool.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Image;
        private Panel p_Tool;
        private Support.RadiusButton radiusButton2;
        private Support.RadiusButton b_zoom;
        private Support.RadiusButton b_Close;
        private Support.RadiusButton b_tick;
    }
}
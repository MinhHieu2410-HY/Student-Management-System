using WFEND.Support;

namespace WFEND
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pe_StudentProfile = new CusPicture();
            label1 = new Label();
            tB_FullName = new TextBoxCustom();
            tB_Age = new TextBoxCustom();
            tB_Phone = new TextBoxCustom();
            labelFullName = new Label();
            labelAge = new Label();
            labelPhone = new Label();
            labelBirthday = new Label();
            labelGender = new Label();
            label2 = new Label();
            Ro_Male = new CusRadioButton();
            Ro_Female = new CusRadioButton();
            radiusButton1 = new RadiusButton();
            label8 = new Label();
            tB_Address = new TextBoxCustom();
            labelClass = new Label();
            line1 = new Line();
            b_CloseRegi = new RadiusButton();
            line2 = new Line();
            DT_birthday = new CusDateTime();
            tB_Gmail = new TextBoxCustom();
            labelGmail = new Label();
            CB_Class = new ComboCus();
            ((System.ComponentModel.ISupportInitialize)pe_StudentProfile).BeginInit();
            SuspendLayout();
            // 
            // pe_StudentProfile
            // 
            pe_StudentProfile.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pe_StudentProfile.BackgroundImageLayout = ImageLayout.Stretch;
            pe_StudentProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            pe_StudentProfile.BorderColor = Color.Black;
            pe_StudentProfile.BorderColor2 = Color.Black;
            pe_StudentProfile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pe_StudentProfile.BorderSize = 2;
            pe_StudentProfile.GradientAngle = 50F;
            pe_StudentProfile.Image = Properties.Resources.AddUser;
            pe_StudentProfile.Location = new Point(210, 99);
            pe_StudentProfile.Name = "pe_StudentProfile";
            pe_StudentProfile.Size = new Size(159, 159);
            pe_StudentProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pe_StudentProfile.TabIndex = 0;
            pe_StudentProfile.TabStop = false;
            pe_StudentProfile.Click += pe_StudentProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 14;
            label1.Text = "Add New Students";
            // 
            // tB_FullName
            // 
            tB_FullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tB_FullName.BackColor = SystemColors.Window;
            tB_FullName.BorderColor = Color.Gray;
            tB_FullName.BorderFocusColor = Color.FromArgb(5, 161, 235);
            tB_FullName.BorderRadius = 10;
            tB_FullName.BorderSize = 1;
            tB_FullName.Font = new Font("Times New Roman", 12F);
            tB_FullName.ForeColor = Color.Black;
            tB_FullName.Location = new Point(50, 341);
            tB_FullName.Margin = new Padding(4);
            tB_FullName.Multiline = false;
            tB_FullName.Name = "tB_FullName";
            tB_FullName.Padding = new Padding(7);
            tB_FullName.PasswordChar = false;
            tB_FullName.PlaceholderColor = Color.DarkGray;
            tB_FullName.PlaceholderText = "";
            tB_FullName.Size = new Size(203, 37);
            tB_FullName.TabIndex = 3;
            tB_FullName.Texts = "";
            tB_FullName.UnderlinedStyle = false;
            // 
            // tB_Age
            // 
            tB_Age.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tB_Age.BackColor = SystemColors.Window;
            tB_Age.BorderColor = Color.Gray;
            tB_Age.BorderFocusColor = Color.FromArgb(5, 161, 235);
            tB_Age.BorderRadius = 10;
            tB_Age.BorderSize = 1;
            tB_Age.Font = new Font("Times New Roman", 12F);
            tB_Age.ForeColor = Color.Black;
            tB_Age.Location = new Point(340, 453);
            tB_Age.Margin = new Padding(4);
            tB_Age.Multiline = false;
            tB_Age.Name = "tB_Age";
            tB_Age.Padding = new Padding(7);
            tB_Age.PasswordChar = false;
            tB_Age.PlaceholderColor = Color.DarkGray;
            tB_Age.PlaceholderText = "";
            tB_Age.Size = new Size(203, 37);
            tB_Age.TabIndex = 4;
            tB_Age.Texts = "";
            tB_Age.UnderlinedStyle = false;
            // 
            // tB_Phone
            // 
            tB_Phone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tB_Phone.BackColor = SystemColors.Window;
            tB_Phone.BorderColor = Color.Gray;
            tB_Phone.BorderFocusColor = Color.FromArgb(5, 161, 235);
            tB_Phone.BorderRadius = 10;
            tB_Phone.BorderSize = 1;
            tB_Phone.Font = new Font("Times New Roman", 12F);
            tB_Phone.ForeColor = Color.Black;
            tB_Phone.Location = new Point(51, 453);
            tB_Phone.Margin = new Padding(4);
            tB_Phone.Multiline = false;
            tB_Phone.Name = "tB_Phone";
            tB_Phone.Padding = new Padding(7);
            tB_Phone.PasswordChar = false;
            tB_Phone.PlaceholderColor = Color.DarkGray;
            tB_Phone.PlaceholderText = "";
            tB_Phone.Size = new Size(203, 37);
            tB_Phone.TabIndex = 7;
            tB_Phone.Texts = "";
            tB_Phone.UnderlinedStyle = false;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Times New Roman", 13.8F);
            labelFullName.ForeColor = Color.Black;
            labelFullName.Location = new Point(50, 301);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(109, 26);
            labelFullName.TabIndex = 15;
            labelFullName.Text = "Full Name";
            // 
            // labelAge
            // 
            labelAge.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Times New Roman", 13.8F);
            labelAge.ForeColor = Color.Black;
            labelAge.Location = new Point(340, 416);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(49, 26);
            labelAge.TabIndex = 16;
            labelAge.Text = "Age";
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Times New Roman", 13.8F);
            labelPhone.ForeColor = Color.Black;
            labelPhone.Location = new Point(50, 416);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(71, 26);
            labelPhone.TabIndex = 17;
            labelPhone.Text = "Phone";
            // 
            // labelBirthday
            // 
            labelBirthday.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelBirthday.AutoSize = true;
            labelBirthday.Font = new Font("Times New Roman", 13.8F);
            labelBirthday.ForeColor = Color.Black;
            labelBirthday.Location = new Point(339, 301);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(101, 26);
            labelBirthday.TabIndex = 18;
            labelBirthday.Text = "Birth Day";
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Times New Roman", 13.8F);
            labelGender.ForeColor = Color.Black;
            labelGender.Location = new Point(50, 516);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(80, 26);
            labelGender.TabIndex = 19;
            labelGender.Text = "Gender";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(44, 564);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 20;
            label2.Text = "Address";
            // 
            // Ro_Male
            // 
            Ro_Male.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Ro_Male.AutoSize = true;
            Ro_Male.CheckedColor = Color.FromArgb(7, 163, 235);
            Ro_Male.Cursor = Cursors.Hand;
            Ro_Male.Font = new Font("Times New Roman", 12F);
            Ro_Male.ForeColor = Color.Black;
            Ro_Male.Location = new Point(50, 562);
            Ro_Male.MinimumSize = new Size(0, 21);
            Ro_Male.Name = "Ro_Male";
            Ro_Male.Padding = new Padding(10, 0, 0, 0);
            Ro_Male.Size = new Size(82, 26);
            Ro_Male.TabIndex = 22;
            Ro_Male.TabStop = true;
            Ro_Male.Text = "Male";
            Ro_Male.UnCheckedColor = Color.Black;
            Ro_Male.UseVisualStyleBackColor = true;
            // 
            // Ro_Female
            // 
            Ro_Female.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Ro_Female.AutoSize = true;
            Ro_Female.CheckedColor = Color.FromArgb(7, 163, 235);
            Ro_Female.Cursor = Cursors.Hand;
            Ro_Female.Font = new Font("Times New Roman", 12F);
            Ro_Female.ForeColor = Color.Black;
            Ro_Female.Location = new Point(154, 562);
            Ro_Female.MinimumSize = new Size(0, 21);
            Ro_Female.Name = "Ro_Female";
            Ro_Female.Padding = new Padding(10, 0, 0, 0);
            Ro_Female.Size = new Size(99, 26);
            Ro_Female.TabIndex = 23;
            Ro_Female.TabStop = true;
            Ro_Female.Text = "Female";
            Ro_Female.UnCheckedColor = Color.Black;
            Ro_Female.UseVisualStyleBackColor = true;
            // 
            // radiusButton1
            // 
            radiusButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radiusButton1.BackColor = Color.FromArgb(11, 165, 237);
            radiusButton1.BackgroundColor = Color.FromArgb(11, 165, 237);
            radiusButton1.BorderColor = SystemColors.Window;
            radiusButton1.BorderRadius = 20;
            radiusButton1.BorderSize = 1;
            radiusButton1.FlatAppearance.BorderSize = 0;
            radiusButton1.FlatStyle = FlatStyle.Flat;
            radiusButton1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiusButton1.ForeColor = Color.White;
            radiusButton1.Location = new Point(34, 917);
            radiusButton1.Name = "radiusButton1";
            radiusButton1.Size = new Size(509, 63);
            radiusButton1.TabIndex = 24;
            radiusButton1.Text = "Add New Students";
            radiusButton1.TextColor = Color.White;
            radiusButton1.UseVisualStyleBackColor = false;
            radiusButton1.Click += b_AddNewStudents_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(50, 708);
            label8.Name = "label8";
            label8.Size = new Size(88, 26);
            label8.TabIndex = 25;
            label8.Text = "Address";
            // 
            // tB_Address
            // 
            tB_Address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tB_Address.BackColor = SystemColors.Window;
            tB_Address.BorderColor = Color.Gray;
            tB_Address.BorderFocusColor = Color.FromArgb(5, 161, 235);
            tB_Address.BorderRadius = 10;
            tB_Address.BorderSize = 2;
            tB_Address.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tB_Address.ForeColor = Color.Black;
            tB_Address.Location = new Point(44, 738);
            tB_Address.Margin = new Padding(4);
            tB_Address.Multiline = true;
            tB_Address.Name = "tB_Address";
            tB_Address.Padding = new Padding(7);
            tB_Address.PasswordChar = false;
            tB_Address.PlaceholderColor = Color.DarkGray;
            tB_Address.PlaceholderText = "";
            tB_Address.Size = new Size(498, 155);
            tB_Address.TabIndex = 26;
            tB_Address.Texts = "";
            tB_Address.UnderlinedStyle = false;
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Times New Roman", 13.8F);
            labelClass.ForeColor = Color.Black;
            labelClass.Location = new Point(339, 516);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(61, 26);
            labelClass.TabIndex = 27;
            labelClass.Text = "Class";
            // 
            // line1
            // 
            line1.BackColor = Color.FromArgb(213, 214, 216);
            line1.BorderWidth = 1;
            line1.Direction = Line.EDIR.Horizontal;
            line1.DrawStyle = Line.eStyle.Rect;
            line1.Location = new Point(0, 68);
            line1.Name = "line1";
            line1.Size = new Size(660, 11);
            line1.TabIndex = 29;
            line1.Text = "line1";
            // 
            // b_CloseRegi
            // 
            b_CloseRegi.BackColor = SystemColors.Window;
            b_CloseRegi.BackgroundColor = SystemColors.Window;
            b_CloseRegi.BorderColor = Color.FromArgb(214, 219, 224);
            b_CloseRegi.BorderRadius = 15;
            b_CloseRegi.BorderSize = 1;
            b_CloseRegi.FlatAppearance.BorderSize = 0;
            b_CloseRegi.FlatStyle = FlatStyle.Flat;
            b_CloseRegi.ForeColor = Color.White;
            b_CloseRegi.Image = (Image)resources.GetObject("b_CloseRegi.Image");
            b_CloseRegi.Location = new Point(519, 12);
            b_CloseRegi.Name = "b_CloseRegi";
            b_CloseRegi.Size = new Size(50, 50);
            b_CloseRegi.TabIndex = 30;
            b_CloseRegi.TextColor = Color.White;
            b_CloseRegi.UseVisualStyleBackColor = false;
            b_CloseRegi.Click += b_CloseRegi_Click;
            // 
            // line2
            // 
            line2.BackColor = Color.FromArgb(213, 214, 216);
            line2.BorderWidth = 1;
            line2.Direction = Line.EDIR.Horizontal;
            line2.DrawStyle = Line.eStyle.Rect;
            line2.Location = new Point(-59, 900);
            line2.Name = "line2";
            line2.Size = new Size(660, 11);
            line2.TabIndex = 31;
            line2.Text = "line2";
            // 
            // DT_birthday
            // 
            DT_birthday.BorderColor = Color.Black;
            DT_birthday.BorderSize = 0;
            DT_birthday.CalendarFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DT_birthday.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DT_birthday.Format = DateTimePickerFormat.Short;
            DT_birthday.Location = new Point(340, 341);
            DT_birthday.MinimumSize = new Size(0, 35);
            DT_birthday.Name = "DT_birthday";
            DT_birthday.Size = new Size(203, 35);
            DT_birthday.SkinColor = Color.FromArgb(11, 165, 237);
            DT_birthday.TabIndex = 32;
            DT_birthday.TextColor = Color.White;
            DT_birthday.ValueChanged += DT_birthday_ValueChanged;
            // 
            // tB_Gmail
            // 
            tB_Gmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tB_Gmail.BackColor = SystemColors.Window;
            tB_Gmail.BorderColor = Color.Gray;
            tB_Gmail.BorderFocusColor = Color.FromArgb(5, 161, 235);
            tB_Gmail.BorderRadius = 10;
            tB_Gmail.BorderSize = 1;
            tB_Gmail.Font = new Font("Times New Roman", 12F);
            tB_Gmail.ForeColor = Color.Black;
            tB_Gmail.Location = new Point(128, 628);
            tB_Gmail.Margin = new Padding(4);
            tB_Gmail.Multiline = false;
            tB_Gmail.Name = "tB_Gmail";
            tB_Gmail.Padding = new Padding(7);
            tB_Gmail.PasswordChar = false;
            tB_Gmail.PlaceholderColor = Color.DarkGray;
            tB_Gmail.PlaceholderText = "";
            tB_Gmail.Size = new Size(414, 37);
            tB_Gmail.TabIndex = 34;
            tB_Gmail.Texts = "";
            tB_Gmail.UnderlinedStyle = false;
            // 
            // labelGmail
            // 
            labelGmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelGmail.AutoSize = true;
            labelGmail.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGmail.ForeColor = Color.FromArgb(93, 102, 106);
            labelGmail.Location = new Point(44, 630);
            labelGmail.Name = "labelGmail";
            labelGmail.Size = new Size(82, 33);
            labelGmail.TabIndex = 33;
            labelGmail.Text = "Gmail";
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
            CB_Class.Location = new Point(339, 562);
            CB_Class.MinimumSize = new Size(200, 30);
            CB_Class.Name = "CB_Class";
            CB_Class.Padding = new Padding(1);
            CB_Class.Size = new Size(203, 37);
            CB_Class.TabIndex = 35;
            CB_Class.Texts = "";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(581, 992);
            Controls.Add(CB_Class);
            Controls.Add(tB_Gmail);
            Controls.Add(labelGmail);
            Controls.Add(DT_birthday);
            Controls.Add(line2);
            Controls.Add(b_CloseRegi);
            Controls.Add(line1);
            Controls.Add(label1);
            Controls.Add(labelClass);
            Controls.Add(tB_Address);
            Controls.Add(label8);
            Controls.Add(radiusButton1);
            Controls.Add(Ro_Female);
            Controls.Add(Ro_Male);
            Controls.Add(label2);
            Controls.Add(labelGender);
            Controls.Add(labelBirthday);
            Controls.Add(labelPhone);
            Controls.Add(labelAge);
            Controls.Add(labelFullName);
            Controls.Add(tB_Phone);
            Controls.Add(tB_Age);
            Controls.Add(tB_FullName);
            Controls.Add(pe_StudentProfile);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Register_Load;
            MouseDown += OnMouseDown;
            ((System.ComponentModel.ISupportInitialize)pe_StudentProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CusPicture pe_StudentProfile;
        private TextBoxCustom tB_FullName;
        private TextBoxCustom tB_Age;
        private TextBoxCustom tB_Phone;
        private Label label1;
        private Label labelFullName;
        private Label labelAge;
        private Label labelPhone;
        private Label labelBirthday;
        private Label labelGender;
        private Label label2;
        private CusRadioButton Ro_Male;
        private CusRadioButton Ro_Female;
        private RadiusButton radiusButton1;
        private Label label8;
        private TextBoxCustom tB_Address;
        private Label labelClass;
        private Line line1;
        private RadiusButton b_CloseRegi;
        private Line line2;
        private CusDateTime DT_birthday;
        private TextBoxCustom tB_Gmail;
        private Label labelGmail;
        private ComboCus CB_Class;
    }
}
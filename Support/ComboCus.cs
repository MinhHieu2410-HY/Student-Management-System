using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEND.Support
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class ComboCus : UserControl // Changed to public
    {
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        public event EventHandler OnSelectedIndexChanged;

        public ComboCus()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.DrawMode = DrawMode.OwnerDrawFixed;
            cmbList.DrawItem += new DrawItemEventHandler(cmbList_DrawItem);
            cmbList.DropDownWidth = this.Width;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };

            // Set the dropdown width
            cmbList.DropDownWidth = cmbList.Width;
        }

        private void cmbList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index < 0) return;

            string text = cmbList.Items[e.Index].ToString();

            // Draw item with ComboBox width
            Rectangle bounds = new Rectangle(e.Bounds.X, e.Bounds.Y, cmbList.Width, e.Bounds.Height);
            e.Graphics.DrawString(text, e.Font, new SolidBrush(cmbList.ForeColor), bounds);

            e.DrawFocusRectangle();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedIndexChanged?.Invoke(sender, e);
            lblText.Text = cmbList.Text;
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        // Properties for customization
        [Category("Custom")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Custom")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();
            }
        }

        [Category("Custom")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("Custom")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        [Category("Custom")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        [Category("Custom")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("Custom")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }
        }

        [Category("Custom")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("Custom")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        // Other properties for data binding
        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        [Category("Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        [Category("Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        [Category("Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        [Category("Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        [Category("Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}

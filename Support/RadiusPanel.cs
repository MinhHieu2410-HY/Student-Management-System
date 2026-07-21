using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace WFEND.Support
{
    public class RadiusPanel : Panel
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        // Properties
        [Category("Custom")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        public Color BackgroundColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }

        [Category("Custom")]
        public Color TextColor
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        // Constructor
        public RadiusPanel()
        {
            Resize += new EventHandler(RadiusPanel_Resize);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
        }

        private void RadiusPanel_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
            if (borderRadius > Width)
                borderRadius = Width;
        }

        // Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) // Rounded panel
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    // Panel surface
                    Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Panel border                    
                    if (borderSize >= 1)
                        // Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal panel
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                // Panel surface
                Region = new Region(rectSurface);
                // Panel border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

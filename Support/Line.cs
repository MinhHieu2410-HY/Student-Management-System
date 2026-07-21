using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;

namespace WFEND.Support
{
    internal class Line : Control
    {
        private bool szChInternaly;

        public enum EDIR
        {
            Horizontal,
            Vertical,
            Slash,
            BKSlash
        }

        public enum eStyle
        {
            Rect,
            Circ
        }

        private eStyle _drawStyle;
        public eStyle DrawStyle
        {
            get { return _drawStyle; }
            set
            {
                _drawStyle = value;
                BuildMe(_direction);
            }
        }

        private EDIR _direction = EDIR.Horizontal;
        public EDIR Direction
        {
            get { return _direction; }
            set
            {
                if (value == EDIR.Horizontal && _direction == EDIR.Vertical ||
                    value == EDIR.Vertical && _direction == EDIR.Horizontal)
                {
                    szChInternaly = true;
                    Size = new Size(Height, Width);
                }
                _direction = value;
                BuildMe(_direction);
            }
        }

        private bool _isVertical;
        [Category("Custom")]
        [Description("Determines if the line is vertical.")]
        public bool IsVertical
        {
            get { return _isVertical; }
            set
            {
                _isVertical = value;
                Direction = _isVertical ? EDIR.Vertical : EDIR.Horizontal;
            }
        }

        private void BuildMe(EDIR direction)
        {
            try
            {
                szChInternaly = true;
                using (GraphicsPath path = new GraphicsPath())
                {
                    switch (direction)
                    {
                        case EDIR.Horizontal:
                            Size = new Size(Width, _borderWidth + 10);
                            path.AddRectangle(new Rectangle(0, (-_borderWidth + Height) / 2, Width, _borderWidth));
                            break;

                        case EDIR.Vertical:
                            Size = new Size(_borderWidth + 10, Height);
                            path.AddRectangle(new Rectangle((-_borderWidth + Width) / 2, 0, _borderWidth, Height));
                            break;

                        case EDIR.Slash:
                            DrawSlash(path);
                            break;

                        case EDIR.BKSlash:
                            DrawBackSlash(path);
                            break;
                    }
                    Region = new Region(path);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in BuildMe: {ex.Message}");
            }
            finally
            {
                szChInternaly = false;
            }
        }

        private void DrawSlash(GraphicsPath path)
        {
            try
            {
                float diagonalLength = (float)Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
                for (float i = 0; i <= diagonalLength; i += _borderWidth)
                {
                    switch (_drawStyle)
                    {
                        case eStyle.Circ:
                            path.AddPie(i, Height * i / Width, _borderWidth, _borderWidth, 0, 360);
                            break;
                        case eStyle.Rect:
                            path.AddRectangle(new Rectangle((int)i, (int)(Height * i / Width), _borderWidth, _borderWidth));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in DrawSlash: {ex.Message}");
            }
        }

        private void DrawBackSlash(GraphicsPath path)
        {
            try
            {
                float diagonalLength = (float)Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
                for (float i = 0; i <= diagonalLength; i += _borderWidth)
                {
                    switch (_drawStyle)
                    {
                        case eStyle.Circ:
                            path.AddPie(Width - 1 - i, Height * i / Width, _borderWidth, _borderWidth, 0, 360);
                            break;
                        case eStyle.Rect:
                            path.AddRectangle(new Rectangle(Width - 1 - (int)i, (int)(Height * i / Width), _borderWidth, _borderWidth));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in DrawBackSlash: {ex.Message}");
            }
        }

        private int _borderWidth = 1;
        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                BuildMe(_direction);
            }
        }

        public Line()
        {
            BackColor = Color.Black;
            BuildMe(_direction);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (!szChInternaly)
                BuildMe(_direction);
        }
    }
}

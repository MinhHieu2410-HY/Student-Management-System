using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WFEND.Support
{
    internal class DataGridCus : DataGridView
    {
        private Color borderColor = Color.FromArgb(100, 0, 255, 0);
        private int opacity = 100;
        private bool alternateRowColors = false;
        private Color firstRowColor = Color.LightGray;
        private Color secondRowColor = Color.White;

        // Custom properties for selected cell color and text color
        private Color selectedCellColor = Color.Blue;
        private Color selectedTextColor = Color.White;

        [Category("Custom")]
        [Description("Màu viền cho các cell trong DataGridView.")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Độ trong suốt của màu viền.")]
        public int Opacity
        {
            get => opacity;
            set
            {
                if (value >= 0 && value <= 255)
                {
                    opacity = value;
                    borderColor = Color.FromArgb(opacity, borderColor.R, borderColor.G, borderColor.B);
                    Invalidate();
                }
            }
        }

        [Category("Custom")]
        [Description("Chọn xem có xen kẽ màu giữa các hàng hay không.")]
        public bool AlternateRowColors
        {
            get => alternateRowColors;
            set
            {
                alternateRowColors = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Màu cho hàng chẵn. Chỉ có hiệu lực khi AlternateRowColors là true.")]
        public Color FirstRowColor
        {
            get => firstRowColor;
            set
            {
                firstRowColor = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Màu cho hàng lẻ. Chỉ có hiệu lực khi AlternateRowColors là true.")]
        public Color SecondRowColor
        {
            get => secondRowColor;
            set
            {
                secondRowColor = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Màu nền cho ô được chọn.")]
        public Color SelectedCellColor
        {
            get => selectedCellColor;
            set
            {
                selectedCellColor = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Màu chữ cho ô được chọn.")]
        public Color SelectedTextColor
        {
            get => selectedTextColor;
            set
            {
                selectedTextColor = value;
                Invalidate();
            }
        }

        public DataGridCus()
        {
            this.DefaultCellStyle.BackColor = Color.White;
            this.AlternateRowColors = true; // Thiết lập mặc định
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            if (e == null) return;

            // Xử lý ô được chọn
            if (e.State.HasFlag(DataGridViewElementStates.Selected))
            {
                using (Brush selectedBrush = new SolidBrush(selectedCellColor))
                {
                    e.Graphics.FillRectangle(selectedBrush, e.CellBounds);
                }

                // Vẽ lại nội dung của cell với màu chữ tùy chỉnh
                string text = e.FormattedValue?.ToString() ?? string.Empty;
                TextRenderer.DrawText(e.Graphics, text, e.CellStyle.Font, e.CellBounds, selectedTextColor);
                e.Handled = true; // Đánh dấu sự kiện đã xử lý
                return;
            }

            // Vẽ màu nền cho cell
            if (alternateRowColors && e.RowIndex >= 0)
            {
                Color rowColor = (e.RowIndex % 2 == 0) ? firstRowColor : secondRowColor;
                e.Graphics.FillRectangle(new SolidBrush(rowColor), e.CellBounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(e.CellStyle?.BackColor ?? Color.White), e.CellBounds);
            }

            // Xử lý hình ảnh
            if (e.Value is byte[] imageData)
            {
                using (var ms = new MemoryStream(imageData))
                {
                    var image = Image.FromStream(ms);
                    var imgRect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                    e.Graphics.DrawImage(image, imgRect);
                }
            }
            else
            {
                // Vẽ viền cho tất cả các cell
                using (Pen borderPen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(borderPen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                }

                // Vẽ lại nội dung của cell
                string text = e.FormattedValue?.ToString() ?? string.Empty;
                if (e.CellStyle != null)
                {
                    TextRenderer.DrawText(e.Graphics, text, e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor);
                }
            }

            e.Handled = true; // Đánh dấu sự kiện đã xử lý
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);
            if (alternateRowColors)
            {
                for (int i = 0; i < Rows.Count; i++)
                {
                    Color rowColor = (i % 2 == 0) ? firstRowColor : secondRowColor;
                    Rows[i].DefaultCellStyle.BackColor = rowColor;
                }
            }
        }
    }
}

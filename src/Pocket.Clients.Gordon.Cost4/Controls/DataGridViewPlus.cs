using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Pocket.Clients.Gordon.Cost4.Controls
{
    public class DataGridViewPlus : DataGridView
    {
        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);
            if ((e.RowIndex + 1) % 2 == 0)
            {
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            }
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            base.OnCellPainting(e);
            if (e.ColumnIndex == -1 && e.RowIndex == -1)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(e.CellBounds, Color.FromArgb(169, 169, 169),
                    Color.FromArgb(169, 169, 169), LinearGradientMode.ForwardDiagonal))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                    Rectangle border = e.CellBounds;
                    border.Offset(new Point(-1, -1));
                    Rectangle innerBorder = e.CellBounds;
                    Brush innerBorderBrush = new SolidBrush(Color.FromArgb(212, 212, 212));
                    Pen innerPen = new Pen(innerBorderBrush);

                    Brush bottomBorderBrush = new SolidBrush(Color.FromArgb(112, 112, 112));
                    Pen bottomPen = new Pen(bottomBorderBrush);

                    Brush borderBrush = new SolidBrush(Color.FromArgb(56, 56, 56));
                    Pen pen = new Pen(borderBrush);

                    e.Graphics.DrawRectangle(pen, border);
                    e.Graphics.DrawLine(innerPen, new Point(border.X + 1, border.Y), new Point(border.X + 1, border.Y + border.Height - 1));

                    e.Graphics.DrawLine(bottomPen, new Point(border.X + border.Width - 1, border.Y), new Point(border.X + border.Width - 1, border.Y + border.Height - 1));

                    e.Graphics.DrawLine(innerPen, new Point(border.X + 1, border.Y + 1), new Point(border.X + border.Width - 2, border.Y + 1));

                    e.Graphics.DrawLine(bottomPen, new Point(border.X + 2, border.Y + border.Height - 1), new Point(border.X + border.Width - 2, border.Y + border.Height - 1));
                }
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
            else if (e.RowIndex == -1)
            {
                //标题行
                using (LinearGradientBrush brush = new LinearGradientBrush(e.CellBounds, Color.FromArgb(169, 169, 169),
                    Color.FromArgb(169, 169, 169), LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                    Rectangle border = e.CellBounds;
                    border.Offset(new Point(-1, -1));

                    Rectangle innerBorder = e.CellBounds;
                    Brush innerBorderBrush = new SolidBrush(Color.FromArgb(212, 212, 212));
                    Pen innerPen = new Pen(innerBorderBrush);

                    Brush bottomBorderBrush = new SolidBrush(Color.FromArgb(112, 112, 112));
                    Pen bottomPen = new Pen(bottomBorderBrush);

                    Brush borderBrush = new SolidBrush(Color.FromArgb(56, 56, 56));
                    Pen pen = new Pen(borderBrush);

                    e.Graphics.DrawRectangle(pen, border);
                    e.Graphics.DrawLine(innerPen, new Point(border.X + 1, border.Y), new Point(border.X + 1, border.Y + border.Height - 1));

                    e.Graphics.DrawLine(bottomPen, new Point(border.X + border.Width - 1, border.Y), new Point(border.X + border.Width - 1, border.Y + border.Height - 1));

                    e.Graphics.DrawLine(innerPen, new Point(border.X + 1, border.Y + 1), new Point(border.X + border.Width - 2, border.Y + 1));

                    e.Graphics.DrawLine(bottomPen, new Point(border.X + 2, border.Y + border.Height - 1), new Point(border.X + border.Width - 2, border.Y + border.Height - 1));

                }
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
            else if (e.ColumnIndex == -1)
            {
                //标题列
                using (LinearGradientBrush brush = new LinearGradientBrush(e.CellBounds, Color.FromArgb(169, 169, 169),
                    Color.FromArgb(169, 169, 169), LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                    Rectangle border = e.CellBounds;
                    border.Offset(new Point(-1, -1));

                    Rectangle innerBorder = e.CellBounds;
                    Brush innerBorderBrush = new SolidBrush(Color.FromArgb(212, 212, 212));
                    Pen innerPen = new Pen(innerBorderBrush);

                    Brush bottomBorderBrush = new SolidBrush(Color.FromArgb(112, 112, 112));
                    Pen bottomPen = new Pen(bottomBorderBrush);

                    Brush borderBrush = new SolidBrush(Color.FromArgb(56, 56, 56));
                    Pen pen = new Pen(borderBrush);

                    e.Graphics.DrawRectangle(pen, border);
                    e.Graphics.DrawLine(innerPen, new Point(border.X + 1, border.Y), new Point(border.X + 1, border.Y + border.Height - 1));

                    e.Graphics.DrawLine(bottomPen, new Point(border.X + border.Width - 1, border.Y), new Point(border.X + border.Width - 1, border.Y + border.Height - 1));

                    e.Graphics.DrawLine(innerPen, new Point(border.X + 1, border.Y + 1), new Point(border.X + border.Width - 2, border.Y + 1));

                    e.Graphics.DrawLine(bottomPen, new Point(border.X + 2, border.Y + border.Height - 1), new Point(border.X + border.Width - 2, border.Y + border.Height - 1));
                }
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }
    }
}

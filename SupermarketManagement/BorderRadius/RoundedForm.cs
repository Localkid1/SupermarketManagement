using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedForm : Form
{
    public RoundedForm()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        this.BackColor = Color.White;
        this.Padding = new Padding(1);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var path = new GraphicsPath())
        {
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 2, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 2, this.Height - radius - 2, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 2, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (var brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            using (var pen = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}

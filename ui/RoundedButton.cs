using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ICV_Tool.components
{
    public class RoundedButton : Button
    {
        private Color _pressColor = Color.Red;
        private Color _hoverColor = Color.Blue;
        private Color _disabledColor = Color.Gray;
        private Color _pressForeColor = SystemColors.ControlText;
        private Color _hoverForeColor = SystemColors.ControlText;
        private Color _disabledForeColor = SystemColors.GrayText;
        private Color _borderPressColor = SystemColors.ControlText;
        private int _borderRadius = 15;

        public Color PressColor
        {
            get { return _pressColor; }
            set { _pressColor = value; }
        }

        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; }
        }

        public Color DisabledColor
        {
            get { return _disabledColor; }
            set { _disabledColor = value; }
        }

        public Color PressForeColor
        {
            get { return _pressForeColor; }
            set { _pressForeColor = value; }
        }

        public Color HoverForeColor
        {
            get { return _hoverForeColor; }
            set { _hoverForeColor = value; }
        }

        public Color DisabledForeColor
        {
            get { return _disabledForeColor; }
            set { _disabledForeColor = value; }
        }
        public int BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; }
        }

        public Color BorderPressColor
        {
            get { return _borderPressColor; }
            set { _borderPressColor = value; }
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float m = 2.75F;
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m);
            GraphPath.AddArc(Rect.X + Rect.Width - radius - m,
                           Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m);
            GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Color currentColor = BackColor;
            if (this.Enabled)
            {
                if (this.MouseIsDown)
                {
                    currentColor = PressColor;
                    pevent.Graphics.FillRectangle(new SolidBrush(PressColor), this.ClientRectangle);

                    pevent.Graphics.DrawString(Text, Font, new SolidBrush(_pressForeColor), ClientRectangle,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                else if (this.MouseIsOver)
                {
                    currentColor = HoverColor;
                    pevent.Graphics.FillRectangle(new SolidBrush(HoverColor), this.ClientRectangle);

                    pevent.Graphics.DrawString(Text, Font, new SolidBrush(_hoverForeColor), this.ClientRectangle,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                else
                {
                    base.OnPaint(pevent);
                }
            }
            else
            {
                currentColor = DisabledColor;
                pevent.Graphics.FillRectangle(new SolidBrush(DisabledColor), this.ClientRectangle);
                pevent.Graphics.DrawString(Text, Font, new SolidBrush(_disabledForeColor), ClientRectangle, 
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }

            int borderRadius = _borderRadius;

            if (borderRadius>0)
            {
                float borderThickness = 2f;
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                GraphicsPath GraphPath = GetRoundPath(Rect, borderRadius);

                this.Region = new Region(GraphPath);
                Color penColor = currentColor;
                if (MouseIsDown && _borderPressColor!= SystemColors.ControlText)
                {
                    penColor = _borderPressColor;
                    borderThickness = 3f;
                }
                using (Pen pen = new Pen(penColor, borderThickness))
                {
                    pen.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        private bool MouseIsOver { get; set; }
        private bool MouseIsDown { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseIsOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseIsOver = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            MouseIsDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            MouseIsDown = false;
            Invalidate();
        }
    }
}

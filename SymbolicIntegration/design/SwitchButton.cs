using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
 

namespace SymbolicIntegration.design
{
    public class SwitchButton:Control
    {
        Rectangle rect;
        //Позиция при включенном и выключенном переключателе
        int TogglePosX_ON;
        int TogglePosX_OFF;
        public bool Checked { get; set; }=false;
        //Цвет заливки
        public Color BackColorON { get; set; }= Color.Black;

        
        public SwitchButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(Width, Height);
            rect = new Rectangle(1, 1, Width - 3, Height - 3);
            TogglePosX_ON = rect.Width-rect.Height;
            TogglePosX_OFF = rect.X;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);

            Pen TSPen = new Pen(Color.Black, 3);
            Pen TSPenToggle = new Pen(Color.Black, 3);


            GraphicsPath rectGP = RoundedRectangle(rect, rect.Height);
            Rectangle rectToggle = new Rectangle(rect.X, rect.Y, rect.Height, rect.Height);
            graph.DrawPath(TSPen, rectGP);
            if (Checked)
            {
                rectToggle.Location = new Point(TogglePosX_ON, rect.Y);
                graph.FillPath(new SolidBrush(BackColorON), rectGP);

            }
            else
            {
                rectToggle.Location = new Point(TogglePosX_OFF, rect.Y);
                graph.FillPath(new SolidBrush(BackColor), rectGP);
            }

            graph.DrawEllipse( TSPenToggle, rectToggle);
            graph.FillEllipse(new SolidBrush(Color.WhiteSmoke), rectToggle);
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            rect=new Rectangle(1, 1 , Width-3, Height-3);
            TogglePosX_ON = rect.Width - rect.Height;
            TogglePosX_OFF = rect.X;
        }
        private GraphicsPath RoundedRectangle(Rectangle rect, int RoundSize)
        {
            GraphicsPath gp= new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X+rect.Width-RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
            gp.AddArc(rect.X+rect.Width-RoundSize, rect.Y+rect.Height-RoundSize, RoundSize, RoundSize, 0, 90);
            gp.AddArc(rect.X, rect.Y+rect.Height-RoundSize, RoundSize, RoundSize, 90, 90);
            gp.CloseFigure();
            return gp;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SwitchToggle();
        }
        private void SwitchToggle()
        {

            Checked = !Checked;
            Invalidate(); 
        }
    }
}

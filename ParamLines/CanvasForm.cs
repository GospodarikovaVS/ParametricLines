using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyParamLibrary;

namespace ParamLines
{
    public partial class CanvasForm : Form
    {
        private Graphics g;
        public Painting MyPainter;
        private Color MyColorAction, MyColorBackGround;

        public CanvasForm(Color ColorAction, Color ColorBackGround)
        {
            InitializeComponent();
            MyColorBackGround = ColorBackGround;
            MyColorAction = ColorAction;
            MyPainter = new Painting(this.Width, this.Height);
            g = this.CreateGraphics();
        }

        private void canvasForm_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            Clear();
        }

        public void DrawGraphic(int v)
        {
            g = this.CreateGraphics();
            double x, y;
            const int N = 500;
            double t = 0, h = 2 * Math.PI / N;
            Point pt1, pt2 = new Point();
            Pen p = new Pen(MyColorAction, 2);
            x = MyPainter.FX(t, v);
            y = MyPainter.FY(t, v);
            pt1 = new Point(MyPainter.II(x), MyPainter.JJ(y));
            for (int i = 0; i < 5 * N; i++)
            {
                t += h;
                x = MyPainter.FX(t, v);
                y = MyPainter.FY(t, v);
                pt2.X = MyPainter.II(x);
                pt2.Y = MyPainter.JJ(y);
                g.DrawLine(p, pt1, pt2);
                pt1 = pt2;
            }
        }

        public void Clear()
        {
            if (g != null)
            {
                SolidBrush b = new SolidBrush(MyColorBackGround);
                g.FillRectangle(b, 0, 0, Width, Height);
                Pen p = new Pen(MyColorAction, 1);
                int J = (MyPainter.J1 + MyPainter.J2) >> 1;
                g.DrawLine(p, MyPainter.I1, J, MyPainter.I2, J);
                int I = (MyPainter.I1 + MyPainter.I2) >> 1;
                g.DrawLine(p, I, MyPainter.J1, I, MyPainter.J2);
            }
        }

        public void ChangeColors(Color Action, Color BackGround)
        {
            MyColorAction = Action;
            MyColorBackGround = BackGround;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormChild : Form
    {
        public FormChild()
        {
            InitializeComponent();
        }
        public string figure;

        public string color;
        private void FormChild_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g = CreateGraphics();
            g.Clear(Color.Azure);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            if (color == "Red")
                solidBrush = new SolidBrush(Color.Red);
            else if (color == "Green")
                solidBrush = new SolidBrush(Color.Green);
            else if (color == "Blue")
                solidBrush = new SolidBrush(Color.Blue);
            if (figure == "Circle")
                g.FillEllipse(solidBrush, new Rectangle(30, 30, 100, 100));
            else if (figure == "Square")
                g.FillRectangle(solidBrush, new Rectangle(30, 30, 100, 100));
            if (figure == "Triangle")
                DrawTriangle(g, 13, 35, solidBrush);
        }
        void DrawTriangle(Graphics g, float x0, float y0, Brush brush)
        {
            Pen triangle = new Pen(Color.Black, 1); // заготавливаем карандаши и кисти

            g.DrawPolygon(triangle, new PointF[] { new PointF(x0 + 10, y0), new PointF(x0 + 65, y0 + 90), new PointF(x0 + 120, y0) });
            g.FillPolygon(brush, new PointF[] { new PointF(x0 + 10, y0), new PointF(x0 + 65, y0 + 90), new PointF(x0 + 120, y0) });
        }
            private void FormChild_Load(object sender, EventArgs e)
        {

        }
    }
}

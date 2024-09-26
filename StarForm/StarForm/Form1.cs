using System;
using System.Drawing;
using System.Windows.Forms;

namespace StarForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.panel1.Paint += new PaintEventHandler(Panel1_Paint);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Fuchsia, 2);
            SolidBrush brush = new SolidBrush(Color.Fuchsia);

            Point[] starPoints = {
                new Point(100, 10),
                new Point(120, 70),
                new Point(190, 70),
                new Point(130, 110),
                new Point(150, 180),
                new Point(100, 140),
                new Point(50, 180),
                new Point(70, 110),
                new Point(10, 70),
                new Point(80, 70)
            };

            g.FillPolygon(brush, starPoints);
            g.DrawPolygon(pen, starPoints);
        }
    }
}

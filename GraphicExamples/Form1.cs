using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphic tools
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 20, FontStyle.Italic);

            //Drawing for fun
            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawRectangle(drawPen, 30, 30, 100, 200);
            g.FillRectangle(drawBrush, 30, 30, 100, 200);
            g.DrawEllipse(drawPen, 60, 230, 200, 100);
            g.DrawEllipse(drawPen, 110, 230, 100, 100);
            g.FillEllipse(drawBrush, 110,230,100,100);
            g.DrawEllipse(drawPen, 260, 230, 200, 100);
            g.DrawEllipse(drawPen, 310, 230, 100, 100);
            g.FillEllipse(drawBrush, 310, 230, 100, 100);
            g.DrawArc(drawPen, 200, 20, 50, 50, 90, 180);
            g.DrawPie(drawPen, 300, 20, 50, 50, 30, 300);

            //Writing
            g.DrawString("Hello\nHow are you?", drawFont, drawBrush, 500, 40);
        }
    }
}

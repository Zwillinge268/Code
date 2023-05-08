using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20160526A_GraphicDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Doodle(int x, int y, string type)
        {
            Graphics Graphic = this.CreateGraphics();
            Random RN = new Random();
            int width = RN.Next(50, 300);
            int height = RN.Next(50, 200);
            Rectangle Area = new Rectangle(x, y, width, height);

            switch(type)
            {    
                case "Line":
                    Graphic.DrawLine(Pens.Coral, 0, 0, x, y);
                    break;

                case "Circle":

                    x -= width / 2;
                    y -= width / 2;

                    Graphic.DrawEllipse(Pens.Purple, x, y, width, width);
                    // .DrawfillEllipse = 填滿橢圓

                    break;

                case "Rectangle":

                    //Graphic.DrawRectangle(Pens.Purple, x, y, width, height);
                    Graphic.DrawRectangle(Pens.Purple, Area);
                    // .DrawfillRectangle = 填滿距形

                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Doodle(e.X, e.Y, "Line");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Doodle(e.X, e.Y, "Circle");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Doodle(e.X, e.Y, "Rectangle");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics Graphic = this.CreateGraphics();

            for (int xi = 0; xi <= this.Width; xi += 30)
            {
                Graphic.DrawLine(Pens.Coral, xi, 0, xi, this.Height);
            }
            for (int yi = 0; yi <= this.Width; yi += 30)
            {
                Graphic.DrawLine(Pens.Blue, 0, yi, this.Width, yi);
            }
        }
    }
}

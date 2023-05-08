using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Graph_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics G = this.CreateGraphics();
            this.Refresh();

            for (int i = 0; i < e.Y; i += 10)
            {
                G.DrawLine(Pens.Blue, 0, i, e.X, i);
                Thread.Sleep(10);
            }
            for (int i = e.Y; i < this.Height; i += 10)
            {
                G.DrawLine(Pens.Blue, e.X, i, this.Width, i);
                Thread.Sleep(10);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics G = this.CreateGraphics();

            for (int i = e.X; i < this.Width; i += 10)
            {
                G.DrawLine(Pens.Red, i, 0, i, e.Y);
                Thread.Sleep(10);
            }
            for (int i = 0; i < e.X; i += 10)
            {
                G.DrawLine(Pens.Red, i, e.Y, i, this.Height);
                Thread.Sleep(10);
            }
        }
    }
}

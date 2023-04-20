using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;

namespace Graph_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "(X,Y) = " + e.X + " , " + e.Y;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int Len, times;           
            this.Refresh();

            float MidX = this.Width / 2;
            float MidY = this.Height / 2;

            this.Text = "中心 = " + "(" + MidX + "," + MidY + ")   ";

            try
            {
                times = int.Parse(VB.Interaction.InputBox("請輸入循環次數", "請輸入循環次數"));
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            if (this.Height > this.Width)
            {
                Len = this.Width;
            }
            else
            {
                Len = this.Height - 45;
            }

            for (int i = times; i > 0; i--)
            {               
                DrawBlueCircle(MidX, MidY, Len);
                this.Text += i + "; ";
            }           
        }

        private void DrawBlueCircle(float MidX, float MidY, int Len)
        {
            Graphics Graph = this.CreateGraphics();

            for (float i = 0; i < Len - 25; i += 1)
            {
                MidX -= (float)0.5; MidY -= (float)0.5;
                Graph.DrawEllipse(Pens.DarkBlue, MidX, MidY, i, i);                
            }
            for (float i = Len - 25; i > 0; i -= 1)
            {
                Graph.DrawEllipse(Pens.DarkGreen, MidX, MidY, i, i);
                MidX += (float)0.5; MidY += (float)0.5;
            }
        }
    }
}

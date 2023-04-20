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

namespace Project_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random RN = new Random();

        private void 動態產生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1. Class ---> Object
            TextBox TB1 = new TextBox();
            TextBox TB2 = new TextBox();
            FontDialog FD = new FontDialog();

            //2. Properties Setting
            TB1.Name = "TB1A";
            TB1.BackColor = Color.Aquamarine;
            TB1.Width = 150;
            TB1.Top = RN.Next(200, 801);
            TB1.Left = RN.Next(50, 701);
            TB1.Text = "資一甲";
            TB1.TextAlign = HorizontalAlignment.Center;
            if (FD.ShowDialog() == DialogResult.OK) TB1.Font = FD.Font;

            TB2.Name = "TB1B";
            TB2.BackColor = Color.Gold;
            TB2.Width = 250;
            TB2.Height = 20;
            TB2.Top = RN.Next(200, 801);
            TB2.Left = RN.Next(50, 701);
            TB2.Text = "資一乙";
            TB2.TextAlign = HorizontalAlignment.Center;
            if (FD.ShowDialog() == DialogResult.OK) TB2.Font = FD.Font;

            //3. Event handler
            TB1.Click += new EventHandler(OnClick);
            TB2.Click += new EventHandler(OnClick);

            //4. Add Control to From
            this.Controls.Add(TB1);
            this.Controls.Add(TB2);
            this.Text = "Number of Controls: " + this.Controls.Count;

        }

        private void OnClick(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "TB1A") ((TextBox)sender).Text = DateTime.Now.ToLongDateString();
            if (((TextBox)sender).Name == "TB1B") ((TextBox)sender).Text = DateTime.Now.ToLongTimeString();
        }

        private void 移除TextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool HaveTB = true;
            while(HaveTB)
            {
                HaveTB = false;
                foreach(Control ctrl in this.Controls)
                {
                    if(ctrl.GetType() == typeof(TextBox))
                    {
                        this.Controls.Remove(ctrl);
                        HaveTB = true;
                    }
                }
            }
            this.Text = "Number of Controls: " + this.Controls.Count;
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(VB.Interaction.InputBox("請輸入產生個數"), out int number)) return;
            for (int i = 1; i <= number; i++)
            {
                //1. Class ---> Object
                Button BT = new Button();

                //2. Properties Setting
                BT.BackColor = Color.ForestGreen;
                BT.Width = RN.Next(50, 250);
                BT.Height = RN.Next(30, 90);
                BT.Top = RN.Next(10, 801);
                BT.Left = RN.Next(10, 1300);
                BT.Font = new Font(Font.FontFamily, 30, FontStyle.Bold);

                //3. Event handler
                BT.Click += new EventHandler(ButtonClick);

                //4. Add Control to From
                this.Controls.Add(BT);
            }
            this.Text = "Number of Controls: " + this.Controls.Count;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = VB.Interaction.InputBox("請輸入内容：");
        }

        private void 移除所有方塊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool HaveAny = true;
            while (HaveAny)
            {
                HaveAny = false;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() != typeof(MenuStrip))
                    {
                        this.Controls.Remove(ctrl);
                        HaveAny = true;
                    }
                }
            }
            this.Text = "Number of Controls: " + this.Controls.Count;
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox PB = new PictureBox();
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg|所有檔案|*.*";

            int SL = RN.Next(100, 401);
            PB.Height = SL;
            PB.Width = SL;
            PB.Top = RN.Next(150, 701);
            PB.Left = RN.Next(10, 601);
            this.Text = "邊長(Top, Left)：" + SL + "(" + PB.Top + ", " + PB.Left + ")";
            PB.SizeMode = PictureBoxSizeMode.StretchImage;

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                PB.ImageLocation = OFD.FileName;
                this.Controls.Add(PB);
            }
            this.Text = "Number of Controls: " + this.Controls.Count;

        }
    }
}

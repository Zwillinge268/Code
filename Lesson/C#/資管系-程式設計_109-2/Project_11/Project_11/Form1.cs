using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace Project_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int start, counter;

        private void VSB_Scroll(object sender, ScrollEventArgs e)
        {
            QRC.Height = VSB.Value;
            QRC.Width = VSB.Value;
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(VB.Interaction.InputBox("請輸入秒數"), out counter))
            {
                start = 1;
                timer1.Enabled = true;
                this.Text = DateTime.Now.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bg, fg;

            ColorDialog CD = new ColorDialog();
            MessageBox.Show("請選擇背景顔色", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (CD.ShowDialog() == DialogResult.OK)
            {
                bg = CD.Color.R.ToString() + "-" + CD.Color.G.ToString() + "-" + CD.Color.B.ToString();
            }
            else return;

            MessageBox.Show("請選擇前景顔色", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (CD.ShowDialog() == DialogResult.OK)
            {
                fg = CD.Color.R.ToString() + "-" + CD.Color.G.ToString() + "-" + CD.Color.B.ToString();
            }
            else return;

            string px = VB.Interaction.InputBox("請輸入像素尺寸", "QR Code 大小");
            string URL = "http://api.qrserver.com/v1/create-qr-code/?data=" + Demo.Text + "&ecc=H" + "&size=" +
                          px + "+" + px + "&bgcolor=" + bg + "&color=" + fg;
            this.Text = URL;
            QRC.Load(URL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1. Dialog Set
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Select a logo file";
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Save QRCode with logo to file";
            ColorDialog CD = new ColorDialog();

            //2. Gernerate a QR Code Encoder & Properties Setting
            QRCodeEncoder QRCEncoder = new QRCodeEncoder();
            QRCEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            QRCEncoder.QRCodeScale = 15;

            MessageBox.Show("請選擇背景顔色", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (CD.ShowDialog() == DialogResult.OK)
            {
                QRCEncoder.QRCodeBackgroundColor = CD.Color;
            }
            else return;

            MessageBox.Show("請選擇前景顔色", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (CD.ShowDialog() == DialogResult.OK)
            {
                QRCEncoder.QRCodeForegroundColor = CD.Color;
            }
            else return;

            //3. Create a QR Code (BMP)
            Bitmap BM = QRCEncoder.Encode(Demo.Text, Encoding.UTF8);

            //4. Load Logo into Image
            Image Logo;
            if (OFD.ShowDialog() == DialogResult.OK) Logo = Image.FromFile(OFD.FileName);
            else return;

            //5. Set a graphic from bitmap
            Graphics G = Graphics.FromImage(BM);

            //6. Location of the logo on QR Code
            int left = (BM.Width / 2) - (Logo.Width / 2);
            int top = (BM.Height / 2) - (Logo.Height / 2);
            G.DrawImage(Logo, new Point(left, top));
            G.DrawImage(Logo, new Point(BM.Width - Logo.Width, BM.Height - Logo.Height));

            //7. Save QR Code to picture file
            if(SFD.ShowDialog() == DialogResult.OK)
            {
                BM.Save(SFD.FileName, ImageFormat.Png);
                QRC.ImageLocation = SFD.FileName;
                Process.Start(SFD.FileName);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start++;
            Demo.Text = DateTime.Now.ToString();
            if (start > counter) timer1.Enabled = false;
        }
    }
}

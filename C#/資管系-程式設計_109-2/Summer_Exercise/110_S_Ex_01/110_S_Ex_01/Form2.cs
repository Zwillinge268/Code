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
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Common;

namespace _110_S_Ex_01
{
    public partial class Form2 : Form
    {
        Random RN = new Random();      
        int SL;

        public Form2()
        {
            InitializeComponent();
        }

        private void 產生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            PictureBox PB = new PictureBox();

            SL = RN.Next(85, 201);
            PB.Height = SL;
            PB.Width = SL;
            PB.Top = RN.Next(60, 751);
            PB.Left = RN.Next(60, 1501);
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            PB.BackColor = Color.SeaGreen;

            PB.Click += new EventHandler(PBClick);

            this.Controls.Add(PB);

            this.Text = "Number of Controls: " + this.Controls.Count;
        }

        private void PBClick(object sender, EventArgs e)
        {
            string input = VB.Interaction.InputBox("請輸入文字或網址");
            if (input == null) return;
            
            BarcodeWriter BCR = new BarcodeWriter();

            BCR.Format = BarcodeFormat.QR_CODE;
            BCR.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            BCR.Options.Height = SL;
            BCR.Options.Width = SL;
            BCR.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            BitMatrix bm = BCR.Encode(input);
            Bitmap QRCode = BCR.Write(bm);

            ((PictureBox)sender).Image = QRCode;

            input = null;
        }

        private void 移除ToolStripMenuItem_Click(object sender, EventArgs e)
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
        }
    }
}

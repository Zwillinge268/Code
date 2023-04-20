namespace Project_07
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Reset;
            this.panel1 = new System.Windows.Forms.Panel();
            this.PGB = new System.Windows.Forms.ProgressBar();
            this.Counter = new System.Windows.Forms.Label();
            this.Guess = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset
            // 
            Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            Reset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            Reset.ForeColor = System.Drawing.SystemColors.ControlText;
            Reset.Location = new System.Drawing.Point(13, 13);
            Reset.Name = "Reset";
            Reset.Size = new System.Drawing.Size(143, 38);
            Reset.TabIndex = 0;
            Reset.Text = "猜數字（0-9）30秒";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PGB);
            this.panel1.Controls.Add(this.Counter);
            this.panel1.Controls.Add(this.Guess);
            this.panel1.Controls.Add(Reset);
            this.panel1.Location = new System.Drawing.Point(25, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 112);
            this.panel1.TabIndex = 0;
            // 
            // PGB
            // 
            this.PGB.Location = new System.Drawing.Point(13, 67);
            this.PGB.Maximum = 30;
            this.PGB.Name = "PGB";
            this.PGB.Size = new System.Drawing.Size(297, 23);
            this.PGB.Step = -1;
            this.PGB.TabIndex = 3;
            this.PGB.Value = 30;
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Counter.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Counter.Location = new System.Drawing.Point(258, 13);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(52, 38);
            this.Counter.TabIndex = 2;
            this.Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Guess
            // 
            this.Guess.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guess.Location = new System.Drawing.Point(179, 13);
            this.Guess.MaxLength = 1;
            this.Guess.Multiline = true;
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(53, 38);
            this.Guess.TabIndex = 1;
            this.Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Guess.TextChanged += new System.EventHandler(this.Guess_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Controls.Add(this.hScrollBar1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(25, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 578);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(195, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "自動播放";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(531, 24);
            this.vScrollBar1.Maximum = 480;
            this.vScrollBar1.Minimum = 50;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(45, 480);
            this.vScrollBar1.SmallChange = 10;
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Value = 480;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(304, 523);
            this.hScrollBar1.Maximum = 3000;
            this.hScrollBar1.Minimum = 300;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(201, 39);
            this.hScrollBar1.SmallChange = 10;
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 1500;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-秋色",
            "2-日落",
            "3-微軟",
            "4-夕陽",
            "5-沙漠"});
            this.comboBox1.Location = new System.Drawing.Point(25, 523);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 39);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "景物圖";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 783);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.ProgressBar PGB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
    }
}


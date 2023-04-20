namespace CS20210803_Synchronous
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RYG = new System.Windows.Forms.GroupBox();
            this.Yellow = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.counter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.KYellow = new System.Windows.Forms.RadioButton();
            this.KGreen = new System.Windows.Forms.RadioButton();
            this.KRed = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.RYG.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(54, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大學年級";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 159);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "大四";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 114);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "大三";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "大二";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "大一";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(275, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "水果";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 145);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(62, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Pear";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 115);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(122, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Watermelon";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 85);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Banana";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Apple";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // RYG
            // 
            this.RYG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RYG.Controls.Add(this.Yellow);
            this.RYG.Controls.Add(this.Green);
            this.RYG.Controls.Add(this.Red);
            this.RYG.Controls.Add(this.counter);
            this.RYG.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RYG.Location = new System.Drawing.Point(54, 301);
            this.RYG.Name = "RYG";
            this.RYG.Size = new System.Drawing.Size(155, 246);
            this.RYG.TabIndex = 2;
            this.RYG.TabStop = false;
            this.RYG.Text = "建興路";
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(55, 129);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(37, 24);
            this.Yellow.TabIndex = 3;
            this.Yellow.TabStop = true;
            this.Yellow.Text = "Y";
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.CheckedChanged += new System.EventHandler(this.Yellow_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Lime;
            this.Green.Location = new System.Drawing.Point(55, 159);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(39, 24);
            this.Green.TabIndex = 2;
            this.Green.TabStop = true;
            this.Green.Text = "G";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(55, 99);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(37, 24);
            this.Red.TabIndex = 1;
            this.Red.TabStop = true;
            this.Red.Text = "R";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // counter
            // 
            this.counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.counter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.counter.Location = new System.Drawing.Point(55, 39);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(42, 33);
            this.counter.TabIndex = 0;
            this.counter.Text = "15";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.KYellow);
            this.groupBox3.Controls.Add(this.KGreen);
            this.groupBox3.Controls.Add(this.KRed);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(275, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 246);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "康樂路";
            // 
            // KYellow
            // 
            this.KYellow.BackColor = System.Drawing.Color.Yellow;
            this.KYellow.Enabled = false;
            this.KYellow.Location = new System.Drawing.Point(56, 103);
            this.KYellow.Name = "KYellow";
            this.KYellow.Size = new System.Drawing.Size(50, 50);
            this.KYellow.TabIndex = 6;
            this.KYellow.TabStop = true;
            this.KYellow.Text = "Y";
            this.KYellow.UseVisualStyleBackColor = false;
            // 
            // KGreen
            // 
            this.KGreen.BackColor = System.Drawing.Color.Lime;
            this.KGreen.Enabled = false;
            this.KGreen.Location = new System.Drawing.Point(56, 159);
            this.KGreen.Name = "KGreen";
            this.KGreen.Size = new System.Drawing.Size(50, 50);
            this.KGreen.TabIndex = 5;
            this.KGreen.TabStop = true;
            this.KGreen.Text = "G";
            this.KGreen.UseVisualStyleBackColor = false;
            // 
            // KRed
            // 
            this.KRed.BackColor = System.Drawing.Color.Red;
            this.KRed.Enabled = false;
            this.KRed.Location = new System.Drawing.Point(56, 47);
            this.KRed.Name = "KRed";
            this.KRed.Size = new System.Drawing.Size(50, 50);
            this.KRed.TabIndex = 4;
            this.KRed.TabStop = true;
            this.KRed.Text = "R";
            this.KRed.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RYG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.RYG.ResumeLayout(false);
            this.RYG.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox RYG;
        private System.Windows.Forms.RadioButton Yellow;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton KYellow;
        private System.Windows.Forms.RadioButton KGreen;
        private System.Windows.Forms.RadioButton KRed;
        private System.Windows.Forms.Timer timer1;
    }
}


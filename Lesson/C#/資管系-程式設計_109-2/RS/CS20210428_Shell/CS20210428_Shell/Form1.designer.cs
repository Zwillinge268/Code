namespace CS20210428_Shell
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LCMValue = new System.Windows.Forms.Label();
            this.GCDValue = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.LCMValue);
            this.groupBox1.Controls.Add(this.GCDValue);
            this.groupBox1.Controls.Add(this.N1);
            this.groupBox1.Controls.Add(this.N2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(523, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 380);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GCD-LCM";
            // 
            // LCMValue
            // 
            this.LCMValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCMValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LCMValue.Location = new System.Drawing.Point(34, 228);
            this.LCMValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCMValue.Name = "LCMValue";
            this.LCMValue.Size = new System.Drawing.Size(165, 43);
            this.LCMValue.TabIndex = 16;
            this.LCMValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GCDValue
            // 
            this.GCDValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GCDValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GCDValue.Location = new System.Drawing.Point(33, 151);
            this.GCDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GCDValue.Name = "GCDValue";
            this.GCDValue.Size = new System.Drawing.Size(165, 43);
            this.GCDValue.TabIndex = 15;
            this.GCDValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(31, 27);
            this.N1.Margin = new System.Windows.Forms.Padding(4);
            this.N1.MaxLength = 10;
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(166, 27);
            this.N1.TabIndex = 13;
            this.N1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // N2
            // 
            this.N2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.N2.Location = new System.Drawing.Point(33, 87);
            this.N2.Margin = new System.Windows.Forms.Padding(4);
            this.N2.MaxLength = 10;
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(166, 27);
            this.N2.TabIndex = 14;
            this.N2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Create ID Files",
            "Factorial",
            "Fibonacci Number",
            "GCD & LCM",
            "Bubble Sort",
            "Quick Sort",
            "Bibary Search",
            "HanoiTower"});
            this.comboBox1.Location = new System.Drawing.Point(523, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 27);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "請選擇";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Display.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Display.Location = new System.Drawing.Point(44, 159);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display.Size = new System.Drawing.Size(451, 380);
            this.Display.TabIndex = 37;
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Number.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number.Location = new System.Drawing.Point(523, 12);
            this.Number.MaxLength = 10;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(223, 30);
            this.Number.TabIndex = 42;
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::CS20210428_Shell.Properties.Resources.Tower_of_Hanoi_4;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 130);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 622);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LCMValue;
        private System.Windows.Forms.Label GCDValue;
        internal System.Windows.Forms.TextBox N1;
        internal System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Number;
    }
}


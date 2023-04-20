namespace Project_11
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
            this.Demo = new System.Windows.Forms.TextBox();
            this.QRC = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VSB = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRC)).BeginInit();
            this.SuspendLayout();
            // 
            // Demo
            // 
            this.Demo.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Demo.Location = new System.Drawing.Point(60, 37);
            this.Demo.Name = "Demo";
            this.Demo.Size = new System.Drawing.Size(433, 33);
            this.Demo.TabIndex = 0;
            this.Demo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Demo.Click += new System.EventHandler(this.Demo_Click);
            // 
            // QRC
            // 
            this.QRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.QRC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRC.Location = new System.Drawing.Point(60, 102);
            this.QRC.Name = "QRC";
            this.QRC.Size = new System.Drawing.Size(350, 350);
            this.QRC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRC.TabIndex = 1;
            this.QRC.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VSB
            // 
            this.VSB.Location = new System.Drawing.Point(456, 102);
            this.VSB.Maximum = 358;
            this.VSB.Minimum = 50;
            this.VSB.Name = "VSB";
            this.VSB.Size = new System.Drawing.Size(37, 350);
            this.VSB.SmallChange = 10;
            this.VSB.TabIndex = 2;
            this.VSB.Value = 350;
            this.VSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VSB_Scroll);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(60, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Colour QR Code";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(266, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Web API";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(165, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "With Logo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(565, 591);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VSB);
            this.Controls.Add(this.QRC);
            this.Controls.Add(this.Demo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QRC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Demo;
        private System.Windows.Forms.PictureBox QRC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.VScrollBar VSB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


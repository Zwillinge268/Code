namespace CS20210803_Railway
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
            this.start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.go = new System.Windows.Forms.RadioButton();
            this.stop = new System.Windows.Forms.RadioButton();
            this.Y = new System.Windows.Forms.RadioButton();
            this.R = new System.Windows.Forms.RadioButton();
            this.G = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.start.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(86, 27);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(213, 47);
            this.start.TabIndex = 0;
            this.start.Text = "模擬";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.go);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(29, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "行人";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.G);
            this.groupBox2.Controls.Add(this.R);
            this.groupBox2.Controls.Add(this.Y);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(216, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "10";
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.go.Enabled = false;
            this.go.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.go.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.go.Location = new System.Drawing.Point(42, 64);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(66, 28);
            this.go.TabIndex = 0;
            this.go.Text = "穿越";
            this.go.UseVisualStyleBackColor = false;
            this.go.CheckedChanged += new System.EventHandler(this.go_CheckedChanged);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.stop.Checked = true;
            this.stop.Enabled = false;
            this.stop.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stop.ForeColor = System.Drawing.Color.Purple;
            this.stop.Location = new System.Drawing.Point(42, 158);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(66, 28);
            this.stop.TabIndex = 1;
            this.stop.TabStop = true;
            this.stop.Text = "停步";
            this.stop.UseVisualStyleBackColor = false;
            // 
            // Y
            // 
            this.Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Y.Checked = true;
            this.Y.Enabled = false;
            this.Y.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Y.Location = new System.Drawing.Point(6, 47);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(136, 45);
            this.Y.TabIndex = 0;
            this.Y.TabStop = true;
            this.Y.Text = "火車將到 (10s)";
            this.Y.UseVisualStyleBackColor = false;
            this.Y.CheckedChanged += new System.EventHandler(this.Y_CheckedChanged);
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.Red;
            this.R.Enabled = false;
            this.R.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.R.Location = new System.Drawing.Point(6, 116);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(136, 45);
            this.R.TabIndex = 1;
            this.R.Text = "火車通過 (5s)";
            this.R.UseVisualStyleBackColor = false;
            this.R.CheckedChanged += new System.EventHandler(this.R_CheckedChanged);
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Lime;
            this.G.Enabled = false;
            this.G.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.G.Location = new System.Drawing.Point(6, 184);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(136, 45);
            this.G.TabIndex = 2;
            this.G.Text = "火車離去 (15s)";
            this.G.UseVisualStyleBackColor = false;
            this.G.CheckedChanged += new System.EventHandler(this.G_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton stop;
        private System.Windows.Forms.RadioButton go;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton G;
        private System.Windows.Forms.RadioButton R;
        private System.Windows.Forms.RadioButton Y;
        private System.Windows.Forms.Timer timer1;
    }
}


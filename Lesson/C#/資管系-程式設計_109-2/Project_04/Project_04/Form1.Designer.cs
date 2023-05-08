
namespace Project_04
{
    partial class IMAB
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
            this.Display = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Switch = new System.Windows.Forms.Button();
            this.DisplayA = new System.Windows.Forms.TextBox();
            this.DisplayB = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Nth = new System.Windows.Forms.TextBox();
            this.SleepTime = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Display.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Display.Location = new System.Drawing.Point(352, 42);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(256, 35);
            this.Display.TabIndex = 0;
            this.Display.Text = "資一甲乙班大隊接力賽";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Display.MouseEnter += new System.EventHandler(this.Display_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Switch
            // 
            this.Switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Switch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Switch.Location = new System.Drawing.Point(762, 42);
            this.Switch.Name = "Switch";
            this.Switch.Size = new System.Drawing.Size(112, 35);
            this.Switch.TabIndex = 1;
            this.Switch.Text = "On/Off";
            this.Switch.UseVisualStyleBackColor = false;
            this.Switch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // DisplayA
            // 
            this.DisplayA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DisplayA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DisplayA.Location = new System.Drawing.Point(79, 133);
            this.DisplayA.Multiline = true;
            this.DisplayA.Name = "DisplayA";
            this.DisplayA.ReadOnly = true;
            this.DisplayA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayA.Size = new System.Drawing.Size(310, 345);
            this.DisplayA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.DisplayA, "甲班結果");
            // 
            // DisplayB
            // 
            this.DisplayB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DisplayB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DisplayB.Location = new System.Drawing.Point(564, 133);
            this.DisplayB.Multiline = true;
            this.DisplayB.Name = "DisplayB";
            this.DisplayB.ReadOnly = true;
            this.DisplayB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayB.Size = new System.Drawing.Size(310, 345);
            this.DisplayB.TabIndex = 3;
            this.toolTip1.SetToolTip(this.DisplayB, "乙班結果");
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Start.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Start.Location = new System.Drawing.Point(79, 42);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 35);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Nth
            // 
            this.Nth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Nth.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Nth.ForeColor = System.Drawing.Color.Blue;
            this.Nth.Location = new System.Drawing.Point(438, 180);
            this.Nth.MaxLength = 2;
            this.Nth.Name = "Nth";
            this.Nth.Size = new System.Drawing.Size(78, 35);
            this.Nth.TabIndex = 5;
            this.Nth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.Nth, "人數");
            this.Nth.TextChanged += new System.EventHandler(this.Nth_TextChanged);
            this.Nth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nth_KeyPress);
            // 
            // SleepTime
            // 
            this.SleepTime.BackColor = System.Drawing.Color.Plum;
            this.SleepTime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SleepTime.ForeColor = System.Drawing.Color.Blue;
            this.SleepTime.Location = new System.Drawing.Point(438, 251);
            this.SleepTime.MaxLength = 4;
            this.SleepTime.Name = "SleepTime";
            this.SleepTime.Size = new System.Drawing.Size(78, 35);
            this.SleepTime.TabIndex = 6;
            this.SleepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.SleepTime, "Max Sleep Time");
            this.SleepTime.TextChanged += new System.EventHandler(this.SleepTime_TextChanged);
            this.SleepTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SleepTime_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 6500;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // IMAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(966, 589);
            this.Controls.Add(this.SleepTime);
            this.Controls.Add(this.Nth);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.DisplayB);
            this.Controls.Add(this.DisplayA);
            this.Controls.Add(this.Switch);
            this.Controls.Add(this.Display);
            this.Name = "IMAB";
            this.Text = "IMAB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IMAB_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IMAB_FormClosed);
            this.Load += new System.EventHandler(this.IMAB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Switch;
        private System.Windows.Forms.TextBox DisplayA;
        private System.Windows.Forms.TextBox DisplayB;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Nth;
        private System.Windows.Forms.TextBox SleepTime;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


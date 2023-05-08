namespace _20170518_DateTimePicker_MonthCalendar_CheckBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.Receipt = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NUD_LCDP = new System.Windows.Forms.NumericUpDown();
            this.NUD_LCD = new System.Windows.Forms.NumericUpDown();
            this.LCD = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NUD_CPUP = new System.Windows.Forms.NumericUpDown();
            this.NUD_CPU = new System.Windows.Forms.NumericUpDown();
            this.CPU = new System.Windows.Forms.CheckBox();
            this.Check = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EndDate = new System.Windows.Forms.RadioButton();
            this.StartDate = new System.Windows.Forms.RadioButton();
            this.MCD = new System.Windows.Forms.MonthCalendar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Set = new System.Windows.Forms.Button();
            this.DTP_end = new System.Windows.Forms.DateTimePicker();
            this.DTP_start = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LCDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LCD)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CPUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CPU)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.DTP);
            this.panel1.Controls.Add(this.Receipt);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 582);
            this.panel1.TabIndex = 0;
            // 
            // DTP
            // 
            this.DTP.CalendarFont = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTP.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTP.Location = new System.Drawing.Point(14, 258);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(166, 27);
            this.DTP.TabIndex = 2;
            // 
            // Receipt
            // 
            this.Receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Receipt.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Receipt.FormattingEnabled = true;
            this.Receipt.ItemHeight = 16;
            this.Receipt.Location = new System.Drawing.Point(14, 307);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(279, 244);
            this.Receipt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.Check);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "購物籃";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.NUD_LCDP);
            this.panel3.Controls.Add(this.NUD_LCD);
            this.panel3.Controls.Add(this.LCD);
            this.panel3.Location = new System.Drawing.Point(16, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 48);
            this.panel3.TabIndex = 2;
            // 
            // NUD_LCDP
            // 
            this.NUD_LCDP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD_LCDP.Location = new System.Drawing.Point(147, 11);
            this.NUD_LCDP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_LCDP.Name = "NUD_LCDP";
            this.NUD_LCDP.Size = new System.Drawing.Size(78, 29);
            this.NUD_LCDP.TabIndex = 4;
            this.NUD_LCDP.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.NUD_LCDP.Visible = false;
            // 
            // NUD_LCD
            // 
            this.NUD_LCD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD_LCD.Location = new System.Drawing.Point(72, 11);
            this.NUD_LCD.Name = "NUD_LCD";
            this.NUD_LCD.Size = new System.Drawing.Size(53, 29);
            this.NUD_LCD.TabIndex = 3;
            this.NUD_LCD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_LCD.Visible = false;
            // 
            // LCD
            // 
            this.LCD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LCD.Location = new System.Drawing.Point(3, 3);
            this.LCD.Name = "LCD";
            this.LCD.Size = new System.Drawing.Size(63, 42);
            this.LCD.TabIndex = 1;
            this.LCD.Text = "LCD";
            this.LCD.UseVisualStyleBackColor = true;
            this.LCD.CheckedChanged += new System.EventHandler(this.LCD_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.NUD_CPUP);
            this.panel2.Controls.Add(this.NUD_CPU);
            this.panel2.Controls.Add(this.CPU);
            this.panel2.Location = new System.Drawing.Point(16, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 48);
            this.panel2.TabIndex = 1;
            // 
            // NUD_CPUP
            // 
            this.NUD_CPUP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD_CPUP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NUD_CPUP.Location = new System.Drawing.Point(147, 11);
            this.NUD_CPUP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_CPUP.Name = "NUD_CPUP";
            this.NUD_CPUP.Size = new System.Drawing.Size(78, 29);
            this.NUD_CPUP.TabIndex = 2;
            this.NUD_CPUP.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUD_CPUP.Visible = false;
            // 
            // NUD_CPU
            // 
            this.NUD_CPU.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NUD_CPU.Location = new System.Drawing.Point(72, 11);
            this.NUD_CPU.Name = "NUD_CPU";
            this.NUD_CPU.Size = new System.Drawing.Size(53, 29);
            this.NUD_CPU.TabIndex = 1;
            this.NUD_CPU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_CPU.Visible = false;
            // 
            // CPU
            // 
            this.CPU.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU.Location = new System.Drawing.Point(3, 3);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(63, 42);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "CPU";
            this.CPU.UseVisualStyleBackColor = true;
            this.CPU.CheckedChanged += new System.EventHandler(this.CPU_CheckedChanged);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Check.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Check.Location = new System.Drawing.Point(16, 34);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(57, 34);
            this.Check.TabIndex = 0;
            this.Check.Text = "結賬";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.EndDate);
            this.panel4.Controls.Add(this.StartDate);
            this.panel4.Location = new System.Drawing.Point(355, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 49);
            this.panel4.TabIndex = 1;
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EndDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndDate.Location = new System.Drawing.Point(127, 15);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(65, 23);
            this.EndDate.TabIndex = 1;
            this.EndDate.Text = "迄日";
            this.EndDate.UseVisualStyleBackColor = false;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StartDate.Checked = true;
            this.StartDate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartDate.Location = new System.Drawing.Point(26, 15);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(65, 23);
            this.StartDate.TabIndex = 0;
            this.StartDate.TabStop = true;
            this.StartDate.Text = "啓日";
            this.StartDate.UseVisualStyleBackColor = false;
            // 
            // MCD
            // 
            this.MCD.BackColor = System.Drawing.Color.Teal;
            this.MCD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MCD.Location = new System.Drawing.Point(355, 122);
            this.MCD.MaxSelectionCount = 999;
            this.MCD.Name = "MCD";
            this.MCD.ShowWeekNumbers = true;
            this.MCD.TabIndex = 2;
            this.MCD.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MCD.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MCD.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MCD_DateSelected);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.Set);
            this.panel5.Controls.Add(this.DTP_end);
            this.panel5.Controls.Add(this.DTP_start);
            this.panel5.Location = new System.Drawing.Point(355, 320);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 275);
            this.panel5.TabIndex = 3;
            // 
            // Set
            // 
            this.Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Set.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Set.Location = new System.Drawing.Point(198, 15);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(94, 51);
            this.Set.TabIndex = 2;
            this.Set.Text = "Set Range";
            this.Set.UseVisualStyleBackColor = false;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // DTP_end
            // 
            this.DTP_end.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTP_end.Location = new System.Drawing.Point(311, 25);
            this.DTP_end.Name = "DTP_end";
            this.DTP_end.Size = new System.Drawing.Size(162, 27);
            this.DTP_end.TabIndex = 1;
            // 
            // DTP_start
            // 
            this.DTP_start.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DTP_start.Location = new System.Drawing.Point(17, 25);
            this.DTP_start.Name = "DTP_start";
            this.DTP_start.Size = new System.Drawing.Size(162, 27);
            this.DTP_start.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "年",
            "季",
            "月",
            "周",
            "日",
            "小時"});
            this.comboBox1.Location = new System.Drawing.Point(183, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "日期差距";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.year);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(602, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 49);
            this.panel6.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(36, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "選擇年份";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.year.Location = new System.Drawing.Point(123, 11);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(85, 27);
            this.year.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 608);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.MCD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LCDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_LCD)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CPUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_CPU)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.CheckBox LCD;
        private System.Windows.Forms.CheckBox CPU;
        private System.Windows.Forms.NumericUpDown NUD_LCDP;
        private System.Windows.Forms.NumericUpDown NUD_LCD;
        private System.Windows.Forms.NumericUpDown NUD_CPUP;
        private System.Windows.Forms.NumericUpDown NUD_CPU;
        private System.Windows.Forms.ListBox Receipt;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton EndDate;
        private System.Windows.Forms.RadioButton StartDate;
        private System.Windows.Forms.MonthCalendar MCD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker DTP_end;
        private System.Windows.Forms.DateTimePicker DTP_start;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox year;
    }
}


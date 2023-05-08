namespace Project_08
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
            this.Sorting = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Lowest = new System.Windows.Forms.Label();
            this.Highest = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Eng = new System.Windows.Forms.Button();
            this.SelAll = new System.Windows.Forms.Button();
            this.STNum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Sorting);
            this.panel1.Controls.Add(this.Remove);
            this.panel1.Controls.Add(this.Lowest);
            this.panel1.Controls.Add(this.Highest);
            this.panel1.Controls.Add(this.Counter);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(427, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 639);
            this.panel1.TabIndex = 0;
            // 
            // Sorting
            // 
            this.Sorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Sorting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sorting.Location = new System.Drawing.Point(106, 317);
            this.Sorting.Name = "Sorting";
            this.Sorting.Size = new System.Drawing.Size(74, 40);
            this.Sorting.TabIndex = 6;
            this.Sorting.Text = "排序";
            this.Sorting.UseVisualStyleBackColor = false;
            this.Sorting.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Remove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remove.Location = new System.Drawing.Point(27, 317);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(74, 40);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "移除";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Lowest
            // 
            this.Lowest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lowest.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lowest.Location = new System.Drawing.Point(186, 317);
            this.Lowest.Name = "Lowest";
            this.Lowest.Size = new System.Drawing.Size(134, 40);
            this.Lowest.TabIndex = 4;
            this.Lowest.Text = "最低分者";
            this.Lowest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Highest
            // 
            this.Highest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Highest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Highest.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Highest.Location = new System.Drawing.Point(186, 8);
            this.Highest.Name = "Highest";
            this.Highest.Size = new System.Drawing.Size(134, 40);
            this.Highest.TabIndex = 3;
            this.Highest.Text = "最高分者";
            this.Highest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Counter
            // 
            this.Counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Counter.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Counter.Location = new System.Drawing.Point(27, 8);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(100, 40);
            this.Counter.TabIndex = 2;
            this.Counter.Text = "人數";
            this.Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(27, 369);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(293, 244);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(27, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.Eng);
            this.groupBox1.Controls.Add(this.SelAll);
            this.groupBox1.Controls.Add(this.STNum);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 639);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模擬產生姓名與成績";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(22, 105);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(337, 508);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Eng
            // 
            this.Eng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Eng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Eng.Location = new System.Drawing.Point(240, 43);
            this.Eng.Name = "Eng";
            this.Eng.Size = new System.Drawing.Size(119, 35);
            this.Eng.TabIndex = 2;
            this.Eng.Text = "英文>=60";
            this.Eng.UseVisualStyleBackColor = false;
            this.Eng.Click += new System.EventHandler(this.Eng_Click);
            // 
            // SelAll
            // 
            this.SelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SelAll.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelAll.Location = new System.Drawing.Point(141, 43);
            this.SelAll.Name = "SelAll";
            this.SelAll.Size = new System.Drawing.Size(83, 35);
            this.SelAll.TabIndex = 1;
            this.SelAll.Text = "全選";
            this.SelAll.UseVisualStyleBackColor = false;
            this.SelAll.Click += new System.EventHandler(this.SelAll_Click);
            // 
            // STNum
            // 
            this.STNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.STNum.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.STNum.Location = new System.Drawing.Point(22, 43);
            this.STNum.MaxLength = 2;
            this.STNum.Name = "STNum";
            this.STNum.Size = new System.Drawing.Size(100, 33);
            this.STNum.TabIndex = 0;
            this.STNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STNum.TextChanged += new System.EventHandler(this.STNum_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Eng;
        private System.Windows.Forms.Button SelAll;
        private System.Windows.Forms.TextBox STNum;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label Lowest;
        private System.Windows.Forms.Label Highest;
        private System.Windows.Forms.Button Sorting;
        private System.Windows.Forms.Button Remove;
    }
}


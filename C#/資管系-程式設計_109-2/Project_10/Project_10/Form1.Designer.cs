namespace Project_10
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TD2 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TD1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TB1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB1.Location = new System.Drawing.Point(36, 43);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(140, 29);
            this.TB1.TabIndex = 0;
            this.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB1.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Result.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Result.Location = new System.Drawing.Point(622, 43);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(151, 29);
            this.Result.TabIndex = 1;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Result.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(622, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(151, 29);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TD2
            // 
            this.TD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TD2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TD2.Location = new System.Drawing.Point(386, 122);
            this.TD2.Name = "TD2";
            this.TD2.ReadOnly = true;
            this.TD2.Size = new System.Drawing.Size(140, 29);
            this.TD2.TabIndex = 3;
            this.TD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TB2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB2.Location = new System.Drawing.Point(386, 43);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(140, 29);
            this.TB2.TabIndex = 4;
            this.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB2.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // TD1
            // 
            this.TD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TD1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TD1.Location = new System.Drawing.Point(36, 122);
            this.TD1.Name = "TD1";
            this.TD1.ReadOnly = true;
            this.TD1.Size = new System.Drawing.Size(140, 29);
            this.TD1.TabIndex = 5;
            this.TD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<< (Shift Left)",
            ">> (Shift Right)",
            "反轉",
            "& (And)",
            "| (Or)",
            "^ (Xor)",
            "Exchange"});
            this.comboBox1.Location = new System.Drawing.Point(212, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 209);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TD1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TD2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.TB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TD2;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TD1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


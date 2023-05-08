
namespace Exercise_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Display1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.third = new System.Windows.Forms.ComboBox();
            this.Area = new System.Windows.Forms.ComboBox();
            this.F = new System.Windows.Forms.RadioButton();
            this.M = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Display2 = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Display1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.InputID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[功能1]確認現有身份證號碼";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(336, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "開始認證";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Display1
            // 
            this.Display1.Location = new System.Drawing.Point(9, 134);
            this.Display1.Name = "Display1";
            this.Display1.ReadOnly = true;
            this.Display1.Size = new System.Drawing.Size(421, 27);
            this.Display1.TabIndex = 3;
            this.Display1.Text = "請先輸入身份證號碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份證號碼之分析結果";
            // 
            // InputID
            // 
            this.InputID.Location = new System.Drawing.Point(9, 62);
            this.InputID.MaxLength = 10;
            this.InputID.Name = "InputID";
            this.InputID.Size = new System.Drawing.Size(271, 27);
            this.InputID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入身份證號碼(連英文字母共10位)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.third);
            this.groupBox2.Controls.Add(this.Area);
            this.groupBox2.Controls.Add(this.F);
            this.groupBox2.Controls.Add(this.M);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Display2);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(32, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[功能2]產生一組新的身份證號碼";
            // 
            // third
            // 
            this.third.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.third.FormattingEnabled = true;
            this.third.Items.AddRange(new object[] {
            "其他",
            "取得國籍之外國人",
            "無戶籍國民",
            "港澳居民",
            "大陸地區人民"});
            this.third.Location = new System.Drawing.Point(9, 138);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(271, 24);
            this.third.TabIndex = 10;
            // 
            // Area
            // 
            this.Area.DropDownHeight = 99;
            this.Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Area.FormattingEnabled = true;
            this.Area.IntegralHeight = false;
            this.Area.Items.AddRange(new object[] {
            "臺北市(A)",
            "臺中市(B)",
            "基隆市(C)",
            "臺南市(D)",
            "高雄市(E)",
            "新北市(F)",
            "宜蘭縣(G)",
            "桃園縣(H)",
            "新竹縣(J)",
            "苗栗縣(K)",
            "臺中縣(L)",
            "南投縣M)",
            "彰化縣(N)",
            "雲林縣(P)",
            "嘉義縣(Q)",
            "臺南縣(R)",
            "高雄縣(S)",
            "屏東縣(T)",
            "花蓮縣(U)",
            "臺東縣(V)",
            "澎湖縣(X)",
            "陽明山(Y)",
            "金門縣(W)",
            "連江縣(Z)",
            "嘉義市(I)",
            "新竹市(O)"});
            this.Area.Location = new System.Drawing.Point(159, 90);
            this.Area.MaxDropDownItems = 3;
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(121, 24);
            this.Area.TabIndex = 9;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.ForeColor = System.Drawing.Color.Black;
            this.F.Location = new System.Drawing.Point(86, 90);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(58, 20);
            this.F.TabIndex = 8;
            this.F.TabStop = true;
            this.F.Text = "女性";
            this.F.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Checked = true;
            this.M.ForeColor = System.Drawing.Color.Black;
            this.M.Location = new System.Drawing.Point(9, 90);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(58, 20);
            this.M.TabIndex = 7;
            this.M.TabStop = true;
            this.M.Text = "男性";
            this.M.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(336, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "剪下";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(336, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "開始產生";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Display2
            // 
            this.Display2.Location = new System.Drawing.Point(9, 38);
            this.Display2.Name = "Display2";
            this.Display2.ReadOnly = true;
            this.Display2.Size = new System.Drawing.Size(271, 27);
            this.Display2.TabIndex = 2;
            this.Display2.Text = "請先選擇下方選項";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.close.Location = new System.Drawing.Point(529, 192);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(92, 42);
            this.close.TabIndex = 2;
            this.close.Text = "結束";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(647, 455);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Display1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.RadioButton M;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Display2;
        private System.Windows.Forms.ComboBox Area;
        private System.Windows.Forms.ComboBox third;
    }
}


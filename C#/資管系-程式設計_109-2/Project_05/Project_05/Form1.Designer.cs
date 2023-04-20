
namespace Project_05
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
            this.DisplayB = new System.Windows.Forms.TextBox();
            this.DisplayA = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayB
            // 
            this.DisplayB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DisplayB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DisplayB.Location = new System.Drawing.Point(303, 94);
            this.DisplayB.Multiline = true;
            this.DisplayB.Name = "DisplayB";
            this.DisplayB.ReadOnly = true;
            this.DisplayB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayB.Size = new System.Drawing.Size(233, 432);
            this.DisplayB.TabIndex = 5;
            // 
            // DisplayA
            // 
            this.DisplayA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DisplayA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DisplayA.Location = new System.Drawing.Point(23, 94);
            this.DisplayA.Multiline = true;
            this.DisplayA.Name = "DisplayA";
            this.DisplayA.ReadOnly = true;
            this.DisplayA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayA.Size = new System.Drawing.Size(233, 432);
            this.DisplayA.TabIndex = 4;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Create.Location = new System.Drawing.Point(178, 29);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(78, 39);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // nud
            // 
            this.nud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nud.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nud.Location = new System.Drawing.Point(23, 29);
            this.nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(128, 39);
            this.nud.TabIndex = 7;
            this.nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Queue",
            "Stack",
            "成績 (Descending)",
            "姓名 (Ascending)",
            "成績 (D) & 姓名 (A)",
            "身份證排序(to file)"});
            this.comboBox1.Location = new System.Drawing.Point(303, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 38);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "請選擇";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 559);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.DisplayB);
            this.Controls.Add(this.DisplayA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayB;
        private System.Windows.Forms.TextBox DisplayA;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}



namespace Exercise
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
            this.idDisplay = new System.Windows.Forms.CheckedListBox();
            this.DisplayR = new System.Windows.Forms.TextBox();
            this.DisplayL = new System.Windows.Forms.TextBox();
            this.CB2 = new System.Windows.Forms.ComboBox();
            this.BTS = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.idDisplay);
            this.groupBox1.Controls.Add(this.DisplayR);
            this.groupBox1.Controls.Add(this.DisplayL);
            this.groupBox1.Controls.Add(this.CB2);
            this.groupBox1.Controls.Add(this.BTS);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 740);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模擬產生身份證";
            // 
            // idDisplay
            // 
            this.idDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.idDisplay.FormattingEnabled = true;
            this.idDisplay.Location = new System.Drawing.Point(15, 81);
            this.idDisplay.Name = "idDisplay";
            this.idDisplay.Size = new System.Drawing.Size(753, 312);
            this.idDisplay.TabIndex = 6;
            // 
            // DisplayR
            // 
            this.DisplayR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DisplayR.Location = new System.Drawing.Point(413, 411);
            this.DisplayR.Multiline = true;
            this.DisplayR.Name = "DisplayR";
            this.DisplayR.ReadOnly = true;
            this.DisplayR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayR.Size = new System.Drawing.Size(355, 312);
            this.DisplayR.TabIndex = 5;
            // 
            // DisplayL
            // 
            this.DisplayL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DisplayL.Location = new System.Drawing.Point(15, 411);
            this.DisplayL.Multiline = true;
            this.DisplayL.Name = "DisplayL";
            this.DisplayL.ReadOnly = true;
            this.DisplayL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayL.Size = new System.Drawing.Size(366, 312);
            this.DisplayL.TabIndex = 4;
            // 
            // CB2
            // 
            this.CB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CB2.Font = new System.Drawing.Font("新細明體", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CB2.FormattingEnabled = true;
            this.CB2.Items.AddRange(new object[] {
            "新竹縣[J] | 新竹市[O]&(血型&未成年[年齡 < 18])"});
            this.CB2.Location = new System.Drawing.Point(234, 32);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(534, 33);
            this.CB2.TabIndex = 2;
            this.CB2.Text = "請選擇";
            this.CB2.SelectedIndexChanged += new System.EventHandler(this.CB2_SelectedIndexChanged);
            // 
            // BTS
            // 
            this.BTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTS.Font = new System.Drawing.Font("新細明體", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTS.ForeColor = System.Drawing.Color.Black;
            this.BTS.FormattingEnabled = true;
            this.BTS.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.BTS.Location = new System.Drawing.Point(120, 32);
            this.BTS.Name = "BTS";
            this.BTS.Size = new System.Drawing.Size(97, 33);
            this.BTS.TabIndex = 1;
            this.BTS.Text = "血型";
            this.BTS.SelectedIndexChanged += new System.EventHandler(this.BT_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.num.Location = new System.Drawing.Point(15, 32);
            this.num.MaxLength = 3;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(88, 33);
            this.num.TabIndex = 0;
            this.num.Text = "0";
            this.num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 764);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DisplayR;
        private System.Windows.Forms.TextBox DisplayL;
        private System.Windows.Forms.ComboBox CB2;
        private System.Windows.Forms.ComboBox BTS;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.CheckedListBox idDisplay;
    }
}


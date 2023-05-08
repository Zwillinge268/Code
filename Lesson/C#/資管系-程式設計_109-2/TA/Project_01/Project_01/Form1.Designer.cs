
namespace Project_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.TextBox();
            this.Ans1 = new System.Windows.Forms.Label();
            this.Ans2 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ans3 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(307, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大樂透號碼";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaxNum
            // 
            this.MaxNum.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaxNum.Location = new System.Drawing.Point(520, 26);
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(86, 40);
            this.MaxNum.TabIndex = 1;
            this.MaxNum.Text = "49";
            this.MaxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(707, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "延遲(ms)";
            // 
            // Delay
            // 
            this.Delay.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Delay.Location = new System.Drawing.Point(847, 26);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(79, 40);
            this.Delay.TabIndex = 3;
            this.Delay.Text = "100";
            this.Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "樂透1";
            // 
            // L1
            // 
            this.L1.Location = new System.Drawing.Point(102, 153);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(824, 22);
            this.L1.TabIndex = 5;
            // 
            // Ans1
            // 
            this.Ans1.AutoSize = true;
            this.Ans1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ans1.Location = new System.Drawing.Point(100, 190);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(0, 21);
            this.Ans1.TabIndex = 6;
            // 
            // Ans2
            // 
            this.Ans2.AutoSize = true;
            this.Ans2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ans2.Location = new System.Drawing.Point(100, 291);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(0, 21);
            this.Ans2.TabIndex = 9;
            // 
            // L2
            // 
            this.L2.Location = new System.Drawing.Point(102, 254);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(824, 22);
            this.L2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(32, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "樂透2";
            // 
            // Ans3
            // 
            this.Ans3.AutoSize = true;
            this.Ans3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ans3.Location = new System.Drawing.Point(100, 403);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(0, 21);
            this.Ans3.TabIndex = 12;
            // 
            // L3
            // 
            this.L3.Location = new System.Drawing.Point(102, 366);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(824, 22);
            this.L3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(32, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "樂透3";
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Go.Location = new System.Drawing.Point(439, 466);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(144, 90);
            this.Go.TabIndex = 13;
            this.Go.Text = "Go Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 583);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ans1);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Delay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L1;
        private System.Windows.Forms.Label Ans1;
        private System.Windows.Forms.Label Ans2;
        private System.Windows.Forms.TextBox L2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ans3;
        private System.Windows.Forms.TextBox L3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Go;
    }
}


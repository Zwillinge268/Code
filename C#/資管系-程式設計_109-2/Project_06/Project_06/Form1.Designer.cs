
namespace Project_06
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
            this.Verification = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Verification
            // 
            this.Verification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Verification.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Verification.Location = new System.Drawing.Point(37, 39);
            this.Verification.MaxLength = 10;
            this.Verification.Name = "Verification";
            this.Verification.Size = new System.Drawing.Size(141, 35);
            this.Verification.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Verification, "Double-Click for TWID verfirication");
            this.Verification.DoubleClick += new System.EventHandler(this.Verification_DoubleClick);
            // 
            // Number
            // 
            this.Number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Number.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number.Location = new System.Drawing.Point(37, 105);
            this.Number.MaxLength = 10;
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(141, 35);
            this.Number.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Number, "Double-Click for TWID creation");
            this.Number.DoubleClick += new System.EventHandler(this.Number_DoubleClick);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Display.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Display.Location = new System.Drawing.Point(37, 178);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Display.Size = new System.Drawing.Size(364, 378);
            this.Display.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 592);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Verification);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Verification;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Display;
    }
}


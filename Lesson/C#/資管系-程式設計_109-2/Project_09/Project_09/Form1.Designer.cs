namespace Project_09
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.動態產生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除TextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除所有方塊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictrueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxToolStripMenuItem,
            this.pictrueToolStripMenuItem,
            this.buttonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxToolStripMenuItem
            // 
            this.textBoxToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.動態產生ToolStripMenuItem,
            this.移除TextBoxToolStripMenuItem,
            this.移除所有方塊ToolStripMenuItem});
            this.textBoxToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToolStripMenuItem.Name = "textBoxToolStripMenuItem";
            this.textBoxToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.textBoxToolStripMenuItem.Text = "TextBox";
            // 
            // 動態產生ToolStripMenuItem
            // 
            this.動態產生ToolStripMenuItem.Name = "動態產生ToolStripMenuItem";
            this.動態產生ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.動態產生ToolStripMenuItem.Text = "動態產生";
            this.動態產生ToolStripMenuItem.Click += new System.EventHandler(this.動態產生ToolStripMenuItem_Click);
            // 
            // 移除TextBoxToolStripMenuItem
            // 
            this.移除TextBoxToolStripMenuItem.Name = "移除TextBoxToolStripMenuItem";
            this.移除TextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.移除TextBoxToolStripMenuItem.Text = "移除TextBox";
            this.移除TextBoxToolStripMenuItem.Click += new System.EventHandler(this.移除TextBoxToolStripMenuItem_Click);
            // 
            // 移除所有方塊ToolStripMenuItem
            // 
            this.移除所有方塊ToolStripMenuItem.Name = "移除所有方塊ToolStripMenuItem";
            this.移除所有方塊ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.移除所有方塊ToolStripMenuItem.Text = "移除所有方塊";
            this.移除所有方塊ToolStripMenuItem.Click += new System.EventHandler(this.移除所有方塊ToolStripMenuItem_Click);
            // 
            // pictrueToolStripMenuItem
            // 
            this.pictrueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictrueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem});
            this.pictrueToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictrueToolStripMenuItem.Name = "pictrueToolStripMenuItem";
            this.pictrueToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.pictrueToolStripMenuItem.Text = "PictureBox";
            // 
            // oNToolStripMenuItem
            // 
            this.oNToolStripMenuItem.Name = "oNToolStripMenuItem";
            this.oNToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.oNToolStripMenuItem.Text = "ON";
            this.oNToolStripMenuItem.Click += new System.EventHandler(this.oNToolStripMenuItem_Click);
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.buttonToolStripMenuItem.Text = "Button";
            this.buttonToolStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 653);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 動態產生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除TextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除所有方塊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictrueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
    }
}


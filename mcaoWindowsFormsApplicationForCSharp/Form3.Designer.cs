namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.简单图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.复杂图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.容器眼睛ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简单图片ToolStripMenuItem,
            this.复杂图形ToolStripMenuItem,
            this.容器眼睛ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 简单图片ToolStripMenuItem
            // 
            this.简单图片ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.放大缩小ToolStripMenuItem,
            this.定时显示ToolStripMenuItem});
            this.简单图片ToolStripMenuItem.Name = "简单图片ToolStripMenuItem";
            this.简单图片ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.简单图片ToolStripMenuItem.Text = "简单图片";
            // 
            // 放大缩小ToolStripMenuItem
            // 
            this.放大缩小ToolStripMenuItem.Name = "放大缩小ToolStripMenuItem";
            this.放大缩小ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.放大缩小ToolStripMenuItem.Text = "放大缩小";
            this.放大缩小ToolStripMenuItem.Click += new System.EventHandler(this.放大缩小ToolStripMenuItem_Click);
            // 
            // 定时显示ToolStripMenuItem
            // 
            this.定时显示ToolStripMenuItem.Name = "定时显示ToolStripMenuItem";
            this.定时显示ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.定时显示ToolStripMenuItem.Text = "定时显示";
            this.定时显示ToolStripMenuItem.Click += new System.EventHandler(this.定时显示ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 复杂图形ToolStripMenuItem
            // 
            this.复杂图形ToolStripMenuItem.Name = "复杂图形ToolStripMenuItem";
            this.复杂图形ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.复杂图形ToolStripMenuItem.Text = "复杂图形";
            this.复杂图形ToolStripMenuItem.Click += new System.EventHandler(this.复杂图形ToolStripMenuItem_Click);
            // 
            // 容器眼睛ToolStripMenuItem
            // 
            this.容器眼睛ToolStripMenuItem.Name = "容器眼睛ToolStripMenuItem";
            this.容器眼睛ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.容器眼睛ToolStripMenuItem.Text = "容器眼睛";
            this.容器眼睛ToolStripMenuItem.Click += new System.EventHandler(this.容器眼睛ToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 567);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private int i = 0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 简单图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定时显示ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 复杂图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 容器眼睛ToolStripMenuItem;
    }
}
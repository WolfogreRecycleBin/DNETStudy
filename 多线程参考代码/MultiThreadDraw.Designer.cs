namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class MultiThreadDraw
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.线程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线程1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线程2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.两个线程同时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.两个线程共享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一个线程join另一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线程同步ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.线程ToolStripMenuItem,
            this.线程同步ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 线程ToolStripMenuItem
            // 
            this.线程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.线程1ToolStripMenuItem,
            this.线程2ToolStripMenuItem,
            this.两个线程同时ToolStripMenuItem,
            this.两个线程共享ToolStripMenuItem,
            this.一个线程join另一个ToolStripMenuItem});
            this.线程ToolStripMenuItem.Name = "线程ToolStripMenuItem";
            this.线程ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.线程ToolStripMenuItem.Text = "线程启动";
            // 
            // 线程1ToolStripMenuItem
            // 
            this.线程1ToolStripMenuItem.Name = "线程1ToolStripMenuItem";
            this.线程1ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.线程1ToolStripMenuItem.Text = "启动线程1";
            this.线程1ToolStripMenuItem.Click += new System.EventHandler(this.线程1ToolStripMenuItem_Click);
            // 
            // 线程2ToolStripMenuItem
            // 
            this.线程2ToolStripMenuItem.Name = "线程2ToolStripMenuItem";
            this.线程2ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.线程2ToolStripMenuItem.Text = "启动线程2";
            this.线程2ToolStripMenuItem.Click += new System.EventHandler(this.线程2ToolStripMenuItem_Click);
            // 
            // 两个线程同时ToolStripMenuItem
            // 
            this.两个线程同时ToolStripMenuItem.Name = "两个线程同时ToolStripMenuItem";
            this.两个线程同时ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.两个线程同时ToolStripMenuItem.Text = "两个线程同时启动";
            this.两个线程同时ToolStripMenuItem.Click += new System.EventHandler(this.两个线程同时ToolStripMenuItem_Click);
            // 
            // 两个线程共享ToolStripMenuItem
            // 
            this.两个线程共享ToolStripMenuItem.Name = "两个线程共享ToolStripMenuItem";
            this.两个线程共享ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.两个线程共享ToolStripMenuItem.Text = "两个线程共享";
            this.两个线程共享ToolStripMenuItem.Click += new System.EventHandler(this.两个线程共享ToolStripMenuItem_Click);
            // 
            // 一个线程join另一个ToolStripMenuItem
            // 
            this.一个线程join另一个ToolStripMenuItem.Name = "一个线程join另一个ToolStripMenuItem";
            this.一个线程join另一个ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.一个线程join另一个ToolStripMenuItem.Text = "一个线程join另一个";
            this.一个线程join另一个ToolStripMenuItem.Click += new System.EventHandler(this.一个线程join另一个ToolStripMenuItem_Click);
            // 
            // 线程同步ToolStripMenuItem
            // 
            this.线程同步ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorToolStripMenuItem});
            this.线程同步ToolStripMenuItem.Name = "线程同步ToolStripMenuItem";
            this.线程同步ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.线程同步ToolStripMenuItem.Text = "线程同步";
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monitorToolStripMenuItem.Text = "Monitor";
            //this.monitorToolStripMenuItem.Click += new System.EventHandler(this.monitorToolStripMenuItem_Click);
            // 
            // MultiThreadDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 512);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MultiThreadDraw";
            this.Text = "MultiThreadDraw";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private int timevaryshare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 线程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线程1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线程2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 两个线程同时ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 两个线程共享ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一个线程join另一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线程同步ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
    }
}
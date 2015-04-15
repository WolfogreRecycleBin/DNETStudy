namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class SlipControlForm
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SlipControlForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.vSplitter = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.hSplitter = new System.Windows.Forms.Splitter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fileIconList = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageList = this.fileIconList;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("我的电脑")});
            this.treeView1.Size = new System.Drawing.Size(112, 285);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // vSplitter
            // 
            this.vSplitter.Location = new System.Drawing.Point(112, 0);
            this.vSplitter.Name = "vSplitter";
            this.vSplitter.Size = new System.Drawing.Size(3, 285);
            this.vSplitter.TabIndex = 1;
            this.vSplitter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(115, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 48);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hSplitter
            // 
            this.hSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hSplitter.Location = new System.Drawing.Point(115, 234);
            this.hSplitter.Name = "hSplitter";
            this.hSplitter.Size = new System.Drawing.Size(301, 3);
            this.hSplitter.TabIndex = 3;
            this.hSplitter.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageListLarge;
            this.listView1.Location = new System.Drawing.Point(115, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 234);
            this.listView1.TabIndex = 4;
            // 
            // fileIconList
            // 
            this.fileIconList.ImageSize = new System.Drawing.Size(16, 16);
            this.fileIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIconList.ImageStream")));
            this.fileIconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ControlsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(416, 285);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.hSplitter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vSplitter);
            this.Controls.Add(this.treeView1);
            this.HelpButton = true;
            this.Text = "测试分割控件并浏览C盘和所有硬盘上的文件/文件夹";
            this.Load += new System.EventHandler(this.ControlsForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Splitter vSplitter;
        private System.Windows.Forms.Splitter hSplitter;
        private System.Windows.Forms.ImageList fileIconList;
        private System.Windows.Forms.ImageList imageListLarge;

    }
}
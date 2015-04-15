using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.事件演示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.异常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一般异常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.异常嵌套ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义异常及其他语法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.装箱测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入输出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定时图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.猜猜我在哪儿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控件属性设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控件事件处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对话框使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件对话框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览文件对话框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.各种控件演示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控件使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分割窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户自定义控件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有模对话框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无模对话框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.辅导员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教学秘书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班导师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本课程教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多线程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单线程演示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线程画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线程应答ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialog3 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog4 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.事件演示ToolStripMenuItem,
            this.异常ToolStripMenuItem,
            this.输入输出ToolStripMenuItem,
            this.有模对话框ToolStripMenuItem,
            this.无模对话框ToolStripMenuItem,
            this.多线程ToolStripMenuItem,
            this.数据库ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 事件演示ToolStripMenuItem
            // 
            this.事件演示ToolStripMenuItem.Name = "事件演示ToolStripMenuItem";
            this.事件演示ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.事件演示ToolStripMenuItem.Text = "事件演示";
            this.事件演示ToolStripMenuItem.Click += new System.EventHandler(this.事件演示ToolStripMenuItem_Click);
            // 
            // 异常ToolStripMenuItem
            // 
            this.异常ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一般异常ToolStripMenuItem,
            this.异常嵌套ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.自定义异常及其他语法ToolStripMenuItem,
            this.装箱测试ToolStripMenuItem});
            this.异常ToolStripMenuItem.Name = "异常ToolStripMenuItem";
            this.异常ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.异常ToolStripMenuItem.Text = "异常断言等语法";
            // 
            // 一般异常ToolStripMenuItem
            // 
            this.一般异常ToolStripMenuItem.Name = "一般异常ToolStripMenuItem";
            this.一般异常ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.一般异常ToolStripMenuItem.Text = "一般异常";
            this.一般异常ToolStripMenuItem.Click += new System.EventHandler(this.一般异常ToolStripMenuItem_Click);
            // 
            // 异常嵌套ToolStripMenuItem
            // 
            this.异常嵌套ToolStripMenuItem.Name = "异常嵌套ToolStripMenuItem";
            this.异常嵌套ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.异常嵌套ToolStripMenuItem.Text = "异常嵌套";
            this.异常嵌套ToolStripMenuItem.Click += new System.EventHandler(this.异常嵌套ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem1.Text = "断言";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 自定义异常及其他语法ToolStripMenuItem
            // 
            this.自定义异常及其他语法ToolStripMenuItem.Name = "自定义异常及其他语法ToolStripMenuItem";
            this.自定义异常及其他语法ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.自定义异常及其他语法ToolStripMenuItem.Text = "自定义异常及其他语法";
            this.自定义异常及其他语法ToolStripMenuItem.Click += new System.EventHandler(this.自定义异常及其他语法ToolStripMenuItem_Click);
            // 
            // 装箱测试ToolStripMenuItem
            // 
            this.装箱测试ToolStripMenuItem.Name = "装箱测试ToolStripMenuItem";
            this.装箱测试ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.装箱测试ToolStripMenuItem.Text = "装箱测试";
            this.装箱测试ToolStripMenuItem.Click += new System.EventHandler(this.装箱测试ToolStripMenuItem_Click);
            // 
            // 输入输出ToolStripMenuItem
            // 
            this.输入输出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.定时图片ToolStripMenuItem,
            this.猜猜我在哪儿ToolStripMenuItem,
            this.控件属性设置ToolStripMenuItem,
            this.控件事件处理ToolStripMenuItem,
            this.对话框使用ToolStripMenuItem,
            this.各种控件演示ToolStripMenuItem,
            this.控件使用ToolStripMenuItem,
            this.打印ToolStripMenuItem});
            this.输入输出ToolStripMenuItem.Name = "输入输出ToolStripMenuItem";
            this.输入输出ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.输入输出ToolStripMenuItem.Text = "输入输出";
            // 
            // 定时图片ToolStripMenuItem
            // 
            this.定时图片ToolStripMenuItem.Name = "定时图片ToolStripMenuItem";
            this.定时图片ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.定时图片ToolStripMenuItem.Text = "图形图像";
            this.定时图片ToolStripMenuItem.Click += new System.EventHandler(this.定时图片ToolStripMenuItem_Click);
            // 
            // 猜猜我在哪儿ToolStripMenuItem
            // 
            this.猜猜我在哪儿ToolStripMenuItem.Name = "猜猜我在哪儿ToolStripMenuItem";
            this.猜猜我在哪儿ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.猜猜我在哪儿ToolStripMenuItem.Text = "猜猜我在哪儿";
            this.猜猜我在哪儿ToolStripMenuItem.Click += new System.EventHandler(this.猜猜我在哪儿ToolStripMenuItem_Click);
            // 
            // 控件属性设置ToolStripMenuItem
            // 
            this.控件属性设置ToolStripMenuItem.Name = "控件属性设置ToolStripMenuItem";
            this.控件属性设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.控件属性设置ToolStripMenuItem.Text = "控件属性设置";
            this.控件属性设置ToolStripMenuItem.Click += new System.EventHandler(this.控件属性设置ToolStripMenuItem_Click);
            // 
            // 控件事件处理ToolStripMenuItem
            // 
            this.控件事件处理ToolStripMenuItem.Name = "控件事件处理ToolStripMenuItem";
            this.控件事件处理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.控件事件处理ToolStripMenuItem.Text = "控件事件处理";
            this.控件事件处理ToolStripMenuItem.Click += new System.EventHandler(this.控件事件处理ToolStripMenuItem_Click);
            // 
            // 对话框使用ToolStripMenuItem
            // 
            this.对话框使用ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件对话框ToolStripMenuItem,
            this.浏览文件对话框ToolStripMenuItem});
            this.对话框使用ToolStripMenuItem.Name = "对话框使用ToolStripMenuItem";
            this.对话框使用ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.对话框使用ToolStripMenuItem.Text = "对话框使用";
            // 
            // 打开文件对话框ToolStripMenuItem
            // 
            this.打开文件对话框ToolStripMenuItem.Name = "打开文件对话框ToolStripMenuItem";
            this.打开文件对话框ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开文件对话框ToolStripMenuItem.Text = "打开文件对话框";
            this.打开文件对话框ToolStripMenuItem.Click += new System.EventHandler(this.打开文件对话框ToolStripMenuItem_Click);
            // 
            // 浏览文件对话框ToolStripMenuItem
            // 
            this.浏览文件对话框ToolStripMenuItem.Name = "浏览文件对话框ToolStripMenuItem";
            this.浏览文件对话框ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.浏览文件对话框ToolStripMenuItem.Text = "浏览文件对话框";
            this.浏览文件对话框ToolStripMenuItem.Click += new System.EventHandler(this.浏览文件对话框ToolStripMenuItem_Click);
            // 
            // 各种控件演示ToolStripMenuItem
            // 
            this.各种控件演示ToolStripMenuItem.Name = "各种控件演示ToolStripMenuItem";
            this.各种控件演示ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.各种控件演示ToolStripMenuItem.Text = "各种控件演示";
            this.各种控件演示ToolStripMenuItem.Click += new System.EventHandler(this.各种控件演示ToolStripMenuItem_Click);
            // 
            // 控件使用ToolStripMenuItem
            // 
            this.控件使用ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分割窗口ToolStripMenuItem,
            this.用户自定义控件ToolStripMenuItem});
            this.控件使用ToolStripMenuItem.Name = "控件使用ToolStripMenuItem";
            this.控件使用ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.控件使用ToolStripMenuItem.Text = "控件使用";
            // 
            // 分割窗口ToolStripMenuItem
            // 
            this.分割窗口ToolStripMenuItem.Name = "分割窗口ToolStripMenuItem";
            this.分割窗口ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.分割窗口ToolStripMenuItem.Text = "分割窗口";
            this.分割窗口ToolStripMenuItem.Click += new System.EventHandler(this.分割窗口ToolStripMenuItem_Click);
            // 
            // 用户自定义控件ToolStripMenuItem
            // 
            this.用户自定义控件ToolStripMenuItem.Name = "用户自定义控件ToolStripMenuItem";
            this.用户自定义控件ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.用户自定义控件ToolStripMenuItem.Text = "用户自定义控件";
            this.用户自定义控件ToolStripMenuItem.Click += new System.EventHandler(this.用户自定义控件ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打印文件ToolStripMenuItem,
            this.打印窗体ToolStripMenuItem});
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // 打印文件ToolStripMenuItem
            // 
            this.打印文件ToolStripMenuItem.Name = "打印文件ToolStripMenuItem";
            this.打印文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打印文件ToolStripMenuItem.Text = "打印文件";
            this.打印文件ToolStripMenuItem.Click += new System.EventHandler(this.打印文件ToolStripMenuItem_Click);
            // 
            // 打印窗体ToolStripMenuItem
            // 
            this.打印窗体ToolStripMenuItem.Name = "打印窗体ToolStripMenuItem";
            this.打印窗体ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打印窗体ToolStripMenuItem.Text = "打印窗体";
            this.打印窗体ToolStripMenuItem.Click += new System.EventHandler(this.打印窗体ToolStripMenuItem_Click);
            // 
            // 有模对话框ToolStripMenuItem
            // 
            this.有模对话框ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师ToolStripMenuItem1,
            this.学生ToolStripMenuItem});
            this.有模对话框ToolStripMenuItem.Name = "有模对话框ToolStripMenuItem";
            this.有模对话框ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.有模对话框ToolStripMenuItem.Text = "有模对话框";
            // 
            // 教师ToolStripMenuItem1
            // 
            this.教师ToolStripMenuItem1.Name = "教师ToolStripMenuItem1";
            this.教师ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.教师ToolStripMenuItem1.Text = "教师";
            this.教师ToolStripMenuItem1.Click += new System.EventHandler(this.教师ToolStripMenuItem1_Click);
            // 
            // 学生ToolStripMenuItem
            // 
            this.学生ToolStripMenuItem.Name = "学生ToolStripMenuItem";
            this.学生ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.学生ToolStripMenuItem.Text = "本课程教师";
            this.学生ToolStripMenuItem.Click += new System.EventHandler(this.学生ToolStripMenuItem_Click);
            // 
            // 无模对话框ToolStripMenuItem
            // 
            this.无模对话框ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师ToolStripMenuItem,
            this.辅导员ToolStripMenuItem,
            this.教学秘书ToolStripMenuItem,
            this.班导师ToolStripMenuItem,
            this.本课程教师ToolStripMenuItem});
            this.无模对话框ToolStripMenuItem.Name = "无模对话框ToolStripMenuItem";
            this.无模对话框ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.无模对话框ToolStripMenuItem.Text = "无模对话框";
            this.无模对话框ToolStripMenuItem.Click += new System.EventHandler(this.无模对话框ToolStripMenuItem_Click);
            // 
            // 教师ToolStripMenuItem
            // 
            this.教师ToolStripMenuItem.Name = "教师ToolStripMenuItem";
            this.教师ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.教师ToolStripMenuItem.Text = "教师";
            this.教师ToolStripMenuItem.Click += new System.EventHandler(this.教师ToolStripMenuItem_Click);
            // 
            // 辅导员ToolStripMenuItem
            // 
            this.辅导员ToolStripMenuItem.Name = "辅导员ToolStripMenuItem";
            this.辅导员ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.辅导员ToolStripMenuItem.Text = "辅导员";
            this.辅导员ToolStripMenuItem.Click += new System.EventHandler(this.辅导员ToolStripMenuItem_Click);
            // 
            // 教学秘书ToolStripMenuItem
            // 
            this.教学秘书ToolStripMenuItem.Name = "教学秘书ToolStripMenuItem";
            this.教学秘书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.教学秘书ToolStripMenuItem.Text = "教学秘书";
            this.教学秘书ToolStripMenuItem.Click += new System.EventHandler(this.教学秘书ToolStripMenuItem_Click);
            // 
            // 班导师ToolStripMenuItem
            // 
            this.班导师ToolStripMenuItem.Name = "班导师ToolStripMenuItem";
            this.班导师ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班导师ToolStripMenuItem.Text = "班导师";
            this.班导师ToolStripMenuItem.Click += new System.EventHandler(this.班导师ToolStripMenuItem_Click);
            // 
            // 本课程教师ToolStripMenuItem
            // 
            this.本课程教师ToolStripMenuItem.Name = "本课程教师ToolStripMenuItem";
            this.本课程教师ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.本课程教师ToolStripMenuItem.Text = "本课程教师";
            this.本课程教师ToolStripMenuItem.Click += new System.EventHandler(this.本课程教师ToolStripMenuItem_Click);
            // 
            // 多线程ToolStripMenuItem
            // 
            this.多线程ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简单线程演示ToolStripMenuItem,
            this.线程画图ToolStripMenuItem,
            this.线程应答ToolStripMenuItem});
            this.多线程ToolStripMenuItem.Name = "多线程ToolStripMenuItem";
            this.多线程ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.多线程ToolStripMenuItem.Text = "多线程";
            // 
            // 简单线程演示ToolStripMenuItem
            // 
            this.简单线程演示ToolStripMenuItem.Name = "简单线程演示ToolStripMenuItem";
            this.简单线程演示ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.简单线程演示ToolStripMenuItem.Text = "简单线程演示";
            // 
            // 线程画图ToolStripMenuItem
            // 
            this.线程画图ToolStripMenuItem.Name = "线程画图ToolStripMenuItem";
            this.线程画图ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.线程画图ToolStripMenuItem.Text = "线程画图";
            this.线程画图ToolStripMenuItem.Click += new System.EventHandler(this.线程画图ToolStripMenuItem_Click);
            // 
            // 线程应答ToolStripMenuItem
            // 
            this.线程应答ToolStripMenuItem.Name = "线程应答ToolStripMenuItem";
            this.线程应答ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.线程应答ToolStripMenuItem.Text = "线程应答";
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.数据库ToolStripMenuItem.Text = "数据库";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printPreviewDialog3
            // 
            this.printPreviewDialog3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog3.Document = this.printDocument1;
            this.printPreviewDialog3.Enabled = true;
            this.printPreviewDialog3.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog3.Icon")));
            this.printPreviewDialog3.Name = "printPreviewDialog3";
            this.printPreviewDialog3.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog4
            // 
            this.printPreviewDialog4.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog4.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog4.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog4.Document = this.printDocument2;
            this.printPreviewDialog4.Enabled = true;
            this.printPreviewDialog4.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog4.Icon")));
            this.printPreviewDialog4.Name = "printPreviewDialog4";
            this.printPreviewDialog4.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 448);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 事件演示ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        int timecounter;
        string s1, s2;        
        private System.Windows.Forms.ToolStripMenuItem 异常ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一般异常ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 异常嵌套ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无模对话框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅导员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教学秘书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班导师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有模对话框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本课程教师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入输出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 定时图片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 猜猜我在哪儿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 自定义异常及其他语法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 装箱测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多线程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简单线程演示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线程画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线程应答ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控件属性设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控件事件处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对话框使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件对话框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览文件对话框ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.ToolStripMenuItem 各种控件演示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控件使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分割窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户自定义控件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印文件ToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog3;
        System.IO.StreamReader fileToPrint;
        System.Drawing.Font printFont;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem 打印窗体ToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog4;
        private System.Drawing.Printing.PrintDocument printDocument2;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
    }
}


namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class ControlEventDealtForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUnEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.textBoxMultipleLine = new System.Windows.Forms.TextBox();
            this.textBoxSingleLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "单行编辑：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxUnEdit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPassWord);
            this.groupBox1.Controls.Add(this.textBoxMultipleLine);
            this.groupBox1.Controls.Add(this.textBoxSingleLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一般编辑文本的使用方式";
            // 
            // textBoxUnEdit
            // 
            this.textBoxUnEdit.Location = new System.Drawing.Point(88, 72);
            this.textBoxUnEdit.Name = "textBoxUnEdit";
            this.textBoxUnEdit.ReadOnly = true;
            this.textBoxUnEdit.Size = new System.Drawing.Size(264, 21);
            this.textBoxUnEdit.TabIndex = 5;
            this.textBoxUnEdit.Text = "嘿嘿,眼睁睁看着编辑框,就是不让您输入!";
            this.textBoxUnEdit.VisibleChanged += new System.EventHandler(this.textBoxUnEdit_VisibleChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "不能编辑：";
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(88, 256);
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '#';
            this.textBoxPassWord.Size = new System.Drawing.Size(128, 21);
            this.textBoxPassWord.TabIndex = 3;
            this.textBoxPassWord.Text = "textBoxSingle";
            this.textBoxPassWord.TextChanged += new System.EventHandler(this.textBoxPassWord_TextChanged);
            this.textBoxPassWord.MouseLeave += new System.EventHandler(this.textBoxPassWord_MouseLeave);
            // 
            // textBoxMultipleLine
            // 
            this.textBoxMultipleLine.AcceptsReturn = true;
            this.textBoxMultipleLine.Location = new System.Drawing.Point(88, 128);
            this.textBoxMultipleLine.Multiline = true;
            this.textBoxMultipleLine.Name = "textBoxMultipleLine";
            this.textBoxMultipleLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMultipleLine.Size = new System.Drawing.Size(264, 120);
            this.textBoxMultipleLine.TabIndex = 2;
            this.textBoxMultipleLine.Text = "textBoxMultiple";
            // 
            // textBoxSingleLine
            // 
            this.textBoxSingleLine.Location = new System.Drawing.Point(88, 32);
            this.textBoxSingleLine.Name = "textBoxSingleLine";
            this.textBoxSingleLine.Size = new System.Drawing.Size(264, 21);
            this.textBoxSingleLine.TabIndex = 1;
            this.textBoxSingleLine.Text = "不让您换行,不信您试试!我还就是不信，不过，好像是看不全了！";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "多行编辑：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码编辑：";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(408, 338);
            this.Controls.Add(this.groupBox1);           
            this.Text = "控件事件处理";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSingleLine;
        private System.Windows.Forms.TextBox textBoxMultipleLine;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.TextBox textBoxUnEdit;
        private System.Windows.Forms.Label label4;
    }
}
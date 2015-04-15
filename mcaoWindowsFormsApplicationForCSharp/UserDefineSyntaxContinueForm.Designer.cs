namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class UserDefineSyntaxContinueForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonFunc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIntAlloc = new System.Windows.Forms.TextBox();
            this.textBoxAllocResult = new System.Windows.Forms.TextBox();
            this.buttonIntAlloc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStringInput = new System.Windows.Forms.TextBox();
            this.textBoxStringResult = new System.Windows.Forms.TextBox();
            this.buttonStringPointResult = new System.Windows.Forms.Button();
            this.buttonPointVisit = new System.Windows.Forms.Button();
            this.buttonPointExchange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Controls.Add(this.buttonFunc);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试指针作为out和ref类型的形参";
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(8, 48);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(96, 21);
            this.textBoxInt.TabIndex = 1;
            this.textBoxInt.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入一个整数：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(136, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "定义两个指针，一个指向输入的正数的地址，做ref形参，一个不指向该地址，做out形参，结果如下：";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(136, 72);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(216, 21);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.Text = "";
            // 
            // buttonFunc
            // 
            this.buttonFunc.Location = new System.Drawing.Point(8, 72);
            this.buttonFunc.Name = "buttonFunc";
            this.buttonFunc.Size = new System.Drawing.Size(96, 24);
            this.buttonFunc.TabIndex = 1;
            this.buttonFunc.Text = "传递结果";
            this.buttonFunc.Click += new System.EventHandler(this.buttonFunc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxIntAlloc);
            this.groupBox2.Controls.Add(this.textBoxAllocResult);
            this.groupBox2.Controls.Add(this.buttonIntAlloc);
            this.groupBox2.Location = new System.Drawing.Point(8, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "堆栈申请测试";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入一个整数：";
            // 
            // textBoxIntAlloc
            // 
            this.textBoxIntAlloc.Location = new System.Drawing.Point(8, 40);
            this.textBoxIntAlloc.Name = "textBoxIntAlloc";
            this.textBoxIntAlloc.Size = new System.Drawing.Size(104, 21);
            this.textBoxIntAlloc.TabIndex = 1;
            this.textBoxIntAlloc.Text = "";
            // 
            // textBoxAllocResult
            // 
            this.textBoxAllocResult.Location = new System.Drawing.Point(8, 96);
            this.textBoxAllocResult.Multiline = true;
            this.textBoxAllocResult.Name = "textBoxAllocResult";
            this.textBoxAllocResult.ReadOnly = true;
            this.textBoxAllocResult.Size = new System.Drawing.Size(104, 40);
            this.textBoxAllocResult.TabIndex = 1;
            this.textBoxAllocResult.Text = "";
            // 
            // buttonIntAlloc
            // 
            this.buttonIntAlloc.Location = new System.Drawing.Point(8, 66);
            this.buttonIntAlloc.Name = "buttonIntAlloc";
            this.buttonIntAlloc.Size = new System.Drawing.Size(104, 24);
            this.buttonIntAlloc.TabIndex = 1;
            this.buttonIntAlloc.Text = "申请结果";
            this.buttonIntAlloc.Click += new System.EventHandler(this.buttonIntAlloc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxStringInput);
            this.groupBox3.Controls.Add(this.textBoxStringResult);
            this.groupBox3.Controls.Add(this.buttonStringPointResult);
            this.groupBox3.Controls.Add(this.buttonPointVisit);
            this.groupBox3.Controls.Add(this.buttonPointExchange);
            this.groupBox3.Location = new System.Drawing.Point(152, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 144);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "指针和fixed语句测试";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "请输入字符串：";
            // 
            // textBoxStringInput
            // 
            this.textBoxStringInput.Location = new System.Drawing.Point(8, 40);
            this.textBoxStringInput.Name = "textBoxStringInput";
            this.textBoxStringInput.Size = new System.Drawing.Size(58, 21);
            this.textBoxStringInput.TabIndex = 1;
            this.textBoxStringInput.Text = "";
            // 
            // textBoxStringResult
            // 
            this.textBoxStringResult.Location = new System.Drawing.Point(117, 15);
            this.textBoxStringResult.Multiline = true;
            this.textBoxStringResult.Name = "textBoxStringResult";
            this.textBoxStringResult.ReadOnly = true;
            this.textBoxStringResult.Size = new System.Drawing.Size(102, 121);
            this.textBoxStringResult.TabIndex = 1;
            this.textBoxStringResult.Text = "";
            // 
            // buttonStringPointResult
            // 
            this.buttonStringPointResult.Location = new System.Drawing.Point(72, 41);
            this.buttonStringPointResult.Name = "buttonStringPointResult";
            this.buttonStringPointResult.Size = new System.Drawing.Size(39, 24);
            this.buttonStringPointResult.TabIndex = 1;
            this.buttonStringPointResult.Text = "结果";
            this.buttonStringPointResult.Click += new System.EventHandler(this.buttonStringPointResult_Click);
            // 
            // buttonPointVisit
            // 
            this.buttonPointVisit.Location = new System.Drawing.Point(5, 70);
            this.buttonPointVisit.Name = "buttonPointVisit";
            this.buttonPointVisit.Size = new System.Drawing.Size(105, 24);
            this.buttonPointVisit.TabIndex = 1;
            this.buttonPointVisit.Text = "指针访问结果";
            this.buttonPointVisit.Click += new System.EventHandler(this.buttonPointVisit_Click);
            // 
            // buttonPointExchange
            // 
            this.buttonPointExchange.Location = new System.Drawing.Point(5, 104);
            this.buttonPointExchange.Name = "buttonPointExchange";
            this.buttonPointExchange.Size = new System.Drawing.Size(105, 24);
            this.buttonPointExchange.TabIndex = 1;
            this.buttonPointExchange.Text = "指针转换结果";
            this.buttonPointExchange.Click += new System.EventHandler(this.buttonPointExchange_Click);
            // 
            // Form
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(384, 277);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Text = "不安全代码的测试";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);           
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonFunc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIntAlloc;
        private System.Windows.Forms.TextBox textBoxAllocResult;
        private System.Windows.Forms.Button buttonIntAlloc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStringInput;
        private System.Windows.Forms.TextBox textBoxStringResult;
        private System.Windows.Forms.Button buttonStringPointResult;
        private System.Windows.Forms.Button buttonPointVisit;
        private System.Windows.Forms.Button buttonPointExchange;
    }
}
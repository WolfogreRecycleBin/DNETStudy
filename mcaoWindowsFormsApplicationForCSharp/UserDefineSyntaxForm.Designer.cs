namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class UserDefineSyntaxForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.buttonGenenal = new System.Windows.Forms.Button();
            this.buttonException = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonUnsafeTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonThrowmcao = new System.Windows.Forms.Button();
            this.textBoxInputmcao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExceptionResult = new System.Windows.Forms.Button();
            this.buttonUserdefinedException1 = new System.Windows.Forms.Button();
            this.textBoxUserDefinedExceptionResult = new System.Windows.Forms.TextBox();
            this.buttonUserdefinedException2 = new System.Windows.Forms.Button();
            this.buttonUserdefinedException3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxInt1 = new System.Windows.Forms.TextBox();
            this.textBoxInt2 = new System.Windows.Forms.TextBox();
            this.textBoxCheckResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChecked = new System.Windows.Forms.Button();
            this.buttonUnchecked = new System.Windows.Forms.Button();
            this.buttonUndefine = new System.Windows.Forms.Button();
            this.buttonAssert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入除数：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入两个整数：";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(104, 24);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(88, 21);
            this.textBoxNumber.TabIndex = 1;
            this.textBoxNumber.Text = "";
            // 
            // textBoxDivision
            // 
            this.textBoxDivision.Location = new System.Drawing.Point(104, 56);
            this.textBoxDivision.Name = "textBoxDivision";
            this.textBoxDivision.Size = new System.Drawing.Size(88, 21);
            this.textBoxDivision.TabIndex = 1;
            this.textBoxDivision.Text = "";
            // 
            // buttonGenenal
            // 
            this.buttonGenenal.Location = new System.Drawing.Point(200, 24);
            this.buttonGenenal.Name = "buttonGenenal";
            this.buttonGenenal.Size = new System.Drawing.Size(112, 24);
            this.buttonGenenal.TabIndex = 2;
            this.buttonGenenal.Text = "无异常处理的结果";
            this.buttonGenenal.Click += new System.EventHandler(this.buttonGenenal_Click);
            // 
            // buttonException
            // 
            this.buttonException.Location = new System.Drawing.Point(200, 56);
            this.buttonException.Name = "buttonException";
            this.buttonException.Size = new System.Drawing.Size(112, 24);
            this.buttonException.TabIndex = 2;
            this.buttonException.Text = "有异常处理的结果";
            this.buttonException.Click += new System.EventHandler(this.buttonException_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenenal);
            this.groupBox1.Controls.Add(this.textBoxNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDivision);
            this.groupBox1.Controls.Add(this.buttonException);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "整数型除法中除数为零和非整数之异常处理";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "结果：";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(104, 88);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(88, 21);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.Text = "";
            // 
            // buttonUnsafeTest
            // 
            this.buttonUnsafeTest.Location = new System.Drawing.Point(360, 336);
            this.buttonUnsafeTest.Name = "buttonUnsafeTest";
            this.buttonUnsafeTest.Size = new System.Drawing.Size(104, 32);
            this.buttonUnsafeTest.TabIndex = 4;
            this.buttonUnsafeTest.Text = "不安全代码测试";
            this.buttonUnsafeTest.Click += new System.EventHandler(this.buttonUnsafeTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonThrowmcao);
            this.groupBox2.Controls.Add(this.textBoxInputmcao);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonExceptionResult);
            this.groupBox2.Controls.Add(this.buttonUserdefinedException1);
            this.groupBox2.Controls.Add(this.textBoxUserDefinedExceptionResult);
            this.groupBox2.Controls.Add(this.buttonUserdefinedException2);
            this.groupBox2.Controls.Add(this.buttonUserdefinedException3);
            this.groupBox2.Location = new System.Drawing.Point(8, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 224);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "抛出异常/异常层次处理/异常链接";
            // 
            // buttonThrowmcao
            // 
            this.buttonThrowmcao.Location = new System.Drawing.Point(200, 12);
            this.buttonThrowmcao.Name = "buttonThrowmcao";
            this.buttonThrowmcao.Size = new System.Drawing.Size(112, 24);
            this.buttonThrowmcao.TabIndex = 2;
            this.buttonThrowmcao.Text = "输入mcao试试";
            this.buttonThrowmcao.Click += new System.EventHandler(this.buttonThrowmcao_Click);
            // 
            // textBoxInputmcao
            // 
            this.textBoxInputmcao.Location = new System.Drawing.Point(104, 24);
            this.textBoxInputmcao.Name = "textBoxInputmcao";
            this.textBoxInputmcao.Size = new System.Drawing.Size(88, 21);
            this.textBoxInputmcao.TabIndex = 1;
            this.textBoxInputmcao.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "请输入字符串：";
            // 
            // buttonExceptionResult
            // 
            this.buttonExceptionResult.Location = new System.Drawing.Point(200, 40);
            this.buttonExceptionResult.Name = "buttonExceptionResult";
            this.buttonExceptionResult.Size = new System.Drawing.Size(112, 24);
            this.buttonExceptionResult.TabIndex = 2;
            this.buttonExceptionResult.Text = "输入mcao嵌套显示";
            this.buttonExceptionResult.Click += new System.EventHandler(this.buttonExceptionResult_Click);
            // 
            // buttonUserdefinedException1
            // 
            this.buttonUserdefinedException1.Location = new System.Drawing.Point(8, 56);
            this.buttonUserdefinedException1.Name = "buttonUserdefinedException1";
            this.buttonUserdefinedException1.Size = new System.Drawing.Size(128, 24);
            this.buttonUserdefinedException1.TabIndex = 2;
            this.buttonUserdefinedException1.Text = "输入mcao自定义异常";
            this.buttonUserdefinedException1.Click += new System.EventHandler(this.buttonUserdefinedException_Click);
            // 
            // textBoxUserDefinedExceptionResult
            // 
            this.textBoxUserDefinedExceptionResult.Location = new System.Drawing.Point(8, 128);
            this.textBoxUserDefinedExceptionResult.Multiline = true;
            this.textBoxUserDefinedExceptionResult.Name = "textBoxUserDefinedExceptionResult";
            this.textBoxUserDefinedExceptionResult.Size = new System.Drawing.Size(288, 88);
            this.textBoxUserDefinedExceptionResult.TabIndex = 1;
            this.textBoxUserDefinedExceptionResult.Text = "";
            // 
            // buttonUserdefinedException2
            // 
            this.buttonUserdefinedException2.Location = new System.Drawing.Point(8, 88);
            this.buttonUserdefinedException2.Name = "buttonUserdefinedException2";
            this.buttonUserdefinedException2.Size = new System.Drawing.Size(128, 24);
            this.buttonUserdefinedException2.TabIndex = 2;
            this.buttonUserdefinedException2.Text = "输入cm自定义异常";
            this.buttonUserdefinedException2.Click += new System.EventHandler(this.buttonUserdefinedException2_Click);
            // 
            // buttonUserdefinedException3
            // 
            this.buttonUserdefinedException3.Location = new System.Drawing.Point(144, 88);
            this.buttonUserdefinedException3.Name = "buttonUserdefinedException3";
            this.buttonUserdefinedException3.Size = new System.Drawing.Size(128, 24);
            this.buttonUserdefinedException3.TabIndex = 2;
            this.buttonUserdefinedException3.Text = "输入jlqiu自定义异常";
            this.buttonUserdefinedException3.Click += new System.EventHandler(this.buttonUserdefinedException3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxInt1);
            this.groupBox3.Controls.Add(this.textBoxInt2);
            this.groupBox3.Controls.Add(this.textBoxCheckResult);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonChecked);
            this.groupBox3.Controls.Add(this.buttonUnchecked);
            this.groupBox3.Controls.Add(this.buttonUndefine);
            this.groupBox3.Controls.Add(this.buttonAssert);
            this.groupBox3.Location = new System.Drawing.Point(336, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 304);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "uncheck/check测试";
            // 
            // textBoxInt1
            // 
            this.textBoxInt1.Location = new System.Drawing.Point(16, 48);
            this.textBoxInt1.Name = "textBoxInt1";
            this.textBoxInt1.Size = new System.Drawing.Size(88, 21);
            this.textBoxInt1.TabIndex = 1;
            this.textBoxInt1.Text = "";
            // 
            // textBoxInt2
            // 
            this.textBoxInt2.Location = new System.Drawing.Point(16, 80);
            this.textBoxInt2.Name = "textBoxInt2";
            this.textBoxInt2.Size = new System.Drawing.Size(88, 21);
            this.textBoxInt2.TabIndex = 1;
            this.textBoxInt2.Text = "";
            // 
            // textBoxCheckResult
            // 
            this.textBoxCheckResult.Location = new System.Drawing.Point(8, 224);
            this.textBoxCheckResult.Multiline = true;
            this.textBoxCheckResult.Name = "textBoxCheckResult";
            this.textBoxCheckResult.ReadOnly = true;
            this.textBoxCheckResult.Size = new System.Drawing.Size(112, 72);
            this.textBoxCheckResult.TabIndex = 1;
            this.textBoxCheckResult.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "结果：";
            // 
            // buttonChecked
            // 
            this.buttonChecked.Location = new System.Drawing.Point(48, 112);
            this.buttonChecked.Name = "buttonChecked";
            this.buttonChecked.Size = new System.Drawing.Size(72, 24);
            this.buttonChecked.TabIndex = 4;
            this.buttonChecked.Text = "checked";
            this.buttonChecked.Click += new System.EventHandler(this.buttonChecked_Click);
            // 
            // buttonUnchecked
            // 
            this.buttonUnchecked.Location = new System.Drawing.Point(48, 144);
            this.buttonUnchecked.Name = "buttonUnchecked";
            this.buttonUnchecked.Size = new System.Drawing.Size(72, 24);
            this.buttonUnchecked.TabIndex = 4;
            this.buttonUnchecked.Text = "unchecked";
            this.buttonUnchecked.Click += new System.EventHandler(this.buttonUnchecked_Click);
            // 
            // buttonUndefine
            // 
            this.buttonUndefine.Location = new System.Drawing.Point(64, 176);
            this.buttonUndefine.Name = "buttonUndefine";
            this.buttonUndefine.Size = new System.Drawing.Size(56, 24);
            this.buttonUndefine.TabIndex = 4;
            this.buttonUndefine.Text = "不指定";
            this.buttonUndefine.Click += new System.EventHandler(this.buttonUndefine_Click);
            // 
            // buttonAssert
            // 
            this.buttonAssert.Location = new System.Drawing.Point(8, 176);
            this.buttonAssert.Name = "buttonAssert";
            this.buttonAssert.Size = new System.Drawing.Size(40, 24);
            this.buttonAssert.TabIndex = 4;
            this.buttonAssert.Text = "断言";
            this.buttonAssert.Click += new System.EventHandler(this.buttonAssert_Click);
            // 
            // Form
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(472, 373);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonUnsafeTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);           
            this.Text = "异常处理演示程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.Button buttonGenenal;
        private System.Windows.Forms.Button buttonException;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonUnsafeTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonThrowmcao;
        private System.Windows.Forms.TextBox textBoxInputmcao;
        private System.Windows.Forms.Button buttonExceptionResult;
        private System.Windows.Forms.TextBox textBoxUserDefinedExceptionResult;
        private System.Windows.Forms.Button buttonUserdefinedException1;
        private System.Windows.Forms.Button buttonUserdefinedException2;
        private System.Windows.Forms.Button buttonUserdefinedException3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxInt1;
        private System.Windows.Forms.TextBox textBoxInt2;
        private System.Windows.Forms.TextBox textBoxCheckResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChecked;
        private System.Windows.Forms.Button buttonUnchecked;
        private System.Windows.Forms.Button buttonUndefine;
        private System.Windows.Forms.Button buttonAssert;
    }
}
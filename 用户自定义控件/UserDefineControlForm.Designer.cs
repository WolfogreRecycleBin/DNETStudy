using WindowsFormsControlLibrary;

namespace mcaoWindowsFormsApplicationForCSharp
{
    partial class UserDefineControlForm
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
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "测试用户自定义控件的使用";           

            this.myUserdefinedControl = new UserControl1();

            this.myUserdefinedControl.Location = new System.Drawing.Point(12, 20);
            this.myUserdefinedControl.Name = "UserControl1";
            this.myUserdefinedControl.TabIndex = 0;
            this.myUserdefinedControl.Text = "MyUserdefinedControl";

            this.Controls.Add(this.myUserdefinedControl);
        }

        #endregion

        private UserControl1 myUserdefinedControl;
    }
}
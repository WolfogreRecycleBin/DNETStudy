using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcaoWindowsFormsApplicationForCSharp
{
    public partial class ControlEventDealtForm : Form
    {
        public ControlEventDealtForm()
        {
            InitializeComponent();
        }

        //（2）这里将要增加内容，以添加事件处理，即对事件的响应
        private void textBoxPassWord_TextChanged(object sender, System.EventArgs e)
        {
            textBoxUnEdit.Visible = false;
        }

        private void textBoxUnEdit_VisibleChanged(object sender, System.EventArgs e)
        {
            textBoxSingleLine.Text = textBoxPassWord.Text;
        }

        private void textBoxPassWord_MouseLeave(object sender, System.EventArgs e)
        {
            textBoxMultipleLine.Text = "您想输入密码?门儿都没有!\\n";
            string temp = "我现在就来告诉您：你正在输入的密码是：\n";
            textBoxMultipleLine.Text += temp;
            textBoxMultipleLine.Text += textBoxPassWord.Text;
            temp = "不服气吗?再来呀?";
            textBoxMultipleLine.Text += temp;
        }	
    }
}

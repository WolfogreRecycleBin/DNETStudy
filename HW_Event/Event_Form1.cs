using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Event
{
    public partial class Event_Form1 : Form
    {
        public Event_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你单击里按钮button1，触发了预定义事件button1_Click！");
        }

        private void Event_Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("你双击了里窗口Event_Form1，触发了预定义事件Event_Form1_DoubleClick！");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

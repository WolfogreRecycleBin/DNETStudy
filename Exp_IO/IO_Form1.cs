using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp_IO
{
    public partial class IO_Form1 : Form
    {

        private bool if_auto_draw { get; set; }

        public IO_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            DrawImage(g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!if_auto_draw)
            {
                button2.Text = "关闭图像自动刷新";
            }
            else
            {
                button2.Text = "显示图像自动刷新";
            }
            if_auto_draw = !if_auto_draw;
        }

        private void IO_Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(if_auto_draw)
                DrawImage(g);
        }

        private void DrawImage(Graphics g)
        {
            //图片显示
            ////////////////////////////////////////
            Bitmap myBitmap = new Bitmap("weiwei.jpg");
            g.DrawImage(myBitmap, 200, 10);
        }

    }
}

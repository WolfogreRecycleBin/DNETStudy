using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobang
{
    public partial class Form1 : Form
    {
		Board board = new Board();
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			board.Draw(g);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			//MessageBox.Show(e.KeyValue.ToString());
			Graphics g = this.CreateGraphics();
			if(e.KeyValue == 87)
			{
				board.UpdateCursor(g, 0, -1);
			}
			if (e.KeyValue == 83)
			{
				board.UpdateCursor(g, 0, 1);
			}
			if (e.KeyValue == 68)
			{
				board.UpdateCursor(g, 1, 0);
			}
			if (e.KeyValue == 65)
			{
				board.UpdateCursor(g, -1, 0);
			}
		}
    }
}

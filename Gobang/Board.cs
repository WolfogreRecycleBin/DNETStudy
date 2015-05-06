using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Gobang
{
    class Board
    {
		float x = 30;
		float y = 30;
		float spacing = 45;
		int row = 14;
		int col = 14;
		Point cursor = new Point(8,8);
		int[,] matrix = new int [15,15];
		Bitmap background = new Bitmap("木板2.jpg");
        public void Draw(Graphics g)
        {
			int f = 1;
			for (int i = 0; i <= col; i = i + 3)
				for (int j = 0; j <= row; j = j + 2)
				{
					if(i>j) matrix[i, j] = f = -f;
				}
			matrix[0, 0] = 1;
			matrix[14, 14] = -1;
			matrix[1, 1] = 1;
			matrix[10, 3] = -1;
			DrawBackground(g);
			DrawBoard(g);
			DrawPiece(g);
			DrawCursor(g);
        }
		public void DrawBackground(Graphics g)
		{
			Rectangle sourceRectangle = new Rectangle(0, 0, 1000, 1000);
			Rectangle destRectangle1 = new Rectangle(0, 0, 1000, 1000);
			g.DrawImage(background, destRectangle1, sourceRectangle, GraphicsUnit.Pixel);
		}
		public void DrawBoard(Graphics g)
		{
			float height = row * spacing;
			float width = col * spacing;
			Color color = new Color();
			color = Color.FromArgb(90, 46, 19);
			Pen pen = new Pen(color, 3);

			for (int i = 0; i <= col; ++i)
			{
				g.DrawLine(pen, x + i * spacing, y, x + i * spacing, y + height);
			}
			for (int i = 0; i <= row; ++i)
			{
				g.DrawLine(pen, x, y + i * spacing, x + width, y + i * spacing);
			}
		}

		

		public void DrawPiece(Graphics g)
		{
			Color write = new Color();
			Color black = new Color();
			write = Color.FromArgb(255, 255, 255);
			black = Color.FromArgb(0, 0, 0);
			Pen pen = new Pen(black, 1);
			for (int i = 0; i <= col; ++i)
				for (int j = 0; j <= row; ++j)
				{
					if(matrix[i,j] == 1)
					{
						RectangleF rect = new RectangleF(x + i * spacing - 20, y + j * spacing - 20, 40, 40);
						g.DrawEllipse(pen, rect);
						g.FillEllipse(new SolidBrush(black), rect);
					}
					if (matrix[i, j] == -1)
					{
						RectangleF rect = new RectangleF(x + i * spacing - 20, y + j * spacing - 20, 40, 40);
						g.FillEllipse(new SolidBrush(write), rect);
						g.DrawEllipse(pen, rect);
					}
				}
		}
		public void DrawCursor(Graphics g)
		{
			Color color = new Color();
			color = Color.FromArgb(150, 0, 0, 0);
			Pen pen = new Pen(color, 3);
			Rectangle rect = new Rectangle((int)(x + cursor.X * spacing - 30), (int)(y + cursor.Y * spacing - 30), 60, 60);
			g.DrawRectangle(pen,rect);
		}

		public void UpdateCursor(Graphics g, int move_x, int move_y)
		{
			int old_x = cursor.X;
			int old_y = cursor.Y;
			cursor.X += move_x;
			cursor.Y += move_y;
			bool if_moved = true;
			if (cursor.X < 0)
			{
				cursor.X = 0;
				if_moved = false;
			}
			if (cursor.X > row)
			{
				cursor.X = row;
				if_moved = false;
			}
			if (cursor.Y < 0)
			{
				cursor.Y = 0;
				if_moved = false;
			}
			if (cursor.Y > col)
			{
				cursor.Y = col;
				if_moved = false;
			}
			if(if_moved)
			{
				Rectangle sourceRectangle = new Rectangle((int)(x + old_x * spacing - 30) - 5, (int)(y + old_y * spacing - 30) - 5, 70, 70);
				Rectangle destRectangle1 = new Rectangle((int)(x + old_x * spacing - 30) - 5, (int)(y + old_y * spacing - 30) - 5, 70, 70);
				g.DrawImage(background, destRectangle1, sourceRectangle, GraphicsUnit.Pixel);

				
			}
		}
    }
}

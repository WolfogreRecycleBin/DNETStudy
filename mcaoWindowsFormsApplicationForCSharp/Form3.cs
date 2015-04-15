using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace mcaoWindowsFormsApplicationForCSharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void 放大缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            DrawEveryImage(g);  
            //Invalidate();
        }

        private void DrawEveryImage(Graphics g)
        {
            //图片显示
            /////////////////////////////////////////
            Bitmap myBitmap = new Bitmap("我不想上课就想发呆.jpg");
            Rectangle expansionRectangle = new Rectangle(480, 10,
                myBitmap.Width * 2, myBitmap.Height * 2);
            Rectangle compressionRectangle = new Rectangle(10, 380,
                myBitmap.Width / 4, myBitmap.Height / 4);
            g.DrawImage(myBitmap, 10, 10);//按原来大小显示
            g.DrawImage(myBitmap, expansionRectangle);//放大两倍
            g.DrawImage(myBitmap, compressionRectangle);//按压缩后的比例显示

            Rectangle sourceRectangle = new Rectangle(56, 270, 80, 60);
            Rectangle destRectangle1 = new Rectangle(160, 380, 20, 16);
            Rectangle destRectangle2 = new Rectangle(200, 380, 200, 160);
            g.DrawImage(myBitmap, destRectangle1, sourceRectangle, GraphicsUnit.Pixel);
            g.DrawImage(myBitmap, destRectangle2, sourceRectangle, GraphicsUnit.Pixel);
        }

        private void 定时显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 0;
            timer1.Interval = 200;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 100) timer1.Stop();
            //Invalidate();
            Graphics g = this.CreateGraphics();
            DrawEveryImageAccordingime(g);
        }

        private void DrawEveryImageAccordingime(Graphics g)
        {
            //图片显示--左右双向靠拢
            /////////////////////////////////////////
            Bitmap myBitmap = new Bitmap("我不想上课就想发呆.jpg");
            int x = (myBitmap.Width / 100) * i;

            Rectangle sourceRectangle = new Rectangle(10, 10, x, myBitmap.Height);
            Rectangle sourceRectangle1 = new Rectangle(myBitmap.Width - x, 10, x, myBitmap.Height);

            Rectangle expansionRectangle = new Rectangle(10, 10, x, myBitmap.Height);
            Rectangle compressionRectangle = new Rectangle(myBitmap.Width - x, 10, x, myBitmap.Height);
            g.DrawImage(myBitmap, expansionRectangle, sourceRectangle, GraphicsUnit.Pixel);//左边
            g.DrawImage(myBitmap, compressionRectangle, sourceRectangle1, GraphicsUnit.Pixel);//右边
        }

        private void DrawComplicatedGraph(Graphics g)
        {
            //画蓝色空心矩形
            Pen myPen = new Pen(Color.DarkBlue, 3);
            g.DrawRectangle(myPen, 20, 10, 100, 50);

            //画线，各种线型
            g.DrawLine(myPen, 4, 2, 12, 6);

            Point myStartPoint = new Point(4, 12);
            Point myEndPoint = new Point(12, 16);
            g.DrawLine(myPen, myStartPoint, myEndPoint);

            myPen.Color = Color.DarkOrange;
            g.DrawLine(myPen, 4, 22, 12, 26);

            myPen.Width = 1;
            g.DrawLine(myPen, 4, 32, 12, 36);

            myPen.DashStyle = DashStyle.Dash;
            g.DrawLine(myPen, 4, 72, 52, 72);

            myPen.EndCap = LineCap.ArrowAnchor;
            myPen.StartCap = LineCap.RoundAnchor;
            g.DrawLine(myPen, 4, 82, 52, 82);
            myPen.LineJoin = LineJoin.MiterClipped;
            myPen.StartCap = LineCap.Triangle;
            g.DrawLine(myPen, 56, 82, 56, 102);

            //绿色矩形
            myPen.Color = Color.Green;
            Rectangle myRectangle = new Rectangle(20, 120, 60, 40);
            g.DrawRectangle(myPen, myRectangle);
            myRectangle.Offset(10, 20);
            g.DrawRectangle(myPen, myRectangle);

            //各种椭圆、多边形
            myPen.DashStyle = DashStyle.DashDotDot;
            g.DrawEllipse(myPen, 20, 200, 60, 40);
            myPen.Color = Color.Red;
            g.DrawArc(myPen, myRectangle, 45.0f, 190.0f);

            myPen.Color = Color.Purple;
            myPen.DashStyle = DashStyle.Solid;
            myPen.Width = 3;
            Point[] myPointArray = { new Point(0, 200), new Point(50, 230), new Point(30, 260) };
            g.DrawPolygon(myPen, myPointArray);

            myPen.Color = Color.Pink;
            Point[] myPointArray1 = { new Point(0, 240), new Point(50, 270), new Point(30, 300), new Point(70, 220) };
            g.DrawBezier(myPen, myPointArray1[0], myPointArray1[1], myPointArray1[2], myPointArray1[3]);

            Point[] myPointArray2 = { new Point(0, 280), new Point(50, 310), new Point(30, 340), new Point(70, 260) };
            g.DrawClosedCurve(myPen, myPointArray2, 3.6f, FillMode.Winding);

            //各种实心图形
            /////////////////////////////////////////////////////////
            SolidBrush mySolidBrush = new SolidBrush(Color.Red);
            g.FillEllipse(mySolidBrush, 160, 0, 60, 40);

            HatchBrush myHatchBrush = new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.Red);
            g.FillEllipse(myHatchBrush, 160, 40, 60, 40);
            myHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Blue, Color.Red);
            g.FillEllipse(myHatchBrush, 160, 80, 60, 40);

            //图片填充实心图形
            Image myImage = Image.FromFile("3.jpg");            
            TextureBrush myTextureBrush = new TextureBrush(myImage);
            g.FillEllipse(myTextureBrush, 160, 120, 60, 40);

            myRectangle.Offset(80, 10);
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(
                myRectangle,
                Color.Blue,
                Color.Green,
                LinearGradientMode.Horizontal);
            g.FillEllipse(myLinearGradientBrush, myRectangle);

            //字符串输出
            //////////////////////////////////////////////////			
            g.DrawString("Sample", new System.Drawing.Font("Arial", 16), mySolidBrush,
                180.0f, 160.0f, new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical));

            ///////////////////////////////////////////////////			
            myRectangle.Offset(20, 100);
            myPen.Color = Color.PaleVioletRed;
            GraphicsPath myPath = new GraphicsPath(FillMode.Alternate);
            myPath.AddArc(myRectangle, 45.0f, 190.0f);
            myPath.AddBezier(100, 200, 140, 260, 120, 280, 100, 220);
            myPath.AddLine(100, 200, 130, 220);
            g.DrawPath(myPen, myPath);

            GraphicsPath myPath1 = new GraphicsPath(FillMode.Winding);
            myPen.Color = Color.PaleGreen;
            Point[] myPointArray4 = {
									   new Point(105, 260), 
									   new Point(120, 340), 
									   new Point(150, 360)};
            FontFamily myFontFamily = new FontFamily("Times New Roman");
            PointF myPointF = new PointF(150, 320);
            StringFormat myStringFormat = new StringFormat();

            myPath1.AddArc(100, 200, 230, 320, -60, 80);
            myPath1.StartFigure();
            myPath1.AddCurve(myPointArray4);
            myPath1.AddString("a string in a path", myFontFamily,
                0, 24, myPointF, myStringFormat);
            myPath1.AddPie(130, 10, 40, 40, 40, 10);
            g.DrawPath(myPen, myPath1);

            //图片特殊显示
            /////////////////////////////////////////
            Bitmap myBitmap = new Bitmap("4.jpg");
            g.DrawImage(myBitmap, 360, 10);//按原来大小显示
            Rectangle sourceRectangle = new Rectangle(56, 270, 80, 60); //取图片的一部分--名字
            Rectangle sourceRectangle1 = new Rectangle(30, 0, 160, 150); //取图片的一部分--脸庞
            Rectangle destRectangle1 = new Rectangle(280, 380, 40, 36);
            Rectangle destRectangle2 = new Rectangle(570, 380, 200, 160);
            Rectangle destRectangle3 = new Rectangle(360, 380, 200, 160);
            g.DrawImage(myBitmap, destRectangle1, sourceRectangle, GraphicsUnit.Pixel);
            g.DrawImage(myBitmap, destRectangle2, sourceRectangle, GraphicsUnit.Pixel);
            g.DrawImage(myBitmap, destRectangle3, sourceRectangle1, GraphicsUnit.Pixel);
        }

        private void 复杂图形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Invalidate();
            Graphics g = this.CreateGraphics(); 
            DrawComplicatedGraph(g);
        }

        private void DrawContainer(Graphics g)
        {
            //Invalidate();
            //下面的示例在Graphics对象中创建容器。Graphics对象的全局变形是向右平移 120个单位，而容器的全局变形是向下平移80个单位。
            g.TranslateTransform(120, 0);
            Pen myPen = new Pen(Color.PaleVioletRed, 3);
            GraphicsContainer myGraphicsContainer = g.BeginContainer();
            g.TranslateTransform(0, 80);
            g.DrawRectangle(myPen, 0, 0, 50, 50);
            g.EndContainer(myGraphicsContainer);
            g.DrawRectangle(myPen, 0, 0, 50, 50);

            //下面的示例在 Graphics 对象中创建容器，并在第一个容器中创建另一容器。
            //Graphics对象的全局变换是在x方向平移100个单位，在y方向平移80个单位。
            //第一个容器的全局变形是旋转30度。第二个容器的全局变形是在x方向缩放 2 倍。
            //对 DrawEllipse 方法的调用是在第二个容器内做出的。
            myPen.Color = Color.PowderBlue;
            g.TranslateTransform(100, 80, MatrixOrder.Append);

            GraphicsContainer container1 = g.BeginContainer();
            g.RotateTransform(30, MatrixOrder.Append);

            GraphicsContainer container2 = g.BeginContainer();
            g.ScaleTransform(2, 1);
            g.DrawEllipse(myPen, -30, -20, 60, 40);
            g.EndContainer(container2);

            g.EndContainer(container1);

            //下面的示例以坐标系统原点为中心绘制了一只眼睛
            DrawEye(g);
            //下面的示例绘制三个椭圆（面孔），每个里面都有一只眼睛
            Draw3Eye(g);
        }

        ///////////////////////////////////////////
        /*******************************************************************************
		 * 对于将 Graphics 对象的全局变形与容器合并的另一示例：假定您要绘制一只眼睛并将
		 * 其置于面孔序列上的各种位置。下面的示例以坐标系统原点为中心绘制了一只眼睛：
		 * This示例中的 DrawEye 函数可接收 Graphics 对象，并立即在该 Graphics 对象中创建容器。
		 * 此容器将任何调用 DrawEye 函数的代码与在执行 DrawEye 函数期间做出的属性设置隔离开来。
		 * 例如，DrawEye 函数中的代码设置 Graphics 对象的剪辑区域，但当 DrawEye 将控件返回到
		 * 调用例程时，剪辑区域将和它在调用 DrawEye 之前的状态一样。
		 * *****************************************************************************/
        private void DrawEye(Graphics myGraphics)
        {
            GraphicsContainer eyeContainer;

            eyeContainer = myGraphics.BeginContainer();

            Pen myBlackPen = new Pen(Color.Black);
            SolidBrush myGreenBrush = new SolidBrush(Color.Green);
            SolidBrush myBlackBrush = new SolidBrush(Color.Black);

            GraphicsPath myTopPath = new GraphicsPath();
            myTopPath.AddEllipse(-30, -50, 60, 60);

            GraphicsPath myBottomPath = new GraphicsPath();
            myBottomPath.AddEllipse(-30, -10, 60, 60);

            Region myTopRegion = new Region(myTopPath);
            Region myBottomRegion = new Region(myBottomPath);

            // Draw the outline of the eye.
            // The outline of the eye consists of two ellipses.
            // The top ellipse is clipped by the bottom ellipse, and
            // the bottom ellipse is clipped by the top ellipse.
            myGraphics.Clip = myTopRegion;
            myGraphics.DrawPath(myBlackPen, myBottomPath);
            myGraphics.Clip = myBottomRegion;
            myGraphics.DrawPath(myBlackPen, myTopPath);

            // Fill the iris.
            // The iris is clipped by the bottom ellipse.
            myGraphics.FillEllipse(myGreenBrush, -10, -15, 20, 22);

            // Fill the pupil.
            myGraphics.FillEllipse(myBlackBrush, -3, -7, 6, 9);

            myGraphics.EndContainer(eyeContainer);
        }

        /*******************************************************************************
         * 下面的示例绘制三个椭圆（面孔），每个里面都有一只眼睛：
         * 在示例中，所有的椭圆都是调用 DrawEllipse(myBlackPen, -40, -60, 80, 120) 来绘制的，
         * 此调用以坐标系统的原点为中心绘制椭圆。通过设置 Graphics 对象的全局变形，将椭圆从
         * 工作区左上角移开。语句 myGraphics.TranslateTransform(100, 100) 使第一个椭圆
         * 以 (100, 100) 为中心。语句 myGraphics.TranslateTransform(100, 0) 使第二个椭圆的
         * 中心在第一个椭圆的中心右边 100 个单位处。同样，第三个椭圆的中心在第二个椭圆的中心
         * 右边 100 个单位处。
         * 示例中的容器用于相对给定椭圆的中心来变形眼睛。第一只眼睛在椭圆中心处绘制，没有变形，
         * 因此不在容器中调用 DrawEye。第二只眼睛旋转 40 度并在椭圆中心上方 30 个单位处绘制，
         * 因此在容器内调用 DrawEye 函数和设置变形的方法。第三只眼睛经过拉伸和旋转，并在椭圆
         * 中心处绘制。像处理第二只眼睛一样，在容器内调用 DrawEye 函数和设置变形的方法。
         * *****************************************************************************/
        private void Draw3Eye(Graphics myGraphics)
        {
            Pen myBlackPen = new Pen(Color.Black, 2);
            GraphicsContainer myGraphicsContainer = myGraphics.BeginContainer();
            // Draw an ellipse centered at (100, 100).
            myGraphics.TranslateTransform(100, 100);
            myGraphics.DrawEllipse(myBlackPen, -40, -60, 80, 120);

            // Draw the eye at the center of the ellipse.
            DrawEye(myGraphics);

            // Draw an ellipse centered at 200, 100.
            myGraphics.TranslateTransform(100, 0, MatrixOrder.Append);
            myGraphics.DrawEllipse(myBlackPen, -40, -60, 80, 120);

            // Rotate the eye 40 degrees, and draw it 30 units above
            // the center of the ellipse.
            myGraphicsContainer = myGraphics.BeginContainer();
            myGraphics.RotateTransform(-40);
            myGraphics.TranslateTransform(0, -30, MatrixOrder.Append);
            DrawEye(myGraphics);
            myGraphics.EndContainer(myGraphicsContainer);

            // Draw an ellipse centered at (300, 100).
            myGraphics.TranslateTransform(100, 0, MatrixOrder.Append);
            myGraphics.DrawEllipse(myBlackPen, -40, -60, 80, 120);

            // Stretch and rotate the eye, and draw it at the 
            // center of the ellipse.
            myGraphicsContainer = myGraphics.BeginContainer();
            myGraphics.ScaleTransform(2, 1.5f);
            myGraphics.RotateTransform(45, MatrixOrder.Append);
            DrawEye(myGraphics);
            myGraphics.EndContainer(myGraphicsContainer);

        }

        private void 容器眼睛ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Graphics g = this.CreateGraphics(); 
            DrawContainer(g);
            //思考题2：此处加上下列语句，运行结果会有什么变化，为什么？
            //Invalidate();
            //思考题3：如何理解“刷新”及其响应？
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //断言使用

namespace mcaoWindowsFormsApplicationForCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            timecounter = 0;
            s1 = "";
            s2 = "";
            InitializeComponent();
        }

        private void 事件演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();  //启动定时器
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timecounter++;      //更新域值
            Rectangle bitrect = new Rectangle(20, 40, 200, 60);
            Invalidate(bitrect);    //局部刷新

            //思考题1：两种触发、产生事件的方法本质上有什么不同？为什么运行效果不同？
            //CauseEvent1(); 
            CauseEvent2(); 
        }

        //第一种触发事件的方法
        private void CauseEvent1()
        {
            if (timecounter == 6)    //计时器到6秒时，触发字定义的事件
            {
                MyCheckInput mycheck = new MyCheckInput("她不想上课", "她一个劲儿地发呆");  //事件参数类实例化
                CheckEventOccurDealt mydealt = new CheckEventOccurDealt();                  //自定义事件实例化
                mydealt.MakeItOccur(mycheck);               //调用自定义事件对象的触发方法，参数为事件参数对象。
                //注意，这里只是调用了自定义事件对象的触发方法，并没有直接调用【与事件关联的】指代方法

                //根据事件的两个参数分别更新窗体的两个字符串域，这两个域的值决定了要不要画图
                s1 = mydealt.cause;
                s2 = mydealt.result;

                //刷新窗体绘图区域
                Invalidate();
            }

            if (timecounter == 12)    //计时器到12秒时，停止计时器，并更新两个字符串域【s1，s2】的值为空
            {
                timer1.Stop();        //停止定时器
                timecounter = -1;    //更新域值
                s1 = "";            //更新域值
                s2 = "";            //更新域值
                Invalidate();       //刷新窗体绘图区域
            } 
        }

        //第二种触发事件的方法
        private void CauseEvent2()
        {
            CheckEventOccurDealt mydealt = new CheckEventOccurDealt();      //自定义事件实例化
            MyCheckInput mycheck = new MyCheckInput("", "");                //事件参数类实例化; 
            if (timecounter == 6)
            {
                mycheck.position = "她不想上课";
                mycheck.result = "她一个劲儿地发呆";
            }
            mydealt.MakeItOccur(mycheck);               //调用自定义事件对象的触发方法，参数为事件参数对象。
            //注意，这里只是调用了自定义事件对象的触发方法，并没有直接调用【与事件关联的】指代方法

            //根据事件的两个参数分别更新窗体的两个字符串域，这两个域的值决定了要不要画图
            s1 = mydealt.cause;
            s2 = mydealt.result;
            Invalidate();       //刷新窗体绘图区域

            if (timecounter == 12)
            {
                timer1.Stop();        //停止定时器
                timecounter = -1;    //更新域值
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush myBrush = new
               System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle,
               Color.Red, Color.Yellow, System.Drawing.Drawing2D.
               LinearGradientMode.Horizontal);
            Font myFont = new Font("Times New Roman", 24);
            Graphics g = this.CreateGraphics();
            if (timecounter != -1)   //若计时器没有停止，则显示计时器上的数字
                g.DrawString(timecounter.ToString(), myFont, myBrush, new Point(20,40));
            
            DrawEventInfo(s1, s2);
            DrawImage();
        }

        private void DrawEventInfo(string s1, string s2) //有条件地画事件信息--两个字符串域【s1，s2】的值不为空
        {
            if (s1.Equals("") == true && s2.Equals("") == true)                
                return;
            
            Graphics g = this.CreateGraphics();
            System.Drawing.Drawing2D.LinearGradientBrush myBrush = new
                System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle,
                Color.Red, Color.Yellow, System.Drawing.Drawing2D.
                LinearGradientMode.Horizontal);
            Font myFont = new Font("Times New Roman", 24);

            g.DrawString(s1, myFont, myBrush, new Point(20, 140));
            g.DrawString(s2, myFont, myBrush, new Point(20, 180));
            g.DrawString("产生教学事件了！", myFont, myBrush, new Point(20, 100));
        }

        private void DrawImage()    //有条件地画图片
        {
            if (s1 == "" && s2 == "")
                return;            

            Graphics g = this.CreateGraphics();
            string filename = "我不想上课就想发呆.jpg";
            Bitmap myBitmap = new Bitmap(filename);

            Rectangle bitrect = new Rectangle(20, 240, 200, 200);
            g.DrawImage(myBitmap, bitrect); 
        }

        private void 断言ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.Assert(this.menuStrip1.Items.Find("断言", true) != null == false);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Debug.Assert(this.menuStrip1.Items.Find("断言", true) != null == false);
        }

        private void 一般异常ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                throw (new ArgumentNullException());//抛出“参数值为空”的异常
            }
            catch (ArgumentNullException ae)
            {
               
                MessageBox.Show(ae.ToString() + "  ::   " + ae.Message);   //捕获“参数值为空”的异常后弹出消息框        
            }
        }

        private void 异常嵌套ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                throw (new ArgumentNullException());//抛出“参数值为空”的异常
            }
            catch (ArgumentNullException ae)//捕获“参数值为空”的异常后 
            {
                try
                {
                    MessageBox.Show(ae.ToString() + "  ::   " + ae.Message);//首先弹出消息框
                    throw new Exception("我就是乱抛异常，你已经套了一层了", ae);//继续抛出异常
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString() + "  ::   尽管你没做什么，我就是认为这是异常！你想说什么？" + ee.Message);
                }
            }
        }

        private void 教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void AboutForm2AccordingtoStatus()
        {
            
        }

        private void 辅导员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 教学秘书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 班导师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }               

        private void 教师ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void 本课程教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 定时图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 myOutputForm = new Form3();
            myOutputForm.ShowDialog();
        }

        private void 学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                   
        }

        private void 猜猜我在哪儿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 自定义异常及其他语法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDefineSyntaxForm mydefineForm = new UserDefineSyntaxForm();
            mydefineForm.ShowDialog();
        }

        private void 装箱测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 线程画图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 控件属性设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlProperty myForm = new ControlProperty();
            myForm.ShowDialog();
        }

        private void 控件事件处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlEventDealtForm myForm = new ControlEventDealtForm();
            myForm.ShowDialog();
        }

        private void 打开文件对话框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            printPreviewDialog1.ShowDialog();
        }

        private void 浏览文件对话框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            printPreviewDialog2.Show();
        }

        private void 各种控件演示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EveryKindOfControlForm myForm = new EveryKindOfControlForm();
            myForm.ShowDialog();
        }

        private void 分割窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlipControlForm myForm = new SlipControlForm();
            myForm.ShowDialog();
        }

        private void 用户自定义控件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDefineControlForm myForm = new UserDefineControlForm();
            myForm.ShowDialog();
        }

        //本部分测试在菜单上自画图片
        enum Weather
        {
            SUN = 0, RAIN, SNOW
        };//菜单项索引
        string[] WeatherName = { "SUN", "RAIN", "SNOW" };//菜单项文本

        private void MyDrawMenuItems(Weather aWeather, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle aRect = new Rectangle();//绘制图标的矩形区域
            aRect.X = e.Bounds.X;
            aRect.Y = e.Bounds.Y;
            aRect.Height = e.Bounds.Height;
            aRect.Width = e.Bounds.Height;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {//判断菜单项是否被选中，填充不同颜色
                g.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(this.BackColor), e.Bounds);
            }

            Icon anIcon;//各菜单项使用的图标
            anIcon = new Icon(WeatherName[(int)aWeather] + ".ico");
            g.DrawIcon(anIcon, aRect);//绘制图标，然后写菜单文本
            g.DrawString(WeatherName[(int)aWeather], this.Font, new SolidBrush(Color.Black), e.Bounds.X + 20, e.Bounds.Y);
        }

        private void 打印文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string printPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);            
            //fileToPrint = new System.IO.StreamReader(printPath + @"\myFile.txt");
            fileToPrint = new System.IO.StreamReader("myFile.txt");
            printFont = new System.Drawing.Font("Arial", 40);
            //printDocument1.Print();
            if (printPreviewDialog3.IsDisposed == true)
            {
                printPreviewDialog3 = new PrintPreviewDialog();
                printPreviewDialog3.Document = printDocument1;
            }
            printPreviewDialog3.Show();
            //fileToPrint.Close();--加该句话不能打印文件,因为文件关闭,不能读取内容了
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }

            //add here to try--效果和不关闭文件一样,不能连续点击"打印文本文件"按钮
            //fileToPrint.Close();
        }

        private void 打印窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog4.IsDisposed == true)
            {
                printPreviewDialog4 = new PrintPreviewDialog();
                printPreviewDialog4.Document = printDocument2;
            }
            CaptureScreen();
            printPreviewDialog4.Show();
        }

        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*r若果有控件，可采取下面的方式加入控件
             * 
             PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
			 this.InvokePaint(dataGrid1, myPaintArgs);
             */
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void 无模对话框ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

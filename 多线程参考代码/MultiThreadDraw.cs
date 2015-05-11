using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace mcaoWindowsFormsApplicationForCSharp
{
    public partial class MultiThreadDraw : Form
    {
        public MultiThreadDraw()
        {
            InitializeComponent();
            timevaryshare = 0;
        }

        //用来模拟复杂运算 
        public static void dosth()
        {
            for (long j = 0; j < 10000000; j++)
            {
                long a = 15;
                a = a * a * a * a;
            }
        }

        //第一个线程从左面开始画图
        public void Thread1()
        {
            Invalidate();
            string filename = "我不想上课就想发呆.jpg";
            Bitmap myBitmap = new Bitmap(filename);
            Graphics g = this.CreateGraphics();
            int timevary = 0;

            for (int i = 0; i < 100; i++)
            {
                timevary++;                
                dosth();
                Rectangle sourceRectangle = new Rectangle(timevary * (myBitmap.Width / 200), 0, myBitmap.Width / 200, myBitmap.Height);
                Rectangle expansionRectangle = new Rectangle(timevary * (myBitmap.Width / 200), 40, myBitmap.Width / 200, myBitmap.Height);
               
                g.DrawImage(myBitmap, sourceRectangle, expansionRectangle, GraphicsUnit.Pixel);//左边                 
            }
        }

        //第二个线程从右面开始画图
        public void Thread2()
        {
            Invalidate();
            string filename = "我不想上课就想发呆.jpg";
            Bitmap myBitmap = new Bitmap(filename);
            Graphics g = this.CreateGraphics();
            int timevary = 0;           

            for (int i = 0; i < 100; i++)
            {
                timevary++;                
                dosth();
                Rectangle sourceRectangle = new Rectangle(myBitmap.Width - timevary * (myBitmap.Width / 200), 0, myBitmap.Width / 200, myBitmap.Height);
                Rectangle compressionRectangle = new Rectangle(myBitmap.Width - timevary * (myBitmap.Width / 200), 40, myBitmap.Width / 200, myBitmap.Height);
                g.DrawImage(myBitmap, sourceRectangle, compressionRectangle, GraphicsUnit.Pixel);//右边                
            }
        }

        private void 线程1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(Thread1));
            t1.Start();
        }

        private void 线程2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(new ThreadStart(Thread2));
            t2.Start();
        }

        private void 两个线程同时ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(Thread1));
            Thread t2 = new Thread(new ThreadStart(Thread2));
            t1.Start();
            t2.Start();
        }

        //第三个线程从左面开始画图
        public void Thread3()
        {
            Invalidate();
            string filename = "我不想上课就想发呆.jpg";
            Bitmap myBitmap = new Bitmap(filename);
            Graphics g = this.CreateGraphics();
            timevaryshare = 0;

            for (int i = 0; i < 100; i++)
            {                
                timevaryshare++;
                dosth();
                Rectangle sourceRectangle = new Rectangle(timevaryshare * (myBitmap.Width / 200), 0, myBitmap.Width / 200, myBitmap.Height);
                Rectangle expansionRectangle = new Rectangle(timevaryshare * (myBitmap.Width / 200), 40, myBitmap.Width / 200, myBitmap.Height);
                g.DrawImage(myBitmap, sourceRectangle, expansionRectangle, GraphicsUnit.Pixel);//左边 
                g.DrawImage(myBitmap, sourceRectangle, expansionRectangle, GraphicsUnit.Pixel);//左边
            }
        }

        //第四个线程从右面开始画图
        public void Thread4()
        {
            Invalidate();
            string filename = "我不想上课就想发呆.jpg";
            Bitmap myBitmap = new Bitmap(filename);
            Graphics g = this.CreateGraphics();

            for (int i = 0; i < 100; i++)
            {
                timevaryshare++;
                dosth();
                Rectangle sourceRectangle = new Rectangle(myBitmap.Width - timevaryshare * (myBitmap.Width / 200), 0, myBitmap.Width / 200, myBitmap.Height);
                Rectangle compressionRectangle = new Rectangle(myBitmap.Width - timevaryshare * (myBitmap.Width / 200), 40, myBitmap.Width / 200, myBitmap.Height);
                g.DrawImage(myBitmap, sourceRectangle, compressionRectangle, GraphicsUnit.Pixel);//右边
            }
        }

        //思考7：为什么会出现“虚图”？提示：timevaryshare是域，像个线程都在修改它
        private void 两个线程共享ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(Thread3));
            Thread t2 = new Thread(new ThreadStart(Thread4));
            t1.Start();
            t2.Start();
        }

        private void 一个线程join另一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(Thread1));
            Thread t2 = new Thread(new ThreadStart(Thread2));
            
            t2.Start();
            //t2.Join();
            t2.Join(6000); 
            t1.Start(); 
            //思考题：设置线程优先级等，如何实现？
        }

		/*
        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool b = false;
            DataPackage pack = new DataPackage();

            // 创建包含线程方法的对象
            SendPackage server = new SendPackage(pack, 10);
            ReceivePackage client = new ReceivePackage(pack, 10);

            // 创建两个线程对象，一个用于发送数据包，另一个用于接收数据包 
            Thread sendthread = new Thread(new ThreadStart(server.SendPackageThreadRun));
            Thread receivethread = new Thread(new ThreadStart(client.ReceivePackageThreadRun));

            //启动线程以前查看线程状态
            ThreadState ts = sendthread.ThreadState;	// 获取并显示线程的状态
            MessageBox.Show("发送线程的目前状态：" + ts.ToString()); 

            try
            {
                // 启动两个线程
                sendthread.Start();
                while (!sendthread.IsAlive) ;	// 等待线程进入运行状态
                ts = sendthread.ThreadState;
                MessageBox.Show("发送线程启动而接受线程没有启动时的状态：" + ts.ToString()); 
		 * 
                b = (MessageBox.Show("您想启动接受线程么?", "请选择", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
                while ( b != true)
                {
                    Console.WriteLine("");
                    b = (MessageBox.Show("您想启动接受线程么?", "您未启动接受线程，继续等待！", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
                }
                receivethread.Start();

                //下面这三行代码是否增加，输出结果不一样，由此可以看到Suspend的作用

                //receivethread.Suspend();
                //Thread.Sleep(5000);
                //receivethread.Resume();

                // 等待两个线程结束
                sendthread.Join();
                receivethread.Join();
            }
            catch (ThreadStateException ee) //线程异常处理
            {
                MessageBox.Show(ee.ToString());
            }
            catch (ThreadInterruptedException ee) //线程异常处理
            {
                MessageBox.Show(ee.ToString());
            }

            ts = sendthread.ThreadState;
            MessageBox.Show("发送和接受线程都启动后的状态1：" + ts.ToString());            
            ts = receivethread.ThreadState;
            MessageBox.Show("发送和接受线程都启动后的状态2：" + ts.ToString());
        }
		*/
        //
    }
}

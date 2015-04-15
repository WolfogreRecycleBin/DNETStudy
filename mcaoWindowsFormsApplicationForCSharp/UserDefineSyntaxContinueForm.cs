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
    public partial class UserDefineSyntaxContinueForm : Form
    {
        public UserDefineSyntaxContinueForm()
        {
            InitializeComponent();
        }

        //为了测试将指针作为函数形参，所以定义该函数
        static int value = 20;
        unsafe static void F(out int* pi1, ref int* pi2)
        {
            //string strTemp = textBoxInt.Text;
            //int i = int.Parse(strTemp);
            int i = 10;
            pi1 = &i;
            fixed (int* pj = &value)
            {
                // ...
                pi2 = pj;
            }
        }

        private void buttonFunc_Click(object sender, System.EventArgs e)
        {
            int i = int.Parse(textBoxInt.Text.ToString());
            unsafe
            {
                int* px1;
                int* px2 = &i;
                F(out px1, ref px2);// undefined behavior
                textBoxResult.Text = "*px1 = " + (*px1).ToString() + ", *px2 = " + (*px2).ToString();
            }

        }

        //堆栈分配例子
        public string MyHeapStackAllocTest(int value)
        {
            int n = value >= 0 ? value : -value;
            unsafe
            {
                char* buffer = stackalloc char[16];
                char* p = buffer + 16;
                do
                {
                    *--p = (char)(n % 10 + '0');
                    n /= 10;
                } while (n != 0);
                if (value < 0) *--p = '-';
                return new string(p, 0, (int)(buffer + 16 - p));
            }
        }

        private void buttonIntAlloc_Click(object sender, System.EventArgs e)
        {
            //堆栈分配例子--int
            int i = int.Parse(textBoxIntAlloc.Text.ToString());
            string tempStr = this.MyHeapStackAllocTest(i);
            tempStr += "\n" + "You alloc " + tempStr.Length + " size together!";
            textBoxAllocResult.Text = tempStr;
        }

        //测试fixed语句，以string类型为例//
        //unsafe static void MyFixedTestSalve(char* p) 
        unsafe static string MyFixedTestSalve(char* p)
        {
            string tempStr = "";
            //textBoxStringResult.Text = "";
            for (int i = 0; p[i] != '\0'; ++i)
                //MessageBox.Show(p[i].ToString());
                tempStr += p[i].ToString();
            //this.textBoxStringResult.Text = "";
            return tempStr;
        }

        private void buttonStringPointResult_Click(object sender, System.EventArgs e)
        {
            string tempStr = textBoxStringInput.Text;
            unsafe
            {
                fixed (char* p = tempStr) tempStr = MyFixedTestSalve(p);
                this.textBoxStringResult.Text = tempStr;
                fixed (char* p = "xx") tempStr += MyFixedTestSalve(p);
                this.textBoxStringResult.Text = tempStr;
            }

        }

        //指针成员访问
        //先定义结构，然后访问
        struct Point
        {
            public int x;
            public int y;
            public override string ToString()
            {
                return "(" + x + "," + y + ")";
            }
        }

        private void buttonPointVisit_Click(object sender, System.EventArgs e)
        {
            //
            Point point;
            unsafe
            {
                Point* p = &point;
                p->x = 10;
                p->y = 20;
                this.textBoxStringResult.Text = "First visited format " + p->ToString();

                (*p).x = 10;
                (*p).y = 20;
                this.textBoxStringResult.Text += "\nSecond visited format" + (*p).ToString();
            }

        }

        private void buttonPointExchange_Click(object sender, System.EventArgs e)
        {
            //测试指针类型隐式/显式转换
            double d = 123.456e23;
            int j;
            unsafe
            {
                char c = 'A';
                char* pc = &c;
                void* pv = pc;
                int* pi = (int*)pv;
                int i = *pi;      // undefined
                *pi = 123456;      // undefined

                byte* pb = (byte*)&d;
                string MyStr = "";
                for (j = 0; j < sizeof(double); ++j)
                    //Console.Write("{0:X2} ", *pb++);
                    MyStr += *pb++;
                //Console.WriteLine();
                this.textBoxStringResult.Text = MyStr;
            }

        }
    }
}

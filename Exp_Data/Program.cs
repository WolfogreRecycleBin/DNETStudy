using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Exp_Data
{
    class WolfInt
    {
        public int value;
    };
    class Program
    {
        [DllImport("msvcrt.dll")]
        static extern bool system(string str);
        static void Main(string[] args)
        {
            Console.WriteLine("测试C#的数据操作：");
            TestReference();
            TestBoxing();
            TestUnsafeCode();
            TestMax();
            Console.WriteLine("测试C#的数据操作结束");
            system("pause");
        }

        static void TestReference()
        {
            Console.WriteLine("开始引用实验");
            {
                int i = 10;
                int j = i;
                Console.WriteLine("非引用j = i = 10;");
                Console.WriteLine("i = " + i + "; j = " + j);
                j++;
                Console.WriteLine("j++之后");
                Console.WriteLine("i = " + i + "; j = " + j);
            }
            {
                Object i = new Object();
                i = 10;
                Object j = i;
                Console.WriteLine("引用j = i = 10;");
                Console.WriteLine("i = " + i + "; j = " + j);
                j = 20;
                Console.WriteLine("j = 20之后");
                Console.WriteLine("i = " + i + "; j = " + j);
            }
            {

                WolfInt i = new WolfInt();
                i.value = 10;
                WolfInt j = i;
                Console.WriteLine("自定义引用j = i = 10;");
                Console.WriteLine("i = " + i.value + "; j = " + j.value);
                j.value = 20;
                Console.WriteLine("j = 20之后");
                Console.WriteLine("i = " + i.value + "; j = " + j.value);
            }

            Console.WriteLine("引用实验结束");
            system("pause");
        }

        static void TestUnsafeCode()
        {
            Console.WriteLine("开始不安全代码实验");
            //不安全代码只会在使用 /unsafe 编译的情况出现
            unsafe
            {
                int i = 10;
                int *p = &i;
                Console.WriteLine("输出p：" + (int)(p));
                Console.WriteLine("输出*p：" + *p);
            }
            Console.WriteLine("不安全代码实验结束");
            system("pause");
        }

        static void TestBoxing()
        {
            Console.WriteLine("开始装箱、拆箱实验");
            int i = 10;
            double d = 3.14;
            char c = 'X';
            Console.WriteLine("原始数据：");
            Console.WriteLine("整数：" + i);
            Console.WriteLine("实数：" + d);
            Console.WriteLine("字符：" + c);
            object ob_i = i;
            object ob_d = d;
            object ob_c = c;
            Console.WriteLine("装箱后显示：");
            Console.WriteLine("整数：" + ob_i);
            Console.WriteLine("实数：" + ob_d);
            Console.WriteLine("字符：" + ob_c);
            int new_i = (int) ob_i;
            double new_d = (double) ob_d;
            char new_c = (char) ob_c;
            Console.WriteLine("拆箱后显示：");
            Console.WriteLine("整数：" + new_i);
            Console.WriteLine("实数：" + new_d);
            Console.WriteLine("字符：" + new_c);
            Console.WriteLine("额外测试:");
            Console.WriteLine("将装箱的了整数改为20:");
            ob_i = 20;
            Console.WriteLine("装箱的整数：" + ob_i);
            Console.WriteLine("原始的整数：" + i);
            Console.WriteLine("原始的整数");
            Console.WriteLine("装箱、拆箱实验结束");
            system("pause");
        }

        static void TestMax()
        {
            Console.WriteLine("开始Max()实验");
            int i_a = 0;
            int i_b = 10;
            double d_a = 10.0;
            double d_b = 3.13;
            char c_a = 'A';
            char c_b = 'z';
            Console.WriteLine("int Max(" + i_a + "," + i_b + ") = " + Max(i_a, i_b));
            Console.WriteLine("double Max(" + d_a + "," + d_b + ") = " + Max(d_a, d_b));
            Console.WriteLine("char Max(" + c_a + "," + c_b + ") = " + Max(c_a, c_b));
            Console.WriteLine("Max()实验结束");
            system("pause");
        }
        static Object Max(Object a, Object b)
        {
            {
                int i_a = 0, i_b;
                if (i_a.GetType() == a.GetType())
                {
                    i_a = (int)a;
                    i_b = (int)b;
                    return i_a > i_b ? i_a : i_b;
                }
            }
            {
                double i_a = 0, i_b;
                if (i_a.GetType() == a.GetType())
                {
                    i_a = (double)a;
                    i_b = (double)b;
                    return i_a > i_b ? i_a : i_b;
                }
            }
            {
                char i_a = '0', i_b;
                if (i_a.GetType() == a.GetType())
                {
                    i_a = (char)a;
                    i_b = (char)b;
                    return i_a > i_b ? i_a : i_b;
                }
            }
            return null;
        }
    }
}

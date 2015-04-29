using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Exp_Data
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        static extern bool system(string str);
        static void Main(string[] args)
        {
            Console.WriteLine("测试C#的数据操作：");
            TestReference();
            TestBoxing();
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
                //TODO:与预期实验结果不同
            }
            {
                Int32 i = new Int32();
                i = 10;
                Int32 j = i;
                Console.WriteLine("引用j = i = 10;");
                Console.WriteLine("i = " + i + "; j = " + j);
                j++;
                Console.WriteLine("j++之后");
                Console.WriteLine("i = " + i + "; j = " + j);
            }


            Console.WriteLine("引用实验结束");
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


    }
}

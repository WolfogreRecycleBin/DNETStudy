using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exp_Thread
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("程序开始！");
			线程创造者 a = new 线程创造者();
			a.创造线程();
			Thread t = new Thread(new ThreadStart(a.不死线程));
			System.Console.WriteLine("程序退出！");
			return;
		}
	}
	class 线程创造者
	{
		Thread t;
		public 线程创造者()
		{
			System.Console.WriteLine("线程创造者被创建！");
		}
		~线程创造者()  
		{
			t.Abort();
			System.Console.WriteLine("线程创造者被析构！"); 
		}
		public void 创造线程()
		{
			System.Console.WriteLine("不死线程被创建！");
			t = new Thread(new ThreadStart(不死线程));
			t.Start();
		}
		public void 不死线程()
		{
			int left = 0 ;
			while(true)
			{
				System.Console.WriteLine("我是不死线程！我存活" + ++left +"秒了!");
				System.Threading.Thread.Sleep(1000);
				if(left >= 8)
				{
					System.Console.WriteLine("我是不死线程！不好玩，我自杀了！");
					return;
				}
					
			}
		}
	}
}

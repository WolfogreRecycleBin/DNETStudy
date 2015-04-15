using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace mcaoWindowsFormsApplicationForCSharp
{
	/// <summary>
	/// MymcaoException 的摘要说明。
	/// </summary>
	public class MymcaoException : ApplicationException 
	{
		public MymcaoException()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public MymcaoException (string messageStr) : base (messageStr)
		{
			
		}

		public MymcaoException (string messageStr, Exception inner) : base(messageStr, inner)
		{
			
		}

		public void SendMessage( string str)
		{
			MessageBox.Show(str);
		}
	} // end of cla  

	public class ExAssert 
	{
		public static void MyAssert(bool cond, string message, Exception e)
		{
			if (!cond) 
			{
				MessageBox.Show(message);
				throw e;
			}
		}
	}
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using mcaoWindowsFormsApplicationForCSharp;

namespace 用户自定义控件
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UserDefineControlForm udcf = new UserDefineControlForm();
			udcf.Show();
		}
	}
}

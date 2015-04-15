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
    public partial class UserDefineSyntaxForm : Form
    {
        public UserDefineSyntaxForm()
        {
            InitializeComponent();
        }

        private void buttonGenenal_Click(object sender, System.EventArgs e)
        {
            string strTemp = textBoxNumber.Text;
            int x = int.Parse(strTemp);
            strTemp = textBoxDivision.Text;
            int y = int.Parse(strTemp);
            int z = (int)x / y;
            textBoxResult.Text = z.ToString();
        }

        private void buttonException_Click(object sender, System.EventArgs e)
        {
            try
            {
                string strTemp = textBoxNumber.Text;
                int x = int.Parse(strTemp);
                strTemp = textBoxDivision.Text;
                int y = int.Parse(strTemp);
                int z = (int)x / y;
                textBoxResult.Text = z.ToString();
            }
            catch (DivideByZeroException de)
            {
                MessageBox.Show(de.ToString());
            }
            catch (FormatException se)
            {
                MessageBox.Show(se.ToString());
            }
            //
        }

        private void buttonUnsafeTest_Click(object sender, System.EventArgs e)
        {
            UserDefineSyntaxContinueForm MyUnsafeRestForm = new UserDefineSyntaxContinueForm();
            MyUnsafeRestForm.ShowDialog(this);
        }

        public void MyThrowExceptionTest()
        {
            string strTemp = this.textBoxInputmcao.Text;
            if (strTemp.Equals("mcao") == true)
                throw (new ArgumentNullException());
            MessageBox.Show(strTemp);
        }

        private void buttonThrowmcao_Click(object sender, System.EventArgs e)
        {

            try
            {
                MyThrowExceptionTest();
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.ToString() + "  ::" + ae.Message);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString() + "  ::" + ee.Message);
            }
            finally
            {
                MessageBox.Show("Though you throw a System.ArgumentNullException, I am still mcao!");
            }
        }

        //测试异常嵌套以及Exception的属性
        public void MyThrowExceptionLayer1()
        {
            MyThrowExceptionLayer2();
        }
        public void MyThrowExceptionLayer2()
        {
            MyThrowExceptionLayer3();
        }
        public void MyThrowExceptionLayer3()
        {
            try
            {
                MyThrowExceptionTest();
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.ToString() + "  ::" + ae.Message);
                throw new Exception("我就是想输入mcao，你已经套了三层了", ae);
            }
        }

        private void buttonExceptionResult_Click(object sender, System.EventArgs e)
        {
            //
            try
            {
                MyThrowExceptionLayer1();
            }
            catch (Exception ge)
            {
                MessageBox.Show("异常类型：" + ge.ToString());
                MessageBox.Show("异常message：" + ge.Message);
                MessageBox.Show("异常StackTrace：" + ge.StackTrace);
                MessageBox.Show("异常InnerException：" + ge.InnerException);
                MessageBox.Show("异常TargetSite：" + ge.TargetSite);
                MessageBox.Show("异常Source：" + ge.Source);
                MessageBox.Show("异常HelpLink：" + ge.HelpLink);
            }
        }

        //测试自定义的异常类
        public void MyDefinedExceptionTest()
        {
            string strTemp = this.textBoxInputmcao.Text;
            if (strTemp.Equals("mcao") == true)
                throw (new MymcaoException());
            if (strTemp.Equals("cm") == true)
                throw (new MymcaoException("我就是不让你输入mcao或者cm，你能怎么样。"));
            if (strTemp.Equals("jlqiu") == true)
                throw (new MymcaoException("我就是不让你输入mcao或者jlqiu，你能怎么样。", new OverflowException()));
            MessageBox.Show(strTemp);
        }

        private void buttonUserdefinedException_Click(object sender, System.EventArgs e)
        {
            //自定义异常类1
            try
            {
                MyDefinedExceptionTest();
            }
            catch (MymcaoException mcaoe)
            {
                textBoxUserDefinedExceptionResult.Text = mcaoe.Message + " Ha, ha:" + mcaoe.ToString();
                mcaoe.SendMessage("我就是不让你输入mcao，你能怎么样。");
            }
        }

        private void buttonUserdefinedException2_Click(object sender, System.EventArgs e)
        {
            //自定义异常类2
            try
            {
                MyDefinedExceptionTest();
            }
            catch (MymcaoException mcaoe)
            {
                textBoxUserDefinedExceptionResult.Text = mcaoe.Message + "\n Ha, ha:" + mcaoe.ToString();
            }
        }

        private void buttonUserdefinedException3_Click(object sender, System.EventArgs e)
        {
            //自定义异常类2
            try
            {
                MyDefinedExceptionTest();
            }
            catch (MymcaoException mcaoe)
            {
                textBoxUserDefinedExceptionResult.Text = mcaoe.Message;
                textBoxUserDefinedExceptionResult.Text += "\n";
                textBoxUserDefinedExceptionResult.Text += mcaoe.InnerException;

            }
        }

        //checked 
        private void buttonChecked_Click(object sender, System.EventArgs e)
        {
            try
            {
                int i = int.Parse(textBoxInt1.Text);
                int j = int.Parse(textBoxInt2.Text);
                int k;
                checked
                {
                    k = i * j;
                }
                textBoxCheckResult.Text = k.ToString();
            }
            catch (OverflowException oe)
            {
                textBoxCheckResult.Text = oe.Message;
            }
            catch (System.FormatException fe)
            {
                textBoxCheckResult.Text = fe.Message;
            }
        }

        //unchecked
        private void buttonUnchecked_Click(object sender, System.EventArgs e)
        {
            try
            {
                int i = int.Parse(textBoxInt1.Text);
                int j = int.Parse(textBoxInt2.Text);
                int k = 0;
                unchecked
                {
                    k = i * j;
                }
                textBoxCheckResult.Text = k.ToString();
            }
            catch (OverflowException oe)
            {
                textBoxCheckResult.Text = oe.Message;
            }
            catch (System.FormatException fe)
            {
                textBoxCheckResult.Text = fe.Message;
            }
        }

        private void buttonUndefine_Click(object sender, System.EventArgs e)
        {
            try
            {
                int i = int.Parse(textBoxInt1.Text);
                int j = int.Parse(textBoxInt2.Text);
                int k = i * j;
                textBoxCheckResult.Text = k.ToString();
            }
            catch (OverflowException oe)
            {
                textBoxCheckResult.Text = oe.Message;
            }
            catch (System.FormatException fe)
            {
                textBoxCheckResult.Text = fe.Message;
            }
        }

        private void buttonAssert_Click(object sender, System.EventArgs e)
        {
            //调用自定义断言
            string strTemp = this.textBoxInputmcao.Text;
            try
            {
                ExAssert.MyAssert((strTemp.Equals("mcao") == false), "Assert--仍然不允许你输入mcao", new Exception());
                textBoxCheckResult.Text = strTemp;
            }
            catch (Exception ee)
            {
                strTemp = ee.ToString();
                strTemp += "\n" + ee.Message;
                strTemp += "这一次我使用断言，但我还是不让你输入mcao，你能怎样？";
                MessageBox.Show(strTemp);
            }
        }
    }
}

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
    public partial class EveryKindOfControlForm : Form
    {
        public EveryKindOfControlForm()
        {
            InitializeComponent();
        }

        //Part 1: About ListBox
        //如何添加字符串到liastBox中
        private void PrevT_Click(object sender, System.EventArgs e)
        {
            if (TID.Text != "")
            {
                listBox2.Items.Add(TID.Text);
            }
            else
            {
                MessageBox.Show("Please input the No!");
            }
        }

        //如何删除liastBox中选中的字符串
        private void TNext_Click(object sender, System.EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            // Delete All
            //listBox2.Items.Clear ();
        }

        // 如何知道所选择的结果
        private void button3_Click(object sender, System.EventArgs e)
        {
            string str = "目前你的选择是第：";
            int CurrentIndex = listBox2.SelectedIndex + 1;
            str += CurrentIndex.ToString();
            str += " 项";

            MessageBox.Show(str);
        }

        //Part 2: ComboBox Test
        //How to add string to the combobox
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (MulQuery.FindString("有教授参与授课的所有课程") < 0)
            {
                MulQuery.BeginUpdate();
                MulQuery.Items.Add("有教授参与授课的所有课程");
                MulQuery.Items.Add("有副教授参与授课的所有课程");
                MulQuery.Items.Add("所有选择教授所授课程的学生");
                MulQuery.Items.Add("王心怡老师的所有学生");
                MulQuery.Items.Add("所有有课程冲突的学生");
                MulQuery.EndUpdate();
            }
            if (MulQuery.FindString(MulQuery.Text) < 0)
            {
                MulQuery.BeginUpdate();
                MulQuery.Items.Add(MulQuery.Text);
                MulQuery.EndUpdate();
            }
            else
                MessageBox.Show(MulQuery.Text + "已经存在");
        }

        // how to know which text you choice or edit
        private void button1_Click(object sender, System.EventArgs e)
        {
            int FindIndex;
            string strMsg = "目前你的选择是：";
            FindIndex = MulQuery.FindStringExact(MulQuery.Text);
            if (FindIndex < 0)
            {
                MulQuery.Items.Add(MulQuery.Text);
                strMsg += MulQuery.Text;
            }
            else
            {
                strMsg += MulQuery.SelectedItem.ToString();
            }

            MessageBox.Show(strMsg);
        }

        // Part 3:测试园按钮  如何知道单选一的按钮目前选中的是哪一个
        private void OledbB_CheckedChanged(object sender, System.EventArgs e)
        {
            if (OledbB.Checked)
            {
                MessageBox.Show("你目前选中的是Oledb供应程序");
            }
        }

        private void SqlB_CheckedChanged(object sender, System.EventArgs e)
        {
            if (SqlB.Checked)
            {
                MessageBox.Show("你目前选中的是Sql供应程序");
            }
        }

        //part 4: 测试checked按钮
        private void chkDisableMax_CheckedChanged(object sender, System.EventArgs e)
        {
            this.MaximizeBox = chkDisableMax.Checked;
        }

        //在任务栏中显示，和NotifyIcon的作用矛盾
        private void chkDisableShow_CheckedChanged(object sender, System.EventArgs e)
        {
            this.ShowInTaskbar = chkDisableShow.Checked;
        }

        // Part 5:  测试菜单
        //测试菜单项被选中
        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        // Part 6: 测试状态条，在鼠标移动时，将当前的鼠标位置显示在状态条中
        //同时测试Timertick，显示当前时间，并且用于测试进度条
        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            string strCurrentPosition = "当前鼠标位置为：" + e.X.ToString() + "," + e.Y.ToString();
            statusBarPanel1.Text = strCurrentPosition;
        }

        //设置timer，第一用于测试状态条，每秒钟变换一次时间，显示在状态条中
        //第二，用于控制processBar的显示和速度控制
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            //第一个用途：每秒钟变换一次时间，显示在状态条中
            statusBarPanel2.Text = DateTime.Now.ToString();

            //第二个用途：控制和显示进度条的当前状态
            int nFinishedPercent;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                progressBar1.PerformStep();
            }
            nFinishedPercent = 100 * (progressBar1.Value - progressBar1.Minimum)
                / (progressBar1.Maximum - progressBar1.Minimum);
            MyProcessBarPersent.Text = Convert.ToInt16(nFinishedPercent).ToString() + "%";

            //通过以下方式可以改变时间间隔量，目前的属性是每秒钟（1000ms）变化
            //timer1.Interval = Convert.ToInt16 (1000 / SpeedYouSelected) 
        }

        //测试进度条时的附带动作，单击在停止和启动时间timer1之间变换
        private void StopProcessBar_Click(object sender, System.EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                StopProcessBar.Text = "开始";
            }
            else
            {
                timer1.Enabled = true;
                StopProcessBar.Text = "停止";
            }
        }

        // Part 7: 测试工具条， 按下工具条按钮，效果等同于选择对应菜单项
        //同时测试imagelist的使用方法
        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            //if (e.Button.Equals((object)toolBarFileExit))
            //this.menuItem2_Click(sender, e);
            switch (e.Button.ImageIndex)
            {
                case 0:
                    this.Close();
                    break;
            }
        }

        // part 8: 测试linkedLabel

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text.Substring(2, 16));
            //MessageBox.Show("You'd like to email to: "+linkLabel1.Text.Substring(2,16));			
            //linkLabel1.Links.Add(2, 15, "www.tsinghua.edu.cn");	
            //MessageBox.Show(e.Link.LinkData.ToString());
            linkLabel1.LinkVisited = true;
            //System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            //System.Diagnostics.Process.Start("www.tsinghua.edu.cn");
        }

        // Part 9：测试CheckedListBox，注意与一般ListBox的区别--同时选中多项
        //添加一项到CheckedListBox中
        private void button4_Click(object sender, System.EventArgs e)
        {
            if (textBox2.Text.Trim() != "")
            {
                if (checkedListBox1.FindString(textBox2.Text) < 0)
                {
                    checkedListBox1.Items.Add(textBox2.Text);
                    textBox2.Text = "";
                }
                else
                    MessageBox.Show(textBox2.Text + "已经存在");
            }
            else
            {
                MessageBox.Show("你什么也不输入，我怎么添加啊?\n请在左面的文本框中输入一个字符串！");
            }
        }

        //显示你目前所选中--不仅仅是所选择--的项目
        private void button6_Click(object sender, System.EventArgs e)
        {
            //string SelectedValues="目前你选中的值包括：\n";
            string SelectedValues = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                SelectedValues += checkedListBox1.CheckedItems[i].ToString() + "\n";
            }
            if (SelectedValues.Trim() != "")
            {
                SelectedValues = "目前你选中的值包括：\n" + SelectedValues;
                MessageBox.Show(SelectedValues);
            }
            else
                MessageBox.Show("目前你什么也没有选中");
        }

        //从CheckedListBox中删除所选择而不是选中的一项
        private void button5_Click(object sender, System.EventArgs e)
        {
            if (checkedListBox1.SelectedIndex < 0)
                MessageBox.Show("目前你什么也没有选则，我怎么删除啊?");
            else
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        // Part 10: 测试tabControl
        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                MessageBox.Show("你现在查看的是我的属性");
            else
                MessageBox.Show("你现在查看的是我的外观");
        }

        // Part 11：测试dateTimePicker的使用方法
        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            string strCurrentDay = "你现在选中" + dateTimePicker1.Text;
            //MessageBox.Show(strCurrentDay);
            groupBox6.Text = strCurrentDay;
        }

        // Part 12：测试pictureBox如何显示图片，顺带测试如何调用“打开文件”对话框
        //同时测试水平和垂直滚动条的用法，他们分别在水平和垂直方向上滚动所显示的图片
        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            //
            // 打开目录对话框，选中图片文件
            OpenFileDialog fodlg = new OpenFileDialog();
            fodlg.Title = "选择图片";
            fodlg.InitialDirectory = "";
            // 文件过滤类型
            fodlg.Filter = "All files (*.*)|*.*|Image files (*.jpg, *.bmp, *.gif)|*.jpg; *.bmp; *.gif";
            // 缺省过滤文件类型
            fodlg.FilterIndex = 1;
            if (fodlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fodlg.FileName);
                //pictureBox1.Image.Size
                pictureBox1.Size = pictureBox1.Image.Size;
                hPictureScrollBar.Maximum = pictureBox1.Width - panelPicture.Width + vPictureScrollBar.Width;
                vPictureScrollBar.Maximum = pictureBox1.Height - panelPicture.Height + hPictureScrollBar.Height;
                pictureBox1.Left = pictureBox1.Top = 0;
                hPictureScrollBar.Value = vPictureScrollBar.Value = 0;
                hPictureScrollBar.Update();
            }
        }

        //垂直方向上滚动显示图片
        private void vPictureScrollBar_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            pictureBox1.Top = 0 - vPictureScrollBar.Value;
        }

        //水平方向上滚动显示图片
        private void hPictureScrollBar_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            pictureBox1.Left = 0 - hPictureScrollBar.Value;
        }

        // Part 13: 测试TRackBar，同时测试ScrollBar
        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            //hScrollBar1.Maximum = trackBar1.Maximum;
            //hScrollBar1.Value = trackBar1.Value;
            hScrollBar1.Value = trackBar1.Value * 10;
        }

        //Part 14: 测试TreeView，如何知道目前的选择

        private void treeView1_DoubleClick(object sender, System.EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            MessageBox.Show("目前你的选择是：" + treeView1.SelectedNode.ToString());
        }

        //Part 15:  测试NotifyIcon, 其作用是在任务栏中显示一个图标，表示目前的应用
        private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        //Part 16: 测试各种系统定义的对话框，并显示用户的选择
        //1：打开文件
        private void OpenLabel_Click(object sender, System.EventArgs e)
        {
            if (MyOenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.Text = "你选择打开的文件是\n" + MyOenFileDialog.FileName;
            }
        }

        //2：保存文件
        private void SaveLabel_Click(object sender, System.EventArgs e)
        {
            MySaveFileDialog.Filter = this.MyOenFileDialog.Filter;
            MySaveFileDialog.CreatePrompt = true;
            MySaveFileDialog.OverwritePrompt = true;
            MySaveFileDialog.RestoreDirectory = true;

            if (MySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.Text = "你要保存的文件为\n" + MySaveFileDialog.FileName;
            }
        }

        //3：浏览文件夹
        private void BrowseLabel_Click(object sender, System.EventArgs e)
        {
            if (MyFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.Text = "你的选择是：" + MyFolderBrowserDialog.SelectedPath;
            }
        }

        //4：字体对话框
        private void FontLabel_Click(object sender, System.EventArgs e)
        {
            MyFontDialog.Font = ResultLabel.Font;
            MyFontDialog.ShowApply = true;
            MyFontDialog.ShowEffects = true;

            if (MyFontDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.Font = MyFontDialog.Font;
            }
        }

        //5：颜色选择对话框
        private void ColorLabel_Click(object sender, System.EventArgs e)
        {
            if (MyColorDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.BackColor = MyColorDialog.Color;
            }
        }

        //6：打印对话框，没有MyPageSetupDialog.Document之类的对象，不能打开
        private void PrintLabel_Click(object sender, System.EventArgs e)
        {
            MyPrintDialog.Document = MyPrintDocument;
            if (MyPrintDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.Text = "你选择的打印机是：" + MyPrintDialog.PrinterSettings.PrinterName;
            }
        }

        //7：页面设置对话框，没有MyPageSetupDialog.Document之类的对象，不能打开
        private void SetupLabel_Click(object sender, System.EventArgs e)
        {
            MyPageSetupDialog.Document = MyPrintDocument;
            //MyPageSetupDialog.PageSettings.PaperSize = 

            if (MyPageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                ResultLabel.Text = "你选择的纸型为：" + MyPageSetupDialog.PageSettings.PaperSize.ToString();
            }
        }

        //8：打印预览对话框，有PrintPreviewDialog.Document，则显示空文档，否则，
        //报告目前没有任何文档可以预览
        private void PrintViewLabel_Click(object sender, System.EventArgs e)
        {
            MyPrintPreviewDialog.Document = MyPrintDocument;
            MyPrintPreviewDialog.ShowDialog();
        }
    }
}

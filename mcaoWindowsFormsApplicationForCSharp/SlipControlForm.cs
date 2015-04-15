using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mcaoWindowsFormsApplicationForCSharp
{
    public partial class SlipControlForm : Form
    {
        public SlipControlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void EnumDrives(TreeNode ParentNode)
        {
            if (ParentNode.Nodes.Count == 0)
            {
                foreach (string drive in Directory.GetLogicalDrives())
                {
                    treeView1.SelectedNode = ParentNode;
                    TreeNode TempNode = new TreeNode();
                    TempNode.Text = drive.Substring(0, drive.Length - 1);
                    TempNode.Tag = drive;
                    TempNode.ImageIndex = 1;
                    TempNode.SelectedImageIndex = 1;
                    treeView1.SelectedNode.Nodes.Add(TempNode);
                    treeView1.SelectedNode.Nodes[treeView1.SelectedNode.Nodes.Count - 1].EnsureVisible();
                }
            }
        }

        private void EnumDirectories(TreeNode ParentNode)
        {
            treeView1.SelectedNode = ParentNode;
            string DirectoryPath = ParentNode.Tag.ToString();
            if (ParentNode.Nodes.Count == 0)
            {
                if (DirectoryPath.Substring(DirectoryPath.Length - 1) != @"\")
                    DirectoryPath += @"\";
                try
                {
                    foreach (string directory in Directory.GetDirectories(DirectoryPath))
                    {
                        TreeNode TempNode = new TreeNode();
                        TempNode.Text = directory.Substring(directory.LastIndexOf(@"\") + 1);
                        TempNode.Tag = directory;
                        TempNode.ImageIndex = 3;
                        TempNode.SelectedImageIndex = 2;
                        treeView1.SelectedNode.Nodes.Add(TempNode);
                        treeView1.SelectedNode.Nodes[treeView1.SelectedNode.Nodes.Count - 1].EnsureVisible();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (e.Node.Text.ToString() != "我的电脑")
                EnumDirectories(e.Node);
            else
                EnumDrives(e.Node);
        }

        //加载窗体时，检查C:\\盘上的所有文件和文件夹，以图标的方式显示在ListView中
        private void ControlsForm_Load(object sender, System.EventArgs e)
        {
            foreach (string dirName in Directory.GetDirectories(@"C:\"))
            {
                ListViewItem aItem = new ListViewItem(dirName, 0);
                aItem.ImageIndex = 0;
                string dirInfo;
                dirInfo = File.GetAttributes(dirName).ToString();
                aItem.SubItems.Add(dirInfo);
                dirInfo = File.GetLastAccessTime(dirName).ToString();
                aItem.SubItems.Add(dirInfo);
                aItem.SubItems.Add("目录");
                listView1.Items.Add(aItem);
            }
            foreach (string fileName in Directory.GetFiles(@"C:\"))
            {
                ListViewItem aItem = new ListViewItem(fileName, 0);
                aItem.ImageIndex = 1;
                string fileInfo;
                fileInfo = File.GetAttributes(fileName).ToString();
                aItem.SubItems.Add(fileInfo);
                fileInfo = File.GetLastAccessTime(fileName).ToString();
                aItem.SubItems.Add(fileInfo);
                aItem.SubItems.Add("文件");
                listView1.Items.Add(aItem);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Event
{
    public delegate void CheckBeast(object sender);
    class Check : EventArgs
    {
        public event CheckBeast FindWolf;
        public Check()
        {
            FindWolf = new CheckBeast(Alert);
            FindWolf += new CheckBeast(Run);
            FindWolf += new CheckBeast(跑);
        }
        public void MakeItOccur()
        {
            FindWolf(this);
        }
        public void Alert(object sender)
        {
            MessageBox.Show("Wolf is comming!");
        }
        public void Run(object sender)
        {
            MessageBox.Show("Run!!!");
        }
        public void 跑(object sender)
        {
            MessageBox.Show("你听不懂英文吗？跑!!!");
        }
    }
}

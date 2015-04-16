using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Event
{
    public delegate void CheckBeast(object sender);
    class Check
    {
        public event CheckBeast FindWolf;
        public Check()
        {
            FindWolf = new CheckBeast(Alert);
            FindWolf += new CheckBeast(Run);
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
    }
}

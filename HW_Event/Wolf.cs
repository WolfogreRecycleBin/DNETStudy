using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Event
{
    public class WolfComing : EventArgs
    {  
    }
    public delegate void CheckBeast(object sender, WolfComing e);
    class Check
    {
        public event CheckBeast FindWolf;
        public Check()
        {
            FindWolf = new CheckBeast(Alert);
            FindWolf += new CheckBeast(Run);
        }
        public void MakeItOccur(WolfComing e)
        {
            FindWolf(this, e);
        }
        public void Alert(object sender, WolfComing e)
        {
            MessageBox.Show("Wolf is comming!");
        }
        public void Run(object sender, WolfComing e)
        {
            MessageBox.Show("Run!!!");
        }
    }
}

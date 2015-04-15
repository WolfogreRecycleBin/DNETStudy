using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Event
{
    public class WolfComing : EventArgs
    {
        string alem = "Wolf is coming!";
    }
    public delegate void CheckInputEventHandle(object sender, WolfComing e);
    class CheckBeast //定义事件类【包含事件触发、事件处理】--开始
    {
        public event CheckInputEventHandle MyEvent;//事件
        public CheckInputEventHandle MyDelegate; //委托
        public string cause;
        public string result;

        public CheckBeast() //构造函数
        {
            cause = "";
            result = "";

            MyDelegate = new CheckInputEventHandle(EventProcess);   //构造指代【委托】
            MyDelegate += new CheckInputEventHandle(EventAdd);      //指代【委托】多播【组合】

            MyEvent += MyDelegate;   //事件注册
        }

        public void MakeItOccur(CheckBeast e) //事件触发
        {
            if (e.position.Equals("她不想上课") == true)
                MyEvent(this, e);
        }

        public void EventProcess(object sender, WolfComing e)
        {

        }

        public void EventAdd(object sender, WolfComing e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    class CallBackClass:ICallBack
    {
        public void run()
        {
            // 输出系统当前时间
            System.Console.WriteLine(DateTime.Now);
        }
    }
}

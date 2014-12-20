using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    class Controller
    {
        // 回调对象
        private List<ICallBack> CallBackObjects = new List<ICallBack>();

        public void AddCallBack(ICallBack callback)
        {
            CallBackObjects.Add(callback);
        }

        public void Begin()
        {
            Console.WriteLine("敲任意键演示回调功能，ESC键退出...");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                foreach (ICallBack obj in CallBackObjects)
                    obj.run();
            }
        }
    }
}

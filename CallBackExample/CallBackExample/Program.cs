using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建控制器对象，将提供给它的回调 对象传入
            Controller controller = new Controller();
            controller.AddCallBack(new CallBackClass());
            controller.AddCallBack(new CallBackClass2());
            // 启动控制器对象运行
            controller.Begin();
        }
    }
}

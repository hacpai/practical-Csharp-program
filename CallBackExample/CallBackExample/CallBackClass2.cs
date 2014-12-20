using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackExample
{
    class CallBackClass2:ICallBack
    {
        private int count = 0;
        public void run()
        {
            #region ICallBack 成员
            count++;

            System.Media.SystemSounds.Asterisk.Play();
            Console.WriteLine("I'm invoked " + count.ToString() + " times");
            #endregion
        }
    }
}

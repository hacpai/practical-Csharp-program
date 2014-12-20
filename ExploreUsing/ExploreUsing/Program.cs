using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyClass obj = new MyClass())
            {
                Console.WriteLine("Using MyClass Object");
            }
        }
    }

    class MyClass:IDisposable
    {
        ~MyClass()
        {
            Dispose();
        }
        public void Dispose()
        {


        }
    }
}

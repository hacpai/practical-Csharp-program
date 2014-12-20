using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowPolymorphism();
            CallPolymorphismMethod();
            Console.ReadKey();
        }
        static void ShowPolymorphism()
        {
            Fruit f;
            f = new Apple();
            // 这句输出什么？
            f.GrowInArea();

            f = new Pineapple();
            // 相同的代码输出什么?
            f.GrowInArea();
        }
        // 使用多态特性的方法，其代码具有稳定性，与其子类无关
        static void PloymorphismMethod(Fruit fruit)
        {
            fruit.GrowInArea();
        }
        // 多态代码典型用法：
        // 在运行时动态地传递对象给它
        static void CallPolymorphismMethod()
        {
            PloymorphismMethod(new Apple());
            PloymorphismMethod(new Pineapple());
        }
        // 抽象类
        abstract class Fruit
        {
            // 抽象方法
            public abstract void GrowInArea();
        }
        class Apple : Fruit
        {
            public override void GrowInArea()
            {
                Console.WriteLine("我是苹果，南方北方都可以种植我。");
            }
        }
        class Pineapple : Fruit
        {
            public override void GrowInArea()
            {
                Console.WriteLine("我是菠萝，喜欢温暖，只能在南方看到我。");
            }

        }
    }
}

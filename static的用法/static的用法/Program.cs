/*
 * 本例子检测static定义的变量到底是不是可变的
 * static 定义的静态不是不变的静态
 * 是static定义的变量保持唯一，不管外部类有多少个声明，都是在同一个static变量的基础上进行操作的
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticVar sv = new static的用法.StaticVar();
            StaticVar sv2 = new StaticVar();
            sv.setValue(10);
            sv.count();
            sv.count();
            Console.WriteLine("{0}", sv.getValue());
            sv2.count();
            sv2.count();
            Console.WriteLine("{0}", sv.getValue());
            Console.ReadKey();
        }
    }
    class StaticVar
    {
        private static int i;
        public void setValue(int j)
        {
            i = j;
        }
        public int getValue()
        {
           return i;
        }
        public void count()
        {
            i++;
        }
    }
}

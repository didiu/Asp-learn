/*
 * 函数递归的实现
 *    函数调用自身实现递归
 *    
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digui
{
    class Program
    {
        //递归函数
        public int factorial(int num)
        {
            int result;

            if (num==1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Program pg = new digui.Program();
            while (true)
            {
                int str=Int32.Parse( Console.ReadLine());
                Console.WriteLine("**  的阶乘是：{0}", pg.factorial(str));
            }
        }
    }
}

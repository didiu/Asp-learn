/*
 * 结构体和枚举例子
 * 结构体是可以存储字段,函数,方法.
 * 和类差不多区别如下:
 *          类是引用类型,结构体是值类型
 *          结构体不支持继承
 *          结构不能声明默认的构造函数
 * 枚举
 *          值数据类型,不能被继承或者传递继承
 *          可以用来自定义数据类型
 *          枚举是指将变量所有的可能性都列举出来,变量的取值只限于列举出来的变量
 *          1:运行时是常量,可以作为case的条件
 *          2:枚举值可以指定对应的整数数据类型
 *          3:所有的枚举都隐式的继承System.Enum抽象类
 *          4：枚举值赋值的时候需要避免循环引用的情况
 *          5：枚举值可以转换成整数
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAndenum
{
    class Program
    {
        struct book
        {
            private string name;
            private int id;
            private string type;

            public void getValue(string n,int i,string t)
            {
                name = n;
                id = i;
                type = t;
            }

            public void show()
            {
                Console.WriteLine(name+" "+id+" "+type);
            }
        }

        enum week
        {
            Sun,Mon,Tue,Wed,Thu,Fri,Sat
        }

        static void Main(string[] args)
        {
            book bk1 = new book();
            bk1.getValue("Hello C#", 12580, "teachnology");
            bk1.show();
            Console.WriteLine(week.Sat);
            Console.ReadKey();
        }
    }
}

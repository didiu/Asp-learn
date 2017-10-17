using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义异常处理
{

    #region 自定义的异常类
    public class IsZeroException :ApplicationException
    {
        public IsZeroException(string message):base(message)
        {

        }
    }
    #endregion

    #region 实现类
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw (new IsZeroException("Zero Temperature found"));
            }
            catch (IsZeroException e)
            {
                Console.WriteLine("IsZeroException:{0}", e.Message);
            }
            Console.ReadKey();
        }
    }
    #endregion
}

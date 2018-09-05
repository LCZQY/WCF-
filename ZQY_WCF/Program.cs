using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ZQY_WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            //shiyt
            ServiceHost host = new ServiceHost(typeof(MyFirstService)); //MyFirstService： 实现接口的类
            host.Open();
            Console.WriteLine("服务已经打开....");
            Console.ReadKey();           

        }
    }
}

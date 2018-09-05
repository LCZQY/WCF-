using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //调用该服务的接口程序
            zqy_ServiceReference.MyFirstServiceClient client = new zqy_ServiceReference.MyFirstServiceClient();
             string str= client.DoWork("郑强勇");
            Console.WriteLine(str);

        }
    }
}

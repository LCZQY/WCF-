using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZQY_WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“MyFirstService”。
    public class MyFirstService : IMyFirstService
    {
        public string DoWork(string name)
        {
            return $"您好,{name} 我是你的第一个WCF程序哦！";
        }
    }
}

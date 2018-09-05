using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ZQY_WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IMyFirstService”。
    [ServiceContract]
    public interface IMyFirstService
    {
        //必须在接口方法中，申明特性，才能够被WCF识别
        [OperationContract]
        string DoWork(string Name);
    }
}

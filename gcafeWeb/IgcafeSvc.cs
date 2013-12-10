﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace gcafeWeb
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IgcafeSvc”。
    [ServiceContract]
    public interface IgcafeSvc
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Order> GetOrders();

        [OperationContract]
        List<MenuItem> GetMenu();
    }

}

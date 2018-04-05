using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WS_RS_VelibLabServices
{
    interface IVelibLabServicesEvents
    {
        [OperationContract(IsOneWay = true)]
        void NewNumberAvailable();
    }
}

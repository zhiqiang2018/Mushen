using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Mushen.Fuwen
{
    public class ToolSet
    {
    }

    public enum eDataType
    {
        Unkonwn=0,
        MySQL=1,
        SQLServer=2,
        Oracle=3,
        CSV=4,
        Excel03=5,
        Excel07=6,
        PDF=7,
        Log=8
    }

    [ServiceContract]
    public interface ITiandi
    {
        [OperationContract]
        bool IsLive();
    }
}

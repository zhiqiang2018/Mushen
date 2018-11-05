using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Mushen.Fuwen;

namespace Mushen.Gushen
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Tiandi : ITiandi
    {
        public const string Address = "Tiandi";
        private const string traceLog = "Tiandi.Log";

        public Tiandi()
        {

        }

        public bool IsLive()
        {
            return true;
        }
    }
}

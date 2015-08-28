using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Mobao.M.Service
{
    public class CallContextInitializer : ICallContextInitializer
    {
        public void AfterInvoke(object correlationState)
        {

        }

        public object BeforeInvoke(System.ServiceModel.InstanceContext instanceContext, System.ServiceModel.IClientChannel channel, System.ServiceModel.Channels.Message message)
        {
            //权限
            string name = message.Headers.GetHeader<string>("identityUser","localhost");
            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Mobao.M.Service
{
    public class InstanceContextProvider : IInstanceContextProvider
    {
        string sessionId = string.Empty;
        public System.ServiceModel.InstanceContext GetExistingInstanceContext(System.ServiceModel.Channels.Message message,
            System.ServiceModel.IContextChannel channel)
        {
            return null;
        }

        public void InitializeInstanceContext(System.ServiceModel.InstanceContext instanceContext, 
            System.ServiceModel.Channels.Message message, System.ServiceModel.IContextChannel channel)
        {

        }

        public bool IsIdle(System.ServiceModel.InstanceContext instanceContext)
        {
            return false;
        }

        public void NotifyIdle(InstanceContextIdleCallback callback, System.ServiceModel.InstanceContext instanceContext)
        {

        }
    }
}
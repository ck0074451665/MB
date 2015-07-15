using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mobao.M.Service
{
    public class MessageInspector : System.ServiceModel.Dispatcher.IDispatchMessageInspector 
    {
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request,
            System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            return "666";
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, 
            object correlationState)
        {
           
        }
    }
}
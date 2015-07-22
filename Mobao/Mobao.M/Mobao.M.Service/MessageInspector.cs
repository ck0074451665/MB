using log4net;
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
            Mobao.M.Utility.LogHelper.Instance.Info("开始处理");
            return "";
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply,
            object correlationState)
        {
            Mobao.M.Utility.LogHelper.Instance.Info("处理完毕");
        }
    }
}
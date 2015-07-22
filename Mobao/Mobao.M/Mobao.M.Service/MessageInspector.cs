using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Mobao.M.Service
{
    public class MessageInspector : System.ServiceModel.Dispatcher.IDispatchMessageInspector
    {

        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request,
            System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            System.Threading.Thread.Sleep(3000);
           
            Mobao.M.Utility.LogHelper.Instance.Info(instanceContext.GetServiceInstance().GetType().ToString() + "服务接收请求，开始处理");
            return sw;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply,
            object correlationState)
        {
            ((Stopwatch)correlationState).Stop();
            TimeSpan ts = ((Stopwatch)correlationState).Elapsed;

            Mobao.M.Utility.LogHelper.Instance.Info("处理完毕.话费时间:" + "小时：" + ts.Hours.ToString() + "分钟：" + ts.Minutes.ToString() + "秒数：" + ts.Seconds.ToString() + "毫秒：" + ts.Milliseconds.ToString());
        }
    }
}
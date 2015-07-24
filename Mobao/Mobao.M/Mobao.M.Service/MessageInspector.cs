using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Mobao.M.Service
{
    public class MessageInspector : System.ServiceModel.Dispatcher.IDispatchMessageInspector
    {
        static Dictionary<string, object> ContextSession = new Dictionary<string, object>();
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request,
            System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            //权限认证
            //if (ContextSession.ContainsKey(OperationContext.Current.SessionId))
            //{

            //}
            //else if()
            //{
            //    throw new FaultException("权限认证失败");
            //}



            Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string serviceName = instanceContext.GetServiceInstance().GetType().ToString();
            Mobao.M.Utility.LogHelper.Instance.Info(serviceName + "服务接收请求，开始处理");
            return new Tuple<Stopwatch, string>(sw, serviceName);
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply,
            object correlationState)
        {
            Tuple<Stopwatch, string> tuplex = (Tuple<Stopwatch, string>)correlationState;
            tuplex.Item1.Stop();
            TimeSpan ts = tuplex.Item1.Elapsed;
            Mobao.M.Utility.LogHelper.Instance.Info(tuplex.Item2 + "处理完毕.话费时间:小时：" + ts.Hours.ToString()
                + "  分钟：" + ts.Minutes.ToString() + "  秒数：" + ts.Seconds.ToString() + "毫秒：" + ts.Milliseconds.ToString());
        }
    }
}
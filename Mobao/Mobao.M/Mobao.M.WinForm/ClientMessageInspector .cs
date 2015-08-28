using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.WinForm
{
    public class ClientMessageInspector : System.ServiceModel.Dispatcher.IClientMessageInspector
    {
        public static string flag = "okoko";
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            correlationState = "okokok";
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            request.Headers.Add(MessageHeader.CreateHeader("identityUser", "localhost", "哈哈"));
            return flag;
            //throw new NotImplementedException();
        }
    }
}

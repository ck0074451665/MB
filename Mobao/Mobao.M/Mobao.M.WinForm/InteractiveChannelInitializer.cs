using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.Winform
{
    public class InteractiveChannelInitializer : IInteractiveChannelInitializer
    {

        public IAsyncResult BeginDisplayInitializationUI(System.ServiceModel.IClientChannel channel, AsyncCallback callback, object state)
        {
            return new AsyncResult();
        }

        public void EndDisplayInitializationUI(IAsyncResult result)
        {

        }
    }

    public class AsyncResult : IAsyncResult
    {

        public object AsyncState
        {
            get { throw new NotImplementedException(); }
        }

        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get { throw new NotImplementedException(); }
        }

        public bool CompletedSynchronously
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }
    }
}

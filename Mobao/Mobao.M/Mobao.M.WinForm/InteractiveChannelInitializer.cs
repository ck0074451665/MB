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
            get;
            private set;
        }

        public System.Threading.WaitHandle AsyncWaitHandle
        {
            get;
            private set;
        }

        public bool CompletedSynchronously
        {
            get { return true; }
        }

        public bool IsCompleted
        {
            get { return true; }
        }
    }
}

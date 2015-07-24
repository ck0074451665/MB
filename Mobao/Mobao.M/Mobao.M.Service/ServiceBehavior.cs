using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace Mobao.M.Service
{
    public class ServiceBehavior : System.ServiceModel.Configuration.BehaviorExtensionElement, IServiceBehavior, IErrorHandler
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            var instance = new InstanceContextProvider();
            foreach (ChannelDispatcher channelDispatcher in serviceHostBase.ChannelDispatchers)
            {
                channelDispatcher.ErrorHandlers.Add(this);
                foreach (EndpointDispatcher item in channelDispatcher.Endpoints)
                {
                    item.DispatchRuntime.InstanceContextProvider = instance;
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {

        }

        public override Type BehaviorType
        {
            get { return this.GetType(); }
        }

        protected override object CreateBehavior()
        {
            return new ServiceBehavior();
        }

        public bool HandleError(Exception error)
        {
            return true;
        }

        public void ProvideFault(Exception error, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault)
        {
            Mobao.M.Utility.LogHelper.Instance.Error("服务错误.", error);
        }
    }
}
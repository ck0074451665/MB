using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Mobao.M.WinForm
{
    public class EndpointBehavior : System.ServiceModel.Configuration.BehaviorExtensionElement, System.ServiceModel.Description.IEndpointBehavior
    {
        public void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new ClientMessageInspector());
            foreach (ClientOperation op in clientRuntime.Operations)
                op.ParameterInspectors.Add(new ParameterInspector());

        }

        public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {
            //endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new ClientMessageInspector());
            //foreach (DispatchOperation op in endpointDispatcher.DispatchRuntime.Operations)
            //    op.ParameterInspectors.Add(new ParameterInspector());

        }

        public void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint)
        {
            //endpoint.Address.Identity.IdentityClaim
        }

        public override Type BehaviorType
        {
            get { return this.GetType(); }
        }

        protected override object CreateBehavior()
        {
            return new EndpointBehavior();
        }
    }
}

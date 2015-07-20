﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Web;

namespace Mobao.M.Service
{
    public class EndpointBehavior : System.ServiceModel.Configuration.BehaviorExtensionElement, IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
        {

        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
        {

        }

        public void Validate(ServiceEndpoint endpoint)
        {

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
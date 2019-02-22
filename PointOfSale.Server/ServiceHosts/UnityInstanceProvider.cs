using System;
using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Unity;

namespace PointOfSale.Server.ServiceHosts
{
    public class UnityInstanceProvider : IServiceBehavior, IInstanceProvider
    {
        private readonly Type m_serviceType;
        private readonly IUnityContainer m_container;

        public UnityInstanceProvider(Type serviceType, IUnityContainer container)
        {
            m_serviceType = serviceType;
            m_container = container;
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
        }

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcherBase channelDispatcherBase in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher cd = (ChannelDispatcher)channelDispatcherBase;
                foreach (EndpointDispatcher ed in cd.Endpoints)
                {
                    if (!ed.IsSystemEndpoint)
                    {
                        ed.DispatchRuntime.InstanceProvider = this;
                    }
                }
            }
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return m_container.Resolve(m_serviceType);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return GetInstance(instanceContext);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            (instance as IDisposable)?.Dispose();
        }
    }
}
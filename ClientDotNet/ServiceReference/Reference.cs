﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.miaad.org/", ConfigurationName="ServiceReference.BanqueService")]
    public interface BanqueService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.miaad.org/BanqueService/ConvertRequest", ReplyAction="http://ws.miaad.org/BanqueService/ConvertResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.ConvertResponse> ConvertAsync(ServiceReference.ConvertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.miaad.org/BanqueService/getCompteRequest", ReplyAction="http://ws.miaad.org/BanqueService/getCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.getCompteResponse> getCompteAsync(ServiceReference.getCompteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.miaad.org/BanqueService/listCompteRequest", ReplyAction="http://ws.miaad.org/BanqueService/listCompteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<ServiceReference.listCompteResponse> listCompteAsync(ServiceReference.listCompteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Convert", WrapperNamespace="http://ws.miaad.org/", IsWrapped=true)]
    public partial class ConvertRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.miaad.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double montant;
        
        public ConvertRequest()
        {
        }
        
        public ConvertRequest(double montant)
        {
            this.montant = montant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConvertResponse", WrapperNamespace="http://ws.miaad.org/", IsWrapped=true)]
    public partial class ConvertResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.miaad.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double @return;
        
        public ConvertResponse()
        {
        }
        
        public ConvertResponse(double @return)
        {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.miaad.org/")]
    public partial class compte
    {
        
        private int codeField;
        
        private double soldField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public double sold
        {
            get
            {
                return this.soldField;
            }
            set
            {
                this.soldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompte", WrapperNamespace="http://ws.miaad.org/", IsWrapped=true)]
    public partial class getCompteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.miaad.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int code;
        
        public getCompteRequest()
        {
        }
        
        public getCompteRequest(int code)
        {
            this.code = code;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCompteResponse", WrapperNamespace="http://ws.miaad.org/", IsWrapped=true)]
    public partial class getCompteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.miaad.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference.compte @return;
        
        public getCompteResponse()
        {
        }
        
        public getCompteResponse(ServiceReference.compte @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listCompte", WrapperNamespace="http://ws.miaad.org/", IsWrapped=true)]
    public partial class listCompteRequest
    {
        
        public listCompteRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listCompteResponse", WrapperNamespace="http://ws.miaad.org/", IsWrapped=true)]
    public partial class listCompteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.miaad.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference.compte[] @return;
        
        public listCompteResponse()
        {
        }
        
        public listCompteResponse(ServiceReference.compte[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface BanqueServiceChannel : ServiceReference.BanqueService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class BanqueServiceClient : System.ServiceModel.ClientBase<ServiceReference.BanqueService>, ServiceReference.BanqueService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BanqueServiceClient() : 
                base(BanqueServiceClient.GetDefaultBinding(), BanqueServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BanqueServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), BanqueServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BanqueServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BanqueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference.ConvertResponse> ServiceReference.BanqueService.ConvertAsync(ServiceReference.ConvertRequest request)
        {
            return base.Channel.ConvertAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.ConvertResponse> ConvertAsync(double montant)
        {
            ServiceReference.ConvertRequest inValue = new ServiceReference.ConvertRequest();
            inValue.montant = montant;
            return ((ServiceReference.BanqueService)(this)).ConvertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference.getCompteResponse> ServiceReference.BanqueService.getCompteAsync(ServiceReference.getCompteRequest request)
        {
            return base.Channel.getCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.getCompteResponse> getCompteAsync(int code)
        {
            ServiceReference.getCompteRequest inValue = new ServiceReference.getCompteRequest();
            inValue.code = code;
            return ((ServiceReference.BanqueService)(this)).getCompteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference.listCompteResponse> ServiceReference.BanqueService.listCompteAsync(ServiceReference.listCompteRequest request)
        {
            return base.Channel.listCompteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.listCompteResponse> listCompteAsync()
        {
            ServiceReference.listCompteRequest inValue = new ServiceReference.listCompteRequest();
            return ((ServiceReference.BanqueService)(this)).listCompteAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BanqueServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BanqueServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:9191/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BanqueServiceClient.GetBindingForEndpoint(EndpointConfiguration.BanqueServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BanqueServiceClient.GetEndpointAddress(EndpointConfiguration.BanqueServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            BanqueServicePort,
        }
    }
}

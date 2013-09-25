namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ISBMProviderRequestServiceClient : System.ServiceModel.ClientBase<IISBMProviderRequestService>, IISBMProviderRequestService
    {
        
        public ISBMProviderRequestServiceClient()
        {
        }
        
        public ISBMProviderRequestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ISBMProviderRequestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMProviderRequestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMProviderRequestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenProviderRequestSessionResponse IISBMProviderRequestService.OpenProviderRequestSession(OpenProviderRequestSessionRequest request)
        {
            return base.Channel.OpenProviderRequestSession(request);
        }
        
        public string OpenProviderRequestSession(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURI, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace)
        {
            OpenProviderRequestSessionRequest inValue = new OpenProviderRequestSessionRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.Topic = Topic;
            inValue.ListenerURI = ListenerURI;
            inValue.XPathExpression = XPathExpression;
            inValue.XPathNamespace = XPathNamespace;
            OpenProviderRequestSessionResponse retVal = ((IISBMProviderRequestService)(this)).OpenProviderRequestSession(inValue);
            return retVal.SessionID;
        }
        
        public RequestMessage ReadRequest(string SessionID)
        {
            return base.Channel.ReadRequest(SessionID);
        }
        
        public void RemoveRequest(string SessionID)
        {
            base.Channel.RemoveRequest(SessionID);
        }
        
        public string PostResponse(string SessionID, string RequestMessageID, System.Xml.XmlElement MessageContent)
        {
            return base.Channel.PostResponse(SessionID, RequestMessageID, MessageContent);
        }
        
        public void CloseProviderRequestSession(string SessionID)
        {
            base.Channel.CloseProviderRequestSession(SessionID);
        }
    }
}

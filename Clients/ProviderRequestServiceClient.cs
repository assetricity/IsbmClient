namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProviderRequestServiceClient : System.ServiceModel.ClientBase<IProviderRequestService>, IProviderRequestService
    {
        
        public ProviderRequestServiceClient()
        {
        }
        
        public ProviderRequestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ProviderRequestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProviderRequestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProviderRequestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenProviderRequestSessionResponse IProviderRequestService.OpenProviderRequestSession(OpenProviderRequestSessionRequest request)
        {
            return base.Channel.OpenProviderRequestSession(request);
        }
        
        public string OpenProviderRequestSession(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURL, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace)
        {
            OpenProviderRequestSessionRequest inValue = new OpenProviderRequestSessionRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.Topic = Topic;
            inValue.ListenerURL = ListenerURL;
            inValue.XPathExpression = XPathExpression;
            inValue.XPathNamespace = XPathNamespace;
            OpenProviderRequestSessionResponse retVal = ((IProviderRequestService)(this)).OpenProviderRequestSession(inValue);
            return retVal.SessionID;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IProviderRequestService.BeginOpenProviderRequestSession(OpenProviderRequestSessionRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginOpenProviderRequestSession(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginOpenProviderRequestSession(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURL, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace, System.AsyncCallback callback, object asyncState)
        {
            OpenProviderRequestSessionRequest inValue = new OpenProviderRequestSessionRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.Topic = Topic;
            inValue.ListenerURL = ListenerURL;
            inValue.XPathExpression = XPathExpression;
            inValue.XPathNamespace = XPathNamespace;
            return ((IProviderRequestService)(this)).BeginOpenProviderRequestSession(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenProviderRequestSessionResponse IProviderRequestService.EndOpenProviderRequestSession(System.IAsyncResult result)
        {
            return base.Channel.EndOpenProviderRequestSession(result);
        }
        
        public string EndOpenProviderRequestSession(System.IAsyncResult result)
        {
            OpenProviderRequestSessionResponse retVal = ((IProviderRequestService)(this)).EndOpenProviderRequestSession(result);
            return retVal.SessionID;
        }
        
        public RequestMessage ReadRequest(string SessionID)
        {
            return base.Channel.ReadRequest(SessionID);
        }
        
        public System.IAsyncResult BeginReadRequest(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginReadRequest(SessionID, callback, asyncState);
        }
        
        public RequestMessage EndReadRequest(System.IAsyncResult result)
        {
            return base.Channel.EndReadRequest(result);
        }
        
        public void RemoveRequest(string SessionID)
        {
            base.Channel.RemoveRequest(SessionID);
        }
        
        public System.IAsyncResult BeginRemoveRequest(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginRemoveRequest(SessionID, callback, asyncState);
        }
        
        public void EndRemoveRequest(System.IAsyncResult result)
        {
            base.Channel.EndRemoveRequest(result);
        }
        
        public string PostResponse(string SessionID, string RequestMessageID, System.Xml.XmlElement MessageContent)
        {
            return base.Channel.PostResponse(SessionID, RequestMessageID, MessageContent);
        }
        
        public System.IAsyncResult BeginPostResponse(string SessionID, string RequestMessageID, System.Xml.XmlElement MessageContent, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginPostResponse(SessionID, RequestMessageID, MessageContent, callback, asyncState);
        }
        
        public string EndPostResponse(System.IAsyncResult result)
        {
            return base.Channel.EndPostResponse(result);
        }
        
        public void CloseProviderRequestSession(string SessionID)
        {
            base.Channel.CloseProviderRequestSession(SessionID);
        }
        
        public System.IAsyncResult BeginCloseProviderRequestSession(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginCloseProviderRequestSession(SessionID, callback, asyncState);
        }
        
        public void EndCloseProviderRequestSession(System.IAsyncResult result)
        {
            base.Channel.EndCloseProviderRequestSession(result);
        }
    }
}

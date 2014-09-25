namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsumerPublicationServiceClient : System.ServiceModel.ClientBase<IConsumerPublicationService>, IConsumerPublicationService
    {
        
        public ConsumerPublicationServiceClient()
        {
        }
        
        public ConsumerPublicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ConsumerPublicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ConsumerPublicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ConsumerPublicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenSubscriptionSessionResponse IConsumerPublicationService.OpenSubscriptionSession(OpenSubscriptionSessionRequest request)
        {
            return base.Channel.OpenSubscriptionSession(request);
        }
        
        public string OpenSubscriptionSession(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURL, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace)
        {
            OpenSubscriptionSessionRequest inValue = new OpenSubscriptionSessionRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.Topic = Topic;
            inValue.ListenerURL = ListenerURL;
            inValue.XPathExpression = XPathExpression;
            inValue.XPathNamespace = XPathNamespace;
            OpenSubscriptionSessionResponse retVal = ((IConsumerPublicationService)(this)).OpenSubscriptionSession(inValue);
            return retVal.SessionID;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IConsumerPublicationService.BeginOpenSubscriptionSession(OpenSubscriptionSessionRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginOpenSubscriptionSession(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginOpenSubscriptionSession(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURL, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace, System.AsyncCallback callback, object asyncState)
        {
            OpenSubscriptionSessionRequest inValue = new OpenSubscriptionSessionRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.Topic = Topic;
            inValue.ListenerURL = ListenerURL;
            inValue.XPathExpression = XPathExpression;
            inValue.XPathNamespace = XPathNamespace;
            return ((IConsumerPublicationService)(this)).BeginOpenSubscriptionSession(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenSubscriptionSessionResponse IConsumerPublicationService.EndOpenSubscriptionSession(System.IAsyncResult result)
        {
            return base.Channel.EndOpenSubscriptionSession(result);
        }
        
        public string EndOpenSubscriptionSession(System.IAsyncResult result)
        {
            OpenSubscriptionSessionResponse retVal = ((IConsumerPublicationService)(this)).EndOpenSubscriptionSession(result);
            return retVal.SessionID;
        }
        
        public PublicationMessage ReadPublication(string SessionID)
        {
            return base.Channel.ReadPublication(SessionID);
        }
        
        public System.IAsyncResult BeginReadPublication(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginReadPublication(SessionID, callback, asyncState);
        }
        
        public PublicationMessage EndReadPublication(System.IAsyncResult result)
        {
            return base.Channel.EndReadPublication(result);
        }
        
        public void RemovePublication(string SessionID)
        {
            base.Channel.RemovePublication(SessionID);
        }
        
        public System.IAsyncResult BeginRemovePublication(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginRemovePublication(SessionID, callback, asyncState);
        }
        
        public void EndRemovePublication(System.IAsyncResult result)
        {
            base.Channel.EndRemovePublication(result);
        }
        
        public void CloseSubscriptionSession(string SessionID)
        {
            base.Channel.CloseSubscriptionSession(SessionID);
        }
        
        public System.IAsyncResult BeginCloseSubscriptionSession(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginCloseSubscriptionSession(SessionID, callback, asyncState);
        }
        
        public void EndCloseSubscriptionSession(System.IAsyncResult result)
        {
            base.Channel.EndCloseSubscriptionSession(result);
        }
    }
}

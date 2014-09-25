namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProviderPublicationServiceClient : System.ServiceModel.ClientBase<IProviderPublicationService>, IProviderPublicationService
    {
        
        public ProviderPublicationServiceClient()
        {
        }
        
        public ProviderPublicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ProviderPublicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProviderPublicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProviderPublicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string OpenPublicationSession(string ChannelURI)
        {
            return base.Channel.OpenPublicationSession(ChannelURI);
        }
        
        public System.IAsyncResult BeginOpenPublicationSession(string ChannelURI, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginOpenPublicationSession(ChannelURI, callback, asyncState);
        }
        
        public string EndOpenPublicationSession(System.IAsyncResult result)
        {
            return base.Channel.EndOpenPublicationSession(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PostPublicationResponse IProviderPublicationService.PostPublication(PostPublicationRequest request)
        {
            return base.Channel.PostPublication(request);
        }
        
        public string PostPublication(string SessionID, System.Xml.XmlElement MessageContent, System.Collections.Generic.List<string> Topic, string Expiry)
        {
            PostPublicationRequest inValue = new PostPublicationRequest();
            inValue.SessionID = SessionID;
            inValue.MessageContent = MessageContent;
            inValue.Topic = Topic;
            inValue.Expiry = Expiry;
            PostPublicationResponse retVal = ((IProviderPublicationService)(this)).PostPublication(inValue);
            return retVal.MessageID;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IProviderPublicationService.BeginPostPublication(PostPublicationRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginPostPublication(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginPostPublication(string SessionID, System.Xml.XmlElement MessageContent, System.Collections.Generic.List<string> Topic, string Expiry, System.AsyncCallback callback, object asyncState)
        {
            PostPublicationRequest inValue = new PostPublicationRequest();
            inValue.SessionID = SessionID;
            inValue.MessageContent = MessageContent;
            inValue.Topic = Topic;
            inValue.Expiry = Expiry;
            return ((IProviderPublicationService)(this)).BeginPostPublication(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PostPublicationResponse IProviderPublicationService.EndPostPublication(System.IAsyncResult result)
        {
            return base.Channel.EndPostPublication(result);
        }
        
        public string EndPostPublication(System.IAsyncResult result)
        {
            PostPublicationResponse retVal = ((IProviderPublicationService)(this)).EndPostPublication(result);
            return retVal.MessageID;
        }
        
        public void ExpirePublication(string SessionID, string MessageID)
        {
            base.Channel.ExpirePublication(SessionID, MessageID);
        }
        
        public System.IAsyncResult BeginExpirePublication(string SessionID, string MessageID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginExpirePublication(SessionID, MessageID, callback, asyncState);
        }
        
        public void EndExpirePublication(System.IAsyncResult result)
        {
            base.Channel.EndExpirePublication(result);
        }
        
        public void ClosePublicationSession(string SessionID)
        {
            base.Channel.ClosePublicationSession(SessionID);
        }
        
        public System.IAsyncResult BeginClosePublicationSession(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginClosePublicationSession(SessionID, callback, asyncState);
        }
        
        public void EndClosePublicationSession(System.IAsyncResult result)
        {
            base.Channel.EndClosePublicationSession(result);
        }
    }
}

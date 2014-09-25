namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsumerRequestServiceClient : System.ServiceModel.ClientBase<IConsumerRequestService>, IConsumerRequestService
    {
        
        public ConsumerRequestServiceClient()
        {
        }
        
        public ConsumerRequestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ConsumerRequestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ConsumerRequestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ConsumerRequestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string OpenConsumerRequestSession(string ChannelURI, string ListenerURL)
        {
            return base.Channel.OpenConsumerRequestSession(ChannelURI, ListenerURL);
        }
        
        public System.IAsyncResult BeginOpenConsumerRequestSession(string ChannelURI, string ListenerURL, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginOpenConsumerRequestSession(ChannelURI, ListenerURL, callback, asyncState);
        }
        
        public string EndOpenConsumerRequestSession(System.IAsyncResult result)
        {
            return base.Channel.EndOpenConsumerRequestSession(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PostRequestResponse IConsumerRequestService.PostRequest(PostRequestRequest request)
        {
            return base.Channel.PostRequest(request);
        }
        
        public string PostRequest(string SessionID, System.Xml.XmlElement MessageContent, string Topic, string Expiry)
        {
            PostRequestRequest inValue = new PostRequestRequest();
            inValue.SessionID = SessionID;
            inValue.MessageContent = MessageContent;
            inValue.Topic = Topic;
            inValue.Expiry = Expiry;
            PostRequestResponse retVal = ((IConsumerRequestService)(this)).PostRequest(inValue);
            return retVal.MessageID;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IConsumerRequestService.BeginPostRequest(PostRequestRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginPostRequest(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginPostRequest(string SessionID, System.Xml.XmlElement MessageContent, string Topic, string Expiry, System.AsyncCallback callback, object asyncState)
        {
            PostRequestRequest inValue = new PostRequestRequest();
            inValue.SessionID = SessionID;
            inValue.MessageContent = MessageContent;
            inValue.Topic = Topic;
            inValue.Expiry = Expiry;
            return ((IConsumerRequestService)(this)).BeginPostRequest(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PostRequestResponse IConsumerRequestService.EndPostRequest(System.IAsyncResult result)
        {
            return base.Channel.EndPostRequest(result);
        }
        
        public string EndPostRequest(System.IAsyncResult result)
        {
            PostRequestResponse retVal = ((IConsumerRequestService)(this)).EndPostRequest(result);
            return retVal.MessageID;
        }
        
        public void ExpireRequest(string SessionID, string MessageID)
        {
            base.Channel.ExpireRequest(SessionID, MessageID);
        }
        
        public System.IAsyncResult BeginExpireRequest(string SessionID, string MessageID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginExpireRequest(SessionID, MessageID, callback, asyncState);
        }
        
        public void EndExpireRequest(System.IAsyncResult result)
        {
            base.Channel.EndExpireRequest(result);
        }
        
        public ResponseMessage ReadResponse(string SessionID, string RequestMessageID)
        {
            return base.Channel.ReadResponse(SessionID, RequestMessageID);
        }
        
        public System.IAsyncResult BeginReadResponse(string SessionID, string RequestMessageID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginReadResponse(SessionID, RequestMessageID, callback, asyncState);
        }
        
        public ResponseMessage EndReadResponse(System.IAsyncResult result)
        {
            return base.Channel.EndReadResponse(result);
        }
        
        public void RemoveResponse(string SessionID, string RequestMessageID)
        {
            base.Channel.RemoveResponse(SessionID, RequestMessageID);
        }
        
        public System.IAsyncResult BeginRemoveResponse(string SessionID, string RequestMessageID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginRemoveResponse(SessionID, RequestMessageID, callback, asyncState);
        }
        
        public void EndRemoveResponse(System.IAsyncResult result)
        {
            base.Channel.EndRemoveResponse(result);
        }
        
        public void CloseConsumerRequestSession(string SessionID)
        {
            base.Channel.CloseConsumerRequestSession(SessionID);
        }
        
        public System.IAsyncResult BeginCloseConsumerRequestSession(string SessionID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginCloseConsumerRequestSession(SessionID, callback, asyncState);
        }
        
        public void EndCloseConsumerRequestSession(System.IAsyncResult result)
        {
            base.Channel.EndCloseConsumerRequestSession(result);
        }
    }
}

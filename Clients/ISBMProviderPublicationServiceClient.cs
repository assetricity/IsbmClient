namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ISBMProviderPublicationServiceClient : System.ServiceModel.ClientBase<IISBMProviderPublicationService>, IISBMProviderPublicationService
    {
        
        public ISBMProviderPublicationServiceClient()
        {
        }
        
        public ISBMProviderPublicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ISBMProviderPublicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMProviderPublicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMProviderPublicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string OpenPublicationSession(string ChannelURI)
        {
            return base.Channel.OpenPublicationSession(ChannelURI);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PostPublicationResponse IISBMProviderPublicationService.PostPublication(PostPublicationRequest request)
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
            PostPublicationResponse retVal = ((IISBMProviderPublicationService)(this)).PostPublication(inValue);
            return retVal.MessageID;
        }
        
        public void ExpirePublication(string SessionID, string MessageID)
        {
            base.Channel.ExpirePublication(SessionID, MessageID);
        }
        
        public void ClosePublicationSession(string SessionID)
        {
            base.Channel.ClosePublicationSession(SessionID);
        }
    }
}

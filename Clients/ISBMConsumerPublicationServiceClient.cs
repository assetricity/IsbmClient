namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ISBMConsumerPublicationServiceClient : System.ServiceModel.ClientBase<IISBMConsumerPublicationService>, IISBMConsumerPublicationService
    {
        
        public ISBMConsumerPublicationServiceClient()
        {
        }
        
        public ISBMConsumerPublicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ISBMConsumerPublicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMConsumerPublicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMConsumerPublicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenSubscriptionSessionResponse IISBMConsumerPublicationService.OpenSubscriptionSession(OpenSubscriptionSessionRequest request)
        {
            return base.Channel.OpenSubscriptionSession(request);
        }
        
        public string OpenSubscriptionSession(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURI, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace)
        {
            OpenSubscriptionSessionRequest inValue = new OpenSubscriptionSessionRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.Topic = Topic;
            inValue.ListenerURI = ListenerURI;
            inValue.XPathExpression = XPathExpression;
            inValue.XPathNamespace = XPathNamespace;
            OpenSubscriptionSessionResponse retVal = ((IISBMConsumerPublicationService)(this)).OpenSubscriptionSession(inValue);
            return retVal.SessionID;
        }
        
        public PublicationMessage ReadPublication(string SessionID, string LastMessageID)
        {
            return base.Channel.ReadPublication(SessionID, LastMessageID);
        }
        
        public void CloseSubscriptionSession(string SessionID)
        {
            base.Channel.CloseSubscriptionSession(SessionID);
        }
    }
}

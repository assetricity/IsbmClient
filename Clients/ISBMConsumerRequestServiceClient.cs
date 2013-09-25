namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ISBMConsumerRequestServiceClient : System.ServiceModel.ClientBase<IISBMConsumerRequestService>, IISBMConsumerRequestService
    {
        
        public ISBMConsumerRequestServiceClient()
        {
        }
        
        public ISBMConsumerRequestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ISBMConsumerRequestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMConsumerRequestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMConsumerRequestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string OpenConsumerRequestSession(string ChannelURI, string ListenerURI)
        {
            return base.Channel.OpenConsumerRequestSession(ChannelURI, ListenerURI);
        }
        
        public string PostRequest(string SessionID, System.Xml.XmlElement MessageContent, string Topic)
        {
            return base.Channel.PostRequest(SessionID, MessageContent, Topic);
        }
        
        public ResponseMessage ReadResponse(string SessionID, string RequestMessageID)
        {
            return base.Channel.ReadResponse(SessionID, RequestMessageID);
        }
        
        public void RemoveResponse(string SessionID, string RequestMessageID)
        {
            base.Channel.RemoveResponse(SessionID, RequestMessageID);
        }
        
        public void CloseConsumerRequestSession(string SessionID)
        {
            base.Channel.CloseConsumerRequestSession(SessionID);
        }
    }
}

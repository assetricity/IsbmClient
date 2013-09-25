namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="NotifyListener", WrapperNamespace="http://www.openoandm.org/xml/ISBM/", IsWrapped=true)]
    public partial class NotifyListenerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=0)]
        public string SessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=1)]
        public string MessageID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("TopicName")]
        public System.Collections.Generic.List<string> TopicName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=3)]
        public string RequestMessageID;
        
        public NotifyListenerRequest()
        {
        }
        
        public NotifyListenerRequest(string SessionID, string MessageID, System.Collections.Generic.List<string> TopicName, string RequestMessageID)
        {
            this.SessionID = SessionID;
            this.MessageID = MessageID;
            this.TopicName = TopicName;
            this.RequestMessageID = RequestMessageID;
        }
    }
}

namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="NotifyListener", WrapperNamespace="http://www.openoandm.org/ws-isbm/", IsWrapped=true)]
    public partial class NotifyListenerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=0)]
        public string SessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=1)]
        public string MessageID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("Topic")]
        public System.Collections.Generic.List<string> Topic;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=3)]
        public string RequestMessageID;
        
        public NotifyListenerRequest()
        {
        }
        
        public NotifyListenerRequest(string SessionID, string MessageID, System.Collections.Generic.List<string> Topic, string RequestMessageID)
        {
            this.SessionID = SessionID;
            this.MessageID = MessageID;
            this.Topic = Topic;
            this.RequestMessageID = RequestMessageID;
        }
    }
}

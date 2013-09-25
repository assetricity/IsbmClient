namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PostPublication", WrapperNamespace="http://www.openoandm.org/xml/ISBM/", IsWrapped=true)]
    public partial class PostPublicationRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=0)]
        public string SessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=1)]
        public System.Xml.XmlElement MessageContent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("Topic")]
        public System.Collections.Generic.List<string> Topic;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Expiry;
        
        public PostPublicationRequest()
        {
        }
        
        public PostPublicationRequest(string SessionID, System.Xml.XmlElement MessageContent, System.Collections.Generic.List<string> Topic, string Expiry)
        {
            this.SessionID = SessionID;
            this.MessageContent = MessageContent;
            this.Topic = Topic;
            this.Expiry = Expiry;
        }
    }
}

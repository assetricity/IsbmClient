namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PostRequest", WrapperNamespace="http://www.openoandm.org/ws-isbm/", IsWrapped=true)]
    public partial class PostRequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=0)]
        public string SessionID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=1)]
        public System.Xml.XmlElement MessageContent;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=2)]
        public string Topic;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Expiry;
        
        public PostRequestRequest()
        {
        }
        
        public PostRequestRequest(string SessionID, System.Xml.XmlElement MessageContent, string Topic, string Expiry)
        {
            this.SessionID = SessionID;
            this.MessageContent = MessageContent;
            this.Topic = Topic;
            this.Expiry = Expiry;
        }
    }
}

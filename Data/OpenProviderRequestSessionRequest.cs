namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OpenProviderRequestSession", WrapperNamespace="http://www.openoandm.org/ws-isbm/", IsWrapped=true)]
    public partial class OpenProviderRequestSessionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=0)]
        public string ChannelURI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("Topic")]
        public System.Collections.Generic.List<string> Topic;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=2)]
        public string ListenerURL;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=3)]
        public string XPathExpression;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("XPathNamespace")]
        public System.Collections.Generic.List<Namespace> XPathNamespace;
        
        public OpenProviderRequestSessionRequest()
        {
        }
        
        public OpenProviderRequestSessionRequest(string ChannelURI, System.Collections.Generic.List<string> Topic, string ListenerURL, string XPathExpression, System.Collections.Generic.List<Namespace> XPathNamespace)
        {
            this.ChannelURI = ChannelURI;
            this.Topic = Topic;
            this.ListenerURL = ListenerURL;
            this.XPathExpression = XPathExpression;
            this.XPathNamespace = XPathNamespace;
        }
    }
}

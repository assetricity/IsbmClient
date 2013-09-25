namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RemoveSecurityTokens", WrapperNamespace="http://www.openoandm.org/xml/ISBM/", IsWrapped=true)]
    public partial class RemoveSecurityTokensRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=0)]
        public string ChannelURI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("SecurityToken")]
        public System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken;
        
        public RemoveSecurityTokensRequest()
        {
        }
        
        public RemoveSecurityTokensRequest(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            this.ChannelURI = ChannelURI;
            this.SecurityToken = SecurityToken;
        }
    }
}

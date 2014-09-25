namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddSecurityTokens", WrapperNamespace="http://www.openoandm.org/ws-isbm/", IsWrapped=true)]
    public partial class AddSecurityTokensRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=0)]
        public string ChannelURI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("SecurityToken")]
        public System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken;
        
        public AddSecurityTokensRequest()
        {
        }
        
        public AddSecurityTokensRequest(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            this.ChannelURI = ChannelURI;
            this.SecurityToken = SecurityToken;
        }
    }
}

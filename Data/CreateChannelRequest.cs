namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateChannel", WrapperNamespace="http://www.openoandm.org/xml/ISBM/", IsWrapped=true)]
    public partial class CreateChannelRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=0)]
        public string ChannelURI;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=1)]
        public ChannelType ChannelType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=2)]
        public string ChannelDescription;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("SecurityToken")]
        public System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken;
        
        public CreateChannelRequest()
        {
        }
        
        public CreateChannelRequest(string ChannelURI, ChannelType ChannelType, string ChannelDescription, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            this.ChannelURI = ChannelURI;
            this.ChannelType = ChannelType;
            this.ChannelDescription = ChannelDescription;
            this.SecurityToken = SecurityToken;
        }
    }
}

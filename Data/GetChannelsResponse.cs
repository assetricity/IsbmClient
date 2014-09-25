namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetChannelsResponse", WrapperNamespace="http://www.openoandm.org/ws-isbm/", IsWrapped=true)]
    public partial class GetChannelsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Channel")]
        public System.Collections.Generic.List<Channel> Channel;
        
        public GetChannelsResponse()
        {
        }
        
        public GetChannelsResponse(System.Collections.Generic.List<Channel> Channel)
        {
            this.Channel = Channel;
        }
    }
}

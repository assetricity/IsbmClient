namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PostPublicationResponse", WrapperNamespace="http://www.openoandm.org/xml/ISBM/", IsWrapped=true)]
    public partial class PostPublicationResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", Order=0)]
        public string MessageID;
        
        public PostPublicationResponse()
        {
        }
        
        public PostPublicationResponse(string MessageID)
        {
            this.MessageID = MessageID;
        }
    }
}

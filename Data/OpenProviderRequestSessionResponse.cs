namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OpenProviderRequestSessionResponse", WrapperNamespace="http://www.openoandm.org/ws-isbm/", IsWrapped=true)]
    public partial class OpenProviderRequestSessionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.openoandm.org/ws-isbm/", Order=0)]
        public string SessionID;
        
        public OpenProviderRequestSessionResponse()
        {
        }
        
        public OpenProviderRequestSessionResponse(string SessionID)
        {
            this.SessionID = SessionID;
        }
    }
}

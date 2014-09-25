namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/ws-isbm/", ConfigurationName="IProviderPublicationService")]
    public interface IProviderPublicationService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/OpenPublicationSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/OpenPublicationSession", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(OperationFault), Action="http://www.openoandm.org/ws-isbm/OpenPublicationSession", Name="OperationFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        string OpenPublicationSession(string ChannelURI);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/OpenPublicationSession", ReplyAction="*")]
        System.IAsyncResult BeginOpenPublicationSession(string ChannelURI, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        string EndOpenPublicationSession(System.IAsyncResult result);
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/PostPublication", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/PostPublication", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        PostPublicationResponse PostPublication(PostPublicationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/PostPublication", ReplyAction="*")]
        System.IAsyncResult BeginPostPublication(PostPublicationRequest request, System.AsyncCallback callback, object asyncState);
        
        PostPublicationResponse EndPostPublication(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ExpirePublication", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ExpirePublication", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ExpirePublication(string SessionID, string MessageID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ExpirePublication", ReplyAction="*")]
        System.IAsyncResult BeginExpirePublication(string SessionID, string MessageID, System.AsyncCallback callback, object asyncState);
        
        void EndExpirePublication(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ClosePublicationSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ClosePublicationSession", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ClosePublicationSession(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ClosePublicationSession", ReplyAction="*")]
        System.IAsyncResult BeginClosePublicationSession(string SessionID, System.AsyncCallback callback, object asyncState);
        
        void EndClosePublicationSession(System.IAsyncResult result);
    }
}

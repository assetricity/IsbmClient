namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/ws-isbm/", ConfigurationName="IProviderRequestService")]
    public interface IProviderRequestService
    {
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/OpenProviderRequestSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/OpenProviderRequestSession", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(NamespaceFault), Action="http://www.openoandm.org/ws-isbm/OpenProviderRequestSession", Name="NamespaceFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(OperationFault), Action="http://www.openoandm.org/ws-isbm/OpenProviderRequestSession", Name="OperationFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        OpenProviderRequestSessionResponse OpenProviderRequestSession(OpenProviderRequestSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/OpenProviderRequestSession", ReplyAction="*")]
        System.IAsyncResult BeginOpenProviderRequestSession(OpenProviderRequestSessionRequest request, System.AsyncCallback callback, object asyncState);
        
        OpenProviderRequestSessionResponse EndOpenProviderRequestSession(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ReadRequest", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ReadRequest", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RequestMessage")]
        RequestMessage ReadRequest(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ReadRequest", ReplyAction="*")]
        System.IAsyncResult BeginReadRequest(string SessionID, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="RequestMessage")]
        RequestMessage EndReadRequest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/RemoveRequest", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/RemoveRequest", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RemoveRequest(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/RemoveRequest", ReplyAction="*")]
        System.IAsyncResult BeginRemoveRequest(string SessionID, System.AsyncCallback callback, object asyncState);
        
        void EndRemoveRequest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/PostResponse", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/PostResponse", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        string PostResponse(string SessionID, string RequestMessageID, System.Xml.XmlElement MessageContent);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/PostResponse", ReplyAction="*")]
        System.IAsyncResult BeginPostResponse(string SessionID, string RequestMessageID, System.Xml.XmlElement MessageContent, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        string EndPostResponse(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/CloseProviderRequestSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/CloseProviderRequestSession", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CloseProviderRequestSession(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/CloseProviderRequestSession", ReplyAction="*")]
        System.IAsyncResult BeginCloseProviderRequestSession(string SessionID, System.AsyncCallback callback, object asyncState);
        
        void EndCloseProviderRequestSession(System.IAsyncResult result);
    }
}

namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/ws-isbm/", ConfigurationName="IConsumerRequestService")]
    public interface IConsumerRequestService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/OpenConsumerRequestSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/OpenConsumerRequestSession", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(OperationFault), Action="http://www.openoandm.org/ws-isbm/OpenConsumerRequestSession", Name="OperationFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        string OpenConsumerRequestSession(string ChannelURI, string ListenerURL);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/OpenConsumerRequestSession", ReplyAction="*")]
        System.IAsyncResult BeginOpenConsumerRequestSession(string ChannelURI, string ListenerURL, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        string EndOpenConsumerRequestSession(System.IAsyncResult result);
        
        // CODEGEN: Parameter 'Expiry' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/PostRequest", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/PostRequest", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        PostRequestResponse PostRequest(PostRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/PostRequest", ReplyAction="*")]
        System.IAsyncResult BeginPostRequest(PostRequestRequest request, System.AsyncCallback callback, object asyncState);
        
        PostRequestResponse EndPostRequest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ExpireRequest", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ExpireRequest", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ExpireRequest(string SessionID, string MessageID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ExpireRequest", ReplyAction="*")]
        System.IAsyncResult BeginExpireRequest(string SessionID, string MessageID, System.AsyncCallback callback, object asyncState);
        
        void EndExpireRequest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ReadResponse", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ReadResponse", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ResponseMessage")]
        ResponseMessage ReadResponse(string SessionID, string RequestMessageID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ReadResponse", ReplyAction="*")]
        System.IAsyncResult BeginReadResponse(string SessionID, string RequestMessageID, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="ResponseMessage")]
        ResponseMessage EndReadResponse(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/RemoveResponse", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/RemoveResponse", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RemoveResponse(string SessionID, string RequestMessageID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/RemoveResponse", ReplyAction="*")]
        System.IAsyncResult BeginRemoveResponse(string SessionID, string RequestMessageID, System.AsyncCallback callback, object asyncState);
        
        void EndRemoveResponse(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/CloseConsumerRequestSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/CloseConsumerRequestSession", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CloseConsumerRequestSession(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/CloseConsumerRequestSession", ReplyAction="*")]
        System.IAsyncResult BeginCloseConsumerRequestSession(string SessionID, System.AsyncCallback callback, object asyncState);
        
        void EndCloseConsumerRequestSession(System.IAsyncResult result);
    }
}

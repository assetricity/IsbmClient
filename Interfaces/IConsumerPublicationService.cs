namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/ws-isbm/", ConfigurationName="IConsumerPublicationService")]
    public interface IConsumerPublicationService
    {
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/OpenSubscriptionSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/OpenSubscriptionSession", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(NamespaceFault), Action="http://www.openoandm.org/ws-isbm/OpenSubscriptionSession", Name="NamespaceFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(OperationFault), Action="http://www.openoandm.org/ws-isbm/OpenSubscriptionSession", Name="OperationFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        OpenSubscriptionSessionResponse OpenSubscriptionSession(OpenSubscriptionSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/OpenSubscriptionSession", ReplyAction="*")]
        System.IAsyncResult BeginOpenSubscriptionSession(OpenSubscriptionSessionRequest request, System.AsyncCallback callback, object asyncState);
        
        OpenSubscriptionSessionResponse EndOpenSubscriptionSession(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ReadPublication", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ReadPublication", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PublicationMessage")]
        PublicationMessage ReadPublication(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ReadPublication", ReplyAction="*")]
        System.IAsyncResult BeginReadPublication(string SessionID, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="PublicationMessage")]
        PublicationMessage EndReadPublication(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ReadPublication", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/ReadPublication", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RemovePublication(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ReadPublication", ReplyAction="*")]
        System.IAsyncResult BeginRemovePublication(string SessionID, System.AsyncCallback callback, object asyncState);
        
        void EndRemovePublication(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/CloseSubscriptionSession", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(SessionFault), Action="http://www.openoandm.org/ws-isbm/CloseSubscriptionSession", Name="SessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CloseSubscriptionSession(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/CloseSubscriptionSession", ReplyAction="*")]
        System.IAsyncResult BeginCloseSubscriptionSession(string SessionID, System.AsyncCallback callback, object asyncState);
        
        void EndCloseSubscriptionSession(System.IAsyncResult result);
    }
}

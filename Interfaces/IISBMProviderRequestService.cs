namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", ConfigurationName="IISBMProviderRequestService")]
    public interface IISBMProviderRequestService
    {
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/OpenProviderRequest" +
            "Session", ReplyAction="http://www.openoandm.org/xml/ISBM/OpenProviderRequest" +
            "SessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/OpenProviderRequest" +
            "Session", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidOperationFault), Action="http://www.openoandm.org/xml/ISBM/OpenProviderRequest" +
            "Session", Name="InvalidOperationFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(DuplicateNamespacePrefixFault), Action="http://www.openoandm.org/xml/ISBM/OpenProviderRequest" +
            "Session", Name="DuplicateNamespacePrefixFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        OpenProviderRequestSessionResponse OpenProviderRequestSession(OpenProviderRequestSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/ReadRequest", ReplyAction="http://www.openoandm.org/xml/ISBM/ReadRequestResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/ReadRequest", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="RequestMessage")]
        RequestMessage ReadRequest(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/RemoveRequest", ReplyAction="http://www.openoandm.org/xml/ISBM/RemoveRequestRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/RemoveRequest", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RemoveRequest(string SessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/PostResponse", ReplyAction="http://www.openoandm.org/xml/ISBM/PostResponseRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/PostResponse", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        string PostResponse(string SessionID, string RequestMessageID, System.Xml.XmlElement MessageContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/CloseProviderReques" +
            "tSession", ReplyAction="http://www.openoandm.org/xml/ISBM/CloseProviderReques" +
            "tSessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/CloseProviderReques" +
            "tSession", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CloseProviderRequestSession(string SessionID);
    }
}

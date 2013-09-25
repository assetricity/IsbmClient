namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", ConfigurationName="IISBMConsumerRequestService")]
    public interface IISBMConsumerRequestService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/OpenConsumerRequest" +
            "Session", ReplyAction="http://www.openoandm.org/xml/ISBM/OpenConsumerRequest" +
            "SessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/OpenConsumerRequest" +
            "Session", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidOperationFault), Action="http://www.openoandm.org/xml/ISBM/OpenConsumerRequest" +
            "Session", Name="InvalidOperationFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        string OpenConsumerRequestSession(string ChannelURI, string ListenerURI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/PostRequest", ReplyAction="http://www.openoandm.org/xml/ISBM/PostRequestResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/PostRequest", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        string PostRequest(string SessionID, System.Xml.XmlElement MessageContent, string Topic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/ReadResponse", ReplyAction="http://www.openoandm.org/xml/ISBM/ReadResponseRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/ReadResponse", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ResponseMessage")]
        ResponseMessage ReadResponse(string SessionID, string RequestMessageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/RemoveResponse", ReplyAction="http://www.openoandm.org/xml/ISBM/RemoveResponseRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/RemoveResponse", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void RemoveResponse(string SessionID, string RequestMessageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/CloseConsumerReques" +
            "tSession", ReplyAction="http://www.openoandm.org/xml/ISBM/CloseConsumerReques" +
            "tSessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/CloseConsumerReques" +
            "tSession", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CloseConsumerRequestSession(string SessionID);
    }
}

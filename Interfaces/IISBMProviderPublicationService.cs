namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", ConfigurationName="IISBMProviderPublicationService")]
    public interface IISBMProviderPublicationService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/OpenPublication" +
            "Session", ReplyAction="http://www.openoandm.org/xml/ISBM/OpenPublication" +
            "SessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/OpenPublication" +
            "Session", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidOperationFault), Action="http://www.openoandm.org/xml/ISBM/OpenPublication" +
            "Session", Name="InvalidOperationFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        string OpenPublicationSession(string ChannelURI);
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/PostPublication" +
            "", ReplyAction="http://www.openoandm.org/xml/ISBM/PostPublication" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/PostPublication" +
            "", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="MessageID")]
        PostPublicationResponse PostPublication(PostPublicationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/ExpirePublicati" +
            "on", ReplyAction="http://www.openoandm.org/xml/ISBM/ExpirePublicati" +
            "onResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/ExpirePublicati" +
            "on", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ExpirePublication(string SessionID, string MessageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/ClosePublicatio" +
            "nSession", ReplyAction="http://www.openoandm.org/xml/ISBM/ClosePublicatio" +
            "nSessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/ClosePublicatio" +
            "nSession", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ClosePublicationSession(string SessionID);
    }
}

namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", ConfigurationName="IISBMConsumerPublicationService")]
    public interface IISBMConsumerPublicationService
    {
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/OpenSubscriptio" +
            "nSession", ReplyAction="http://www.openoandm.org/xml/ISBM/OpenSubscriptio" +
            "nSessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/OpenSubscriptio" +
            "nSession", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidOperationFault), Action="http://www.openoandm.org/xml/ISBM/OpenSubscriptio" +
            "nSession", Name="InvalidOperationFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(DuplicateNamespacePrefixFault), Action="http://www.openoandm.org/xml/ISBM/OpenSubscriptio" +
            "nSession", Name="DuplicateNamespacePrefixFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="SessionID")]
        OpenSubscriptionSessionResponse OpenSubscriptionSession(OpenSubscriptionSessionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/ReadPublication" +
            "", ReplyAction="http://www.openoandm.org/xml/ISBM/ReadPublication" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/ReadPublication" +
            "", Name="InvalidSessionFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidMessageFault), Action="http://www.openoandm.org/xml/ISBM/ReadPublication" +
            "", Name="InvalidMessageFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="PublicationMessage")]
        PublicationMessage ReadPublication(string SessionID, string LastMessageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/CloseSubscripti" +
            "onSession", ReplyAction="http://www.openoandm.org/xml/ISBM/CloseSubscripti" +
            "onSessionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSessionFault), Action="http://www.openoandm.org/xml/ISBM/CloseSubscripti" +
            "onSession", Name="InvalidSessionFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void CloseSubscriptionSession(string SessionID);
    }
}

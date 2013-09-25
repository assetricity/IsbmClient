namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", ConfigurationName="IISBMNotificationService")]
    public interface IISBMNotificationService
    {
        
        // CODEGEN: Parameter 'TopicName' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/NotifyListener", ReplyAction="http://www.openoandm.org/xml/ISBM/NotifyListenerResponse" +
            "")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NotifyListenerResponse NotifyListener(NotifyListenerRequest request);
    }
}

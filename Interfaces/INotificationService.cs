namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/ws-isbm/", ConfigurationName="INotificationService")]
    public interface INotificationService
    {
        
        // CODEGEN: Parameter 'Topic' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/ReadPublication", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NotifyListenerResponse NotifyListener(NotifyListenerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/ReadPublication", ReplyAction="*")]
        System.IAsyncResult BeginNotifyListener(NotifyListenerRequest request, System.AsyncCallback callback, object asyncState);
        
        NotifyListenerResponse EndNotifyListener(System.IAsyncResult result);
    }
}

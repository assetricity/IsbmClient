namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/ws-isbm/", ConfigurationName="IChannelManagementService")]
    public interface IChannelManagementService
    {
        
        // CODEGEN: Parameter 'SecurityToken' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/CreateChannel", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/CreateChannel", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CreateChannelResponse CreateChannel(CreateChannelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/CreateChannel", ReplyAction="*")]
        System.IAsyncResult BeginCreateChannel(CreateChannelRequest request, System.AsyncCallback callback, object asyncState);
        
        CreateChannelResponse EndCreateChannel(System.IAsyncResult result);
        
        // CODEGEN: Parameter 'SecurityToken' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/AddSecurityTokens", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/AddSecurityTokens", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AddSecurityTokensResponse AddSecurityTokens(AddSecurityTokensRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/AddSecurityTokens", ReplyAction="*")]
        System.IAsyncResult BeginAddSecurityTokens(AddSecurityTokensRequest request, System.AsyncCallback callback, object asyncState);
        
        AddSecurityTokensResponse EndAddSecurityTokens(System.IAsyncResult result);
        
        // CODEGEN: Parameter 'SecurityToken' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/RemoveSecurityTokens", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/RemoveSecurityTokens", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityTokenFault), Action="http://www.openoandm.org/ws-isbm/RemoveSecurityTokens", Name="SecurityTokenFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RemoveSecurityTokensResponse RemoveSecurityTokens(RemoveSecurityTokensRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/RemoveSecurityTokens", ReplyAction="*")]
        System.IAsyncResult BeginRemoveSecurityTokens(RemoveSecurityTokensRequest request, System.AsyncCallback callback, object asyncState);
        
        RemoveSecurityTokensResponse EndRemoveSecurityTokens(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/DeleteChannel", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/DeleteChannel", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteChannel(string ChannelURI);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/DeleteChannel", ReplyAction="*")]
        System.IAsyncResult BeginDeleteChannel(string ChannelURI, System.AsyncCallback callback, object asyncState);
        
        void EndDeleteChannel(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/GetChannel", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/ws-isbm/GetChannel", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Channel")]
        Channel GetChannel(string ChannelURI);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/GetChannel", ReplyAction="*")]
        System.IAsyncResult BeginGetChannel(string ChannelURI, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="Channel")]
        Channel EndGetChannel(System.IAsyncResult result);
        
        // CODEGEN: Parameter 'Channel' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/ws-isbm/GetChannels", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Channel")]
        GetChannelsResponse GetChannels(GetChannelsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.openoandm.org/ws-isbm/GetChannels", ReplyAction="*")]
        System.IAsyncResult BeginGetChannels(GetChannelsRequest request, System.AsyncCallback callback, object asyncState);
        
        GetChannelsResponse EndGetChannels(System.IAsyncResult result);
    }
}

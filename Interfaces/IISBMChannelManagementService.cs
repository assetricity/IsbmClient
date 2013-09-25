namespace IsbmClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.openoandm.org/xml/ISBM/", ConfigurationName="IISBMChannelManagementService")]
    public interface IISBMChannelManagementService
    {
        
        // CODEGEN: Parameter 'SecurityToken' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/CreateChannel", ReplyAction="http://www.openoandm.org/xml/ISBM/CreateChannelResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/CreateChannel", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CreateChannelResponse CreateChannel(CreateChannelRequest request);
        
        // CODEGEN: Parameter 'SecurityToken' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/AddSecurityTokens" +
            "", ReplyAction="http://www.openoandm.org/xml/ISBM/AddSecurityTokens" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/AddSecurityTokens" +
            "", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AddSecurityTokensResponse AddSecurityTokens(AddSecurityTokensRequest request);
        
        // CODEGEN: Parameter 'SecurityToken' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/RemoveSecurityTok" +
            "ens", ReplyAction="http://www.openoandm.org/xml/ISBM/RemoveSecurityTok" +
            "ensResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/RemoveSecurityTok" +
            "ens", Name="ChannelFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(InvalidSecurityTokenFault), Action="http://www.openoandm.org/xml/ISBM/RemoveSecurityTok" +
            "ens", Name="InvalidSecurityTokenFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RemoveSecurityTokensResponse RemoveSecurityTokens(RemoveSecurityTokensRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/DeleteChannel", ReplyAction="http://www.openoandm.org/xml/ISBM/DeleteChannelResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/DeleteChannel", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteChannel(string ChannelURI);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/GetChannel", ReplyAction="http://www.openoandm.org/xml/ISBM/GetChannelRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ChannelFault), Action="http://www.openoandm.org/xml/ISBM/GetChannel", Name="ChannelFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Channel")]
        Channel GetChannel(string ChannelURI);
        
        // CODEGEN: Parameter 'Channel' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.openoandm.org/xml/ISBM/GetChannels", ReplyAction="http://www.openoandm.org/xml/ISBM/GetChannelsRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Channel")]
        GetChannelsResponse GetChannels(GetChannelsRequest request);
    }
}

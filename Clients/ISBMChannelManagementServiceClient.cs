namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ISBMChannelManagementServiceClient : System.ServiceModel.ClientBase<IISBMChannelManagementService>, IISBMChannelManagementService
    {
        
        public ISBMChannelManagementServiceClient()
        {
        }
        
        public ISBMChannelManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ISBMChannelManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMChannelManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ISBMChannelManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CreateChannelResponse IISBMChannelManagementService.CreateChannel(CreateChannelRequest request)
        {
            return base.Channel.CreateChannel(request);
        }
        
        public void CreateChannel(string ChannelURI, ChannelType ChannelType, string ChannelDescription, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            CreateChannelRequest inValue = new CreateChannelRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.ChannelType = ChannelType;
            inValue.ChannelDescription = ChannelDescription;
            inValue.SecurityToken = SecurityToken;
            CreateChannelResponse retVal = ((IISBMChannelManagementService)(this)).CreateChannel(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AddSecurityTokensResponse IISBMChannelManagementService.AddSecurityTokens(AddSecurityTokensRequest request)
        {
            return base.Channel.AddSecurityTokens(request);
        }
        
        public void AddSecurityTokens(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            AddSecurityTokensRequest inValue = new AddSecurityTokensRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.SecurityToken = SecurityToken;
            AddSecurityTokensResponse retVal = ((IISBMChannelManagementService)(this)).AddSecurityTokens(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RemoveSecurityTokensResponse IISBMChannelManagementService.RemoveSecurityTokens(RemoveSecurityTokensRequest request)
        {
            return base.Channel.RemoveSecurityTokens(request);
        }
        
        public void RemoveSecurityTokens(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            RemoveSecurityTokensRequest inValue = new RemoveSecurityTokensRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.SecurityToken = SecurityToken;
            RemoveSecurityTokensResponse retVal = ((IISBMChannelManagementService)(this)).RemoveSecurityTokens(inValue);
        }
        
        public void DeleteChannel(string ChannelURI)
        {
            base.Channel.DeleteChannel(ChannelURI);
        }
        
        public Channel GetChannel(string ChannelURI)
        {
            return base.Channel.GetChannel(ChannelURI);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetChannelsResponse IISBMChannelManagementService.GetChannels(GetChannelsRequest request)
        {
            return base.Channel.GetChannels(request);
        }
        
        public System.Collections.Generic.List<Channel> GetChannels()
        {
            GetChannelsRequest inValue = new GetChannelsRequest();
            GetChannelsResponse retVal = ((IISBMChannelManagementService)(this)).GetChannels(inValue);
            return retVal.Channel;
        }
    }
}

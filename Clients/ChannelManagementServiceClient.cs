namespace IsbmClient
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChannelManagementServiceClient : System.ServiceModel.ClientBase<IChannelManagementService>, IChannelManagementService
    {
        
        public ChannelManagementServiceClient()
        {
        }
        
        public ChannelManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ChannelManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ChannelManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ChannelManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CreateChannelResponse IChannelManagementService.CreateChannel(CreateChannelRequest request)
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
            CreateChannelResponse retVal = ((IChannelManagementService)(this)).CreateChannel(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IChannelManagementService.BeginCreateChannel(CreateChannelRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginCreateChannel(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginCreateChannel(string ChannelURI, ChannelType ChannelType, string ChannelDescription, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken, System.AsyncCallback callback, object asyncState)
        {
            CreateChannelRequest inValue = new CreateChannelRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.ChannelType = ChannelType;
            inValue.ChannelDescription = ChannelDescription;
            inValue.SecurityToken = SecurityToken;
            return ((IChannelManagementService)(this)).BeginCreateChannel(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CreateChannelResponse IChannelManagementService.EndCreateChannel(System.IAsyncResult result)
        {
            return base.Channel.EndCreateChannel(result);
        }
        
        public void EndCreateChannel(System.IAsyncResult result)
        {
            CreateChannelResponse retVal = ((IChannelManagementService)(this)).EndCreateChannel(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AddSecurityTokensResponse IChannelManagementService.AddSecurityTokens(AddSecurityTokensRequest request)
        {
            return base.Channel.AddSecurityTokens(request);
        }
        
        public void AddSecurityTokens(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            AddSecurityTokensRequest inValue = new AddSecurityTokensRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.SecurityToken = SecurityToken;
            AddSecurityTokensResponse retVal = ((IChannelManagementService)(this)).AddSecurityTokens(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IChannelManagementService.BeginAddSecurityTokens(AddSecurityTokensRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginAddSecurityTokens(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginAddSecurityTokens(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken, System.AsyncCallback callback, object asyncState)
        {
            AddSecurityTokensRequest inValue = new AddSecurityTokensRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.SecurityToken = SecurityToken;
            return ((IChannelManagementService)(this)).BeginAddSecurityTokens(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AddSecurityTokensResponse IChannelManagementService.EndAddSecurityTokens(System.IAsyncResult result)
        {
            return base.Channel.EndAddSecurityTokens(result);
        }
        
        public void EndAddSecurityTokens(System.IAsyncResult result)
        {
            AddSecurityTokensResponse retVal = ((IChannelManagementService)(this)).EndAddSecurityTokens(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RemoveSecurityTokensResponse IChannelManagementService.RemoveSecurityTokens(RemoveSecurityTokensRequest request)
        {
            return base.Channel.RemoveSecurityTokens(request);
        }
        
        public void RemoveSecurityTokens(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken)
        {
            RemoveSecurityTokensRequest inValue = new RemoveSecurityTokensRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.SecurityToken = SecurityToken;
            RemoveSecurityTokensResponse retVal = ((IChannelManagementService)(this)).RemoveSecurityTokens(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IChannelManagementService.BeginRemoveSecurityTokens(RemoveSecurityTokensRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginRemoveSecurityTokens(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginRemoveSecurityTokens(string ChannelURI, System.Collections.Generic.List<System.Xml.XmlElement> SecurityToken, System.AsyncCallback callback, object asyncState)
        {
            RemoveSecurityTokensRequest inValue = new RemoveSecurityTokensRequest();
            inValue.ChannelURI = ChannelURI;
            inValue.SecurityToken = SecurityToken;
            return ((IChannelManagementService)(this)).BeginRemoveSecurityTokens(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RemoveSecurityTokensResponse IChannelManagementService.EndRemoveSecurityTokens(System.IAsyncResult result)
        {
            return base.Channel.EndRemoveSecurityTokens(result);
        }
        
        public void EndRemoveSecurityTokens(System.IAsyncResult result)
        {
            RemoveSecurityTokensResponse retVal = ((IChannelManagementService)(this)).EndRemoveSecurityTokens(result);
        }
        
        public void DeleteChannel(string ChannelURI)
        {
            base.Channel.DeleteChannel(ChannelURI);
        }
        
        public System.IAsyncResult BeginDeleteChannel(string ChannelURI, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginDeleteChannel(ChannelURI, callback, asyncState);
        }
        
        public void EndDeleteChannel(System.IAsyncResult result)
        {
            base.Channel.EndDeleteChannel(result);
        }
        
        public Channel GetChannel(string ChannelURI)
        {
            return base.Channel.GetChannel(ChannelURI);
        }
        
        public System.IAsyncResult BeginGetChannel(string ChannelURI, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetChannel(ChannelURI, callback, asyncState);
        }
        
        public Channel EndGetChannel(System.IAsyncResult result)
        {
            return base.Channel.EndGetChannel(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetChannelsResponse IChannelManagementService.GetChannels(GetChannelsRequest request)
        {
            return base.Channel.GetChannels(request);
        }
        
        public System.Collections.Generic.List<Channel> GetChannels()
        {
            GetChannelsRequest inValue = new GetChannelsRequest();
            GetChannelsResponse retVal = ((IChannelManagementService)(this)).GetChannels(inValue);
            return retVal.Channel;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IChannelManagementService.BeginGetChannels(GetChannelsRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetChannels(request, callback, asyncState);
        }
        
        public System.IAsyncResult BeginGetChannels(System.AsyncCallback callback, object asyncState)
        {
            GetChannelsRequest inValue = new GetChannelsRequest();
            return ((IChannelManagementService)(this)).BeginGetChannels(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GetChannelsResponse IChannelManagementService.EndGetChannels(System.IAsyncResult result)
        {
            return base.Channel.EndGetChannels(result);
        }
        
        public System.Collections.Generic.List<Channel> EndGetChannels(System.IAsyncResult result)
        {
            GetChannelsResponse retVal = ((IChannelManagementService)(this)).EndGetChannels(result);
            return retVal.Channel;
        }
    }
}

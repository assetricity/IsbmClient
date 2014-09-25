namespace IsbmClient
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.openoandm.org/ws-isbm/")]
    public partial class Channel
    {
        
        private string channelURIField;
        
        private ChannelType channelTypeField;
        
        private string channelDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ChannelURI
        {
            get
            {
                return this.channelURIField;
            }
            set
            {
                this.channelURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ChannelType ChannelType
        {
            get
            {
                return this.channelTypeField;
            }
            set
            {
                this.channelTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ChannelDescription
        {
            get
            {
                return this.channelDescriptionField;
            }
            set
            {
                this.channelDescriptionField = value;
            }
        }
    }
}

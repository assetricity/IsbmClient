namespace IsbmClient
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.openoandm.org/xml/ISBM/")]
    public partial class Channel
    {
        
        private string channelURIField;
        
        private ChannelType channelTypeField;
        
        private string channelDescriptionField;
        
        /// <remarks/>
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

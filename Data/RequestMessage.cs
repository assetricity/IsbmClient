namespace IsbmClient
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.openoandm.org/xml/ISBM/")]
    public partial class RequestMessage
    {
        
        private string messageIDField;
        
        private System.Xml.XmlElement messageContentField;
        
        private string topicField;
        
        /// <remarks/>
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        public System.Xml.XmlElement MessageContent
        {
            get
            {
                return this.messageContentField;
            }
            set
            {
                this.messageContentField = value;
            }
        }
        
        /// <remarks/>
        public string Topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }
}

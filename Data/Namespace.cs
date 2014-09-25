namespace IsbmClient
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.openoandm.org/ws-isbm/")]
    public partial class Namespace
    {
        
        private string namespacePrefixField;
        
        private string namespaceNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string NamespacePrefix
        {
            get
            {
                return this.namespacePrefixField;
            }
            set
            {
                this.namespacePrefixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string NamespaceName
        {
            get
            {
                return this.namespaceNameField;
            }
            set
            {
                this.namespaceNameField = value;
            }
        }
    }
}

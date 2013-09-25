namespace IsbmClient
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.openoandm.org/xml/ISBM/")]
    public partial class Namespace
    {
        
        private string namespacePrefixField;
        
        private string namespaceNameField;
        
        /// <remarks/>
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

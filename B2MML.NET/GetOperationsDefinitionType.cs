namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("GetOperationsDefinition",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class GetOperationsDefinitionType {
    
        private TransApplicationAreaType applicationAreaField;
    
        private GetOperationsDefinitionTypeDataArea dataAreaField;
    
        private string releaseIDField;
    
        private string versionIDField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get {
                return this.applicationAreaField;
            }
            set {
                this.applicationAreaField = value;
            }
        }
    
        /// <remarks/>
        public GetOperationsDefinitionTypeDataArea DataArea {
            get {
                return this.dataAreaField;
            }
            set {
                this.dataAreaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string releaseID {
            get {
                return this.releaseIDField;
            }
            set {
                this.releaseIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string versionID {
            get {
                return this.versionIDField;
            }
            set {
                this.versionIDField = value;
            }
        }
    }
}
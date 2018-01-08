namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OperationsMaterialBillType {
    
        private IdentifierType idField;
    
        private DescriptionType descriptionField;
    
        private OperationsMaterialBillItemType[] operationsMaterialBillItemField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsMaterialBillItem")]
        public OperationsMaterialBillItemType[] OperationsMaterialBillItem {
            get {
                return this.operationsMaterialBillItemField;
            }
            set {
                this.operationsMaterialBillItemField = value;
            }
        }
    }
}
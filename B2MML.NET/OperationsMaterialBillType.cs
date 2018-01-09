namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OperationsMaterialBillType {
    
        private IdentifierType _idField;
    
        private DescriptionType _descriptionField;
    
        private OperationsMaterialBillItemType[] _operationsMaterialBillItemField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsMaterialBillItem")]
        public OperationsMaterialBillItemType[] OperationsMaterialBillItem {
            get => _operationsMaterialBillItemField;
            set => _operationsMaterialBillItemField = value;
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class QuantityValueType {
    
        private QuantityStringType quantityStringField;
    
        private DataTypeType dataTypeField;
    
        private UnitOfMeasureType unitOfMeasureField;
    
        private IdentifierType keyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public QuantityStringType QuantityString {
            get {
                return quantityStringField;
            }
            set {
                quantityStringField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DataTypeType DataType {
            get {
                return dataTypeField;
            }
            set {
                dataTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return unitOfMeasureField;
            }
            set {
                unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Key {
            get {
                return keyField;
            }
            set {
                keyField = value;
            }
        }
    }
}
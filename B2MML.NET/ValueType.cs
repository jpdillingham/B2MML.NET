namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ValueType {
    
        private ValueStringType _valueStringField;
    
        private DataTypeType _dataTypeField;
    
        private UnitOfMeasureType _unitOfMeasureField;
    
        private IdentifierType _keyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ValueStringType ValueString {
            get => _valueStringField;
            set => _valueStringField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DataTypeType DataType {
            get => _dataTypeField;
            set => _dataTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UnitOfMeasureType UnitOfMeasure {
            get => _unitOfMeasureField;
            set => _unitOfMeasureField = value;
        }
    
        /// <remarks/>
        public IdentifierType Key {
            get => _keyField;
            set => _keyField = value;
        }
    }
}
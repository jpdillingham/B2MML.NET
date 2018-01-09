namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Value", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchValueType {
    
        private ValueStringType[] _valueStringField;
    
        private DataInterpretationType _dataInterpretationField;
    
        private DataTypeType _dataTypeField;
    
        private UnitOfMeasureType _unitOfMeasureField;
    
        private EnumerationSetIDType[] _enumerationSetIDField;
    
        private string[] _textField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueString")]
        public ValueStringType[] ValueString {
            get {
                return _valueStringField;
            }
            set {
                _valueStringField = value;
            }
        }
    
        /// <remarks/>
        public DataInterpretationType DataInterpretation {
            get {
                return _dataInterpretationField;
            }
            set {
                _dataInterpretationField = value;
            }
        }
    
        /// <remarks/>
        public DataTypeType DataType {
            get {
                return _dataTypeField;
            }
            set {
                _dataTypeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return _unitOfMeasureField;
            }
            set {
                _unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSetID")]
        public EnumerationSetIDType[] EnumerationSetID {
            get {
                return _enumerationSetIDField;
            }
            set {
                _enumerationSetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return _textField;
            }
            set {
                _textField = value;
            }
        }
    }
}
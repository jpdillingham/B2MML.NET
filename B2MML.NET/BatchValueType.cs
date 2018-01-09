namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Value", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchValueType {
    
        private ValueStringType[] valueStringField;
    
        private DataInterpretationType dataInterpretationField;
    
        private DataTypeType dataTypeField;
    
        private UnitOfMeasureType unitOfMeasureField;
    
        private EnumerationSetIDType[] enumerationSetIDField;
    
        private string[] textField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueString")]
        public ValueStringType[] ValueString {
            get {
                return valueStringField;
            }
            set {
                valueStringField = value;
            }
        }
    
        /// <remarks/>
        public DataInterpretationType DataInterpretation {
            get {
                return dataInterpretationField;
            }
            set {
                dataInterpretationField = value;
            }
        }
    
        /// <remarks/>
        public DataTypeType DataType {
            get {
                return dataTypeField;
            }
            set {
                dataTypeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return unitOfMeasureField;
            }
            set {
                unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSetID")]
        public EnumerationSetIDType[] EnumerationSetID {
            get {
                return enumerationSetIDField;
            }
            set {
                enumerationSetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return textField;
            }
            set {
                textField = value;
            }
        }
    }
}
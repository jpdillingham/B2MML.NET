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
                return this.valueStringField;
            }
            set {
                this.valueStringField = value;
            }
        }
    
        /// <remarks/>
        public DataInterpretationType DataInterpretation {
            get {
                return this.dataInterpretationField;
            }
            set {
                this.dataInterpretationField = value;
            }
        }
    
        /// <remarks/>
        public DataTypeType DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSetID")]
        public EnumerationSetIDType[] EnumerationSetID {
            get {
                return this.enumerationSetIDField;
            }
            set {
                this.enumerationSetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
}
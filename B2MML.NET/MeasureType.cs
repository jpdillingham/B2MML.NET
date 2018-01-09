namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScaleReferenceType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(ScaledSizeType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedBatchSizeType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(NominalType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(MinType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(MaxType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MeasureType {
    
        private string unitCodeField;
    
        private string unitCodeListVersionIDField;
    
        private decimal valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCode {
            get {
                return unitCodeField;
            }
            set {
                unitCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string unitCodeListVersionID {
            get {
                return unitCodeListVersionIDField;
            }
            set {
                unitCodeListVersionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScaleReferenceType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(ScaledSizeType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedBatchSizeType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(NominalType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(MinType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(MaxType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MeasureType {
    
        private string _unitCodeField;
    
        private string _unitCodeListVersionIDField;
    
        private decimal _valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string UnitCode {
            get => _unitCodeField;
            set => _unitCodeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string UnitCodeListVersionID {
            get => _unitCodeListVersionIDField;
            set => _unitCodeListVersionIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public decimal Value {
            get => _valueField;
            set => _valueField = value;
        }
    }
}
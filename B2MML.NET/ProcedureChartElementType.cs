namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcedureChartElementType {
    
        private IdentifierType _idField;
    
        private TextType _labelField;
    
        private DescriptionType[] _descriptionField;
    
        private ProcedureChartElementTypeType _procedureChartElementType1Field;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public TextType Label {
            get => _labelField;
            set => _labelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcedureChartElementType")]
        public ProcedureChartElementTypeType ProcedureChartElementType1 {
            get => _procedureChartElementType1Field;
            set => _procedureChartElementType1Field = value;
        }
    }
}
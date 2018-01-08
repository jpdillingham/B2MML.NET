namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcedureChartElementType {
    
        private IdentifierType idField;
    
        private TextType labelField;
    
        private DescriptionType[] descriptionField;
    
        private ProcedureChartElementTypeType procedureChartElementType1Field;
    
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
        public TextType Label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcedureChartElementType")]
        public ProcedureChartElementTypeType ProcedureChartElementType1 {
            get {
                return this.procedureChartElementType1Field;
            }
            set {
                this.procedureChartElementType1Field = value;
            }
        }
    }
}
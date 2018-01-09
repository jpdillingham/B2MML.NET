namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ShowProcessSegmentInformationTypeDataArea {
    
        private TransShowType _showField;
    
        private ProcessSegmentInformationType[] _processSegmentInformationField;
    
        /// <remarks/>
        public TransShowType Show {
            get => _showField;
            set => _showField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentInformation")]
        public ProcessSegmentInformationType[] ProcessSegmentInformation {
            get => _processSegmentInformationField;
            set => _processSegmentInformationField = value;
        }
    }
}
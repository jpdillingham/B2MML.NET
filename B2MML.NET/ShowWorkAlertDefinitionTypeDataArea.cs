namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ShowWorkAlertDefinitionTypeDataArea {
    
        private TransShowType _showField;
    
        private WorkAlertDefinitionType[] _workAlertDefinitionField;
    
        /// <remarks/>
        public TransShowType Show {
            get {
                return _showField;
            }
            set {
                _showField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkAlertDefinition")]
        public WorkAlertDefinitionType[] WorkAlertDefinition {
            get {
                return _workAlertDefinitionField;
            }
            set {
                _workAlertDefinitionField = value;
            }
        }
    }
}
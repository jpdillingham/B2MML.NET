namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeWorkMasterTypeDataArea {
    
        private TransAcknowledgeType acknowledgeField;
    
        private WorkMasterType[] workMasterField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get {
                return acknowledgeField;
            }
            set {
                acknowledgeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkMaster")]
        public WorkMasterType[] WorkMaster {
            get {
                return workMasterField;
            }
            set {
                workMasterField = value;
            }
        }
    }
}
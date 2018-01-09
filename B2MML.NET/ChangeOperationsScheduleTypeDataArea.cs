namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeOperationsScheduleTypeDataArea {
    
        private TransChangeType changeField;
    
        private OperationsScheduleType[] operationsScheduleField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return this.changeField;
            }
            set {
                this.changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSchedule")]
        public OperationsScheduleType[] OperationsSchedule {
            get {
                return this.operationsScheduleField;
            }
            set {
                this.operationsScheduleField = value;
            }
        }
    }
}
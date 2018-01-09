namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AlarmDataType {
    
        private CodeType alarmEventField;
    
        private CodeType alarmTypeField;
    
        private ValueType[] alarmLimitField;
    
        private IdentifierType[] priorityField;
    
        /// <remarks/>
        public CodeType AlarmEvent {
            get {
                return alarmEventField;
            }
            set {
                alarmEventField = value;
            }
        }
    
        /// <remarks/>
        public CodeType AlarmType {
            get {
                return alarmTypeField;
            }
            set {
                alarmTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlarmLimit")]
        public ValueType[] AlarmLimit {
            get {
                return alarmLimitField;
            }
            set {
                alarmLimitField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Priority")]
        public IdentifierType[] Priority {
            get {
                return priorityField;
            }
            set {
                priorityField = value;
            }
        }
    }
}
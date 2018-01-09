namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AlarmDataType {
    
        private CodeType _alarmEventField;
    
        private CodeType _alarmTypeField;
    
        private ValueType[] _alarmLimitField;
    
        private IdentifierType[] _priorityField;
    
        /// <remarks/>
        public CodeType AlarmEvent {
            get => _alarmEventField;
            set => _alarmEventField = value;
        }
    
        /// <remarks/>
        public CodeType AlarmType {
            get => _alarmTypeField;
            set => _alarmTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlarmLimit")]
        public ValueType[] AlarmLimit {
            get => _alarmLimitField;
            set => _alarmLimitField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Priority")]
        public IdentifierType[] Priority {
            get => _priorityField;
            set => _priorityField = value;
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentConnection", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class EquipmentConnectionType {
    
        private IDType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ConnectionTypeType _connectionTypeField;
    
        private FromEquipmentIDType[] _fromEquipmentIDField;
    
        private ToEquipmentIDType[] _toEquipmentIDField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public ConnectionTypeType ConnectionType {
            get => _connectionTypeField;
            set => _connectionTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromEquipmentID")]
        public FromEquipmentIDType[] FromEquipmentID {
            get => _fromEquipmentIDField;
            set => _fromEquipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToEquipmentID")]
        public ToEquipmentIDType[] ToEquipmentID {
            get => _toEquipmentIDField;
            set => _toEquipmentIDField = value;
        }
    }
}
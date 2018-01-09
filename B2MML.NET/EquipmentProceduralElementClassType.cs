namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentProceduralElementClass",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class EquipmentProceduralElementClassType {
    
        private IDType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private EquipmentProceduralElementTypeType _equipmentProceduralElementTypeField;
    
        private BatchParameterType[] _parameterField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentProceduralElementTypeType EquipmentProceduralElementType {
            get {
                return _equipmentProceduralElementTypeField;
            }
            set {
                _equipmentProceduralElementTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return _parameterField;
            }
            set {
                _parameterField = value;
            }
        }
    }
}
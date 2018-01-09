namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentProceduralElementClass",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class EquipmentProceduralElementClassType {
    
        private IDType idField;
    
        private DescriptionType[] descriptionField;
    
        private EquipmentProceduralElementTypeType equipmentProceduralElementTypeField;
    
        private BatchParameterType[] parameterField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentProceduralElementTypeType EquipmentProceduralElementType {
            get {
                return equipmentProceduralElementTypeField;
            }
            set {
                equipmentProceduralElementTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    }
}
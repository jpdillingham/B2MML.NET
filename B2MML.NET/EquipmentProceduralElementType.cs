namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentProceduralElement",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class EquipmentProceduralElementType {
    
        private IDType idField;
    
        private DescriptionType[] descriptionField;
    
        private EquipmentProceduralElementTypeType equipmentProceduralElementType1Field;
    
        private object[] itemsField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementType")]
        public EquipmentProceduralElementTypeType EquipmentProceduralElementType1 {
            get {
                return equipmentProceduralElementType1Field;
            }
            set {
                equipmentProceduralElementType1Field = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementClassID",
             typeof(EquipmentProceduralElementClassIDType)),
         System.Xml.Serialization.XmlElementAttribute("Parameter", typeof(BatchParameterType))]
        public object[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}
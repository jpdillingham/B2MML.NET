namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentElement", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class EquipmentElementType {
    
        private IDType idField;
    
        private DescriptionType[] descriptionField;
    
        private EquipmentElementTypeType equipmentElementType1Field;
    
        private EquipmentElementLevelType equipmentElementLevelField;
    
        private ClassInstanceAssociationType[] classInstanceAssociationField;
    
        private EquipmentElementPropertyType[] propertyField;
    
        private EquipmentProceduralElementClassType[] equipmentProceduralElementClassField;
    
        private EquipmentProceduralElementType[] equipmentProceduralElementField;
    
        private EquipmentConnectionType[] equipmentConnectionField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementType")]
        public EquipmentElementTypeType EquipmentElementType1 {
            get {
                return equipmentElementType1Field;
            }
            set {
                equipmentElementType1Field = value;
            }
        }
    
        /// <remarks/>
        public EquipmentElementLevelType EquipmentElementLevel {
            get {
                return equipmentElementLevelField;
            }
            set {
                equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassInstanceAssociation")]
        public ClassInstanceAssociationType[] ClassInstanceAssociation {
            get {
                return classInstanceAssociationField;
            }
            set {
                classInstanceAssociationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public EquipmentElementPropertyType[] Property {
            get {
                return propertyField;
            }
            set {
                propertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementClass")]
        public EquipmentProceduralElementClassType[] EquipmentProceduralElementClass {
            get {
                return equipmentProceduralElementClassField;
            }
            set {
                equipmentProceduralElementClassField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElement")]
        public EquipmentProceduralElementType[] EquipmentProceduralElement {
            get {
                return equipmentProceduralElementField;
            }
            set {
                equipmentProceduralElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentConnection")]
        public EquipmentConnectionType[] EquipmentConnection {
            get {
                return equipmentConnectionField;
            }
            set {
                equipmentConnectionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement", typeof(EquipmentElementType)),
         System.Xml.Serialization.XmlElementAttribute("EquipmentElementID", typeof(EquipmentElementIDType))]
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
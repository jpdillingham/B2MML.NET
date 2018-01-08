namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("EquipmentElement", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementType")]
        public EquipmentElementTypeType EquipmentElementType1 {
            get {
                return this.equipmentElementType1Field;
            }
            set {
                this.equipmentElementType1Field = value;
            }
        }
    
        /// <remarks/>
        public EquipmentElementLevelType EquipmentElementLevel {
            get {
                return this.equipmentElementLevelField;
            }
            set {
                this.equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassInstanceAssociation")]
        public ClassInstanceAssociationType[] ClassInstanceAssociation {
            get {
                return this.classInstanceAssociationField;
            }
            set {
                this.classInstanceAssociationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public EquipmentElementPropertyType[] Property {
            get {
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementClass")]
        public EquipmentProceduralElementClassType[] EquipmentProceduralElementClass {
            get {
                return this.equipmentProceduralElementClassField;
            }
            set {
                this.equipmentProceduralElementClassField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElement")]
        public EquipmentProceduralElementType[] EquipmentProceduralElement {
            get {
                return this.equipmentProceduralElementField;
            }
            set {
                this.equipmentProceduralElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentConnection")]
        public EquipmentConnectionType[] EquipmentConnection {
            get {
                return this.equipmentConnectionField;
            }
            set {
                this.equipmentConnectionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement", typeof(EquipmentElementType))]
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementID", typeof(EquipmentElementIDType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
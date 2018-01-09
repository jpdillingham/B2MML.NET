namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentProceduralElement",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class EquipmentProceduralElementType {
    
        private IDType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private EquipmentProceduralElementTypeType _equipmentProceduralElementType1Field;
    
        private object[] _itemsField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementType")]
        public EquipmentProceduralElementTypeType EquipmentProceduralElementType1 {
            get => _equipmentProceduralElementType1Field;
            set => _equipmentProceduralElementType1Field = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementClassID",
             typeof(EquipmentProceduralElementClassIDType)),
         System.Xml.Serialization.XmlElementAttribute("Parameter", typeof(BatchParameterType))]
        public object[] Items {
            get => _itemsField;
            set => _itemsField = value;
        }
    }
}
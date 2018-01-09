﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentElement", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class EquipmentElementType {
    
        private IDType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private EquipmentElementTypeType _equipmentElementType1Field;
    
        private EquipmentElementLevelType _equipmentElementLevelField;
    
        private ClassInstanceAssociationType[] _classInstanceAssociationField;
    
        private List<EquipmentElementPropertyType> _propertyField;
    
        private List<EquipmentProceduralElementClassType> _equipmentProceduralElementClassField;
    
        private List<EquipmentProceduralElementType> _equipmentProceduralElementField;
    
        private List<EquipmentConnectionType> _equipmentConnectionField;
    
        private List<object> _itemsField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementType")]
        public EquipmentElementTypeType EquipmentElementType1 {
            get => _equipmentElementType1Field;
            set => _equipmentElementType1Field = value;
        }
    
        /// <remarks/>
        public EquipmentElementLevelType EquipmentElementLevel {
            get => _equipmentElementLevelField;
            set => _equipmentElementLevelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassInstanceAssociation")]
        public ClassInstanceAssociationType[] ClassInstanceAssociation {
            get => _classInstanceAssociationField;
            set => _classInstanceAssociationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public List<EquipmentElementPropertyType> Property {
            get => _propertyField;
            set => _propertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElementClass")]
        public List<EquipmentProceduralElementClassType> EquipmentProceduralElementClass {
            get => _equipmentProceduralElementClassField;
            set => _equipmentProceduralElementClassField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProceduralElement")]
        public List<EquipmentProceduralElementType> EquipmentProceduralElement {
            get => _equipmentProceduralElementField;
            set => _equipmentProceduralElementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentConnection")]
        public List<EquipmentConnectionType> EquipmentConnection {
            get => _equipmentConnectionField;
            set => _equipmentConnectionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement", typeof(EquipmentElementType)),
         System.Xml.Serialization.XmlElementAttribute("EquipmentElementID", typeof(EquipmentElementIDType))]
        public List<object> Items {
            get => _itemsField;
            set => _itemsField = value;
        }
    }
}
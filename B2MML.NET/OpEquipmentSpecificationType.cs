﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class OpEquipmentSpecificationType {
    
        private EquipmentClassIDType[] _equipmentClassIDField;
    
        private EquipmentIDType[] _equipmentIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private EquipmentUseType _equipmentUseField;
    
        private List<QuantityValueType> _quantityField;
    
        private List<OpEquipmentSpecificationPropertyType> _equipmentSpecificationPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get => _equipmentClassIDField;
            set => _equipmentClassIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public EquipmentIDType[] EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public EquipmentUseType EquipmentUse {
            get => _equipmentUseField;
            set => _equipmentUseField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public List<QuantityValueType> Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecificationProperty")]
        public List<OpEquipmentSpecificationPropertyType> EquipmentSpecificationProperty {
            get => _equipmentSpecificationPropertyField;
            set => _equipmentSpecificationPropertyField = value;
        }
    }
}
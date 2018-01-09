using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentProceduralElementClass",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class EquipmentProceduralElementClassType {
    
        private IDType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private EquipmentProceduralElementTypeType _equipmentProceduralElementTypeField;
    
        private List<BatchParameterType> _parameterField;
    
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
        public EquipmentProceduralElementTypeType EquipmentProceduralElementType {
            get => _equipmentProceduralElementTypeField;
            set => _equipmentProceduralElementTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public List<BatchParameterType> Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    }
}
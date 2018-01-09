using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAssetClass", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class PhysicalAssetClassType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private List<NameType> _manufacturerField;
    
        private List<PhysicalAssetClassPropertyType> _physicalAssetClassPropertyField;
    
        private PhysicalAssetIDType[] _physicalAssetIDField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] _physicalAssetCapabilityTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
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
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Manufacturer")]
        public List<NameType> Manufacturer {
            get => _manufacturerField;
            set => _manufacturerField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassProperty")]
        public List<PhysicalAssetClassPropertyType> PhysicalAssetClassProperty {
            get => _physicalAssetClassPropertyField;
            set => _physicalAssetClassPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public PhysicalAssetIDType[] PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get => _physicalAssetCapabilityTestSpecificationIDField;
            set => _physicalAssetCapabilityTestSpecificationIDField = value;
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAssetClass", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class PhysicalAssetClassType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private NameType[] manufacturerField;
    
        private PhysicalAssetClassPropertyType[] physicalAssetClassPropertyField;
    
        private PhysicalAssetIDType[] physicalAssetIDField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] physicalAssetCapabilityTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Manufacturer")]
        public NameType[] Manufacturer {
            get {
                return manufacturerField;
            }
            set {
                manufacturerField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassProperty")]
        public PhysicalAssetClassPropertyType[] PhysicalAssetClassProperty {
            get {
                return physicalAssetClassPropertyField;
            }
            set {
                physicalAssetClassPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public PhysicalAssetIDType[] PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get {
                return physicalAssetCapabilityTestSpecificationIDField;
            }
            set {
                physicalAssetCapabilityTestSpecificationIDField = value;
            }
        }
    }
}
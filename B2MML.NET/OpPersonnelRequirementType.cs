namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpPersonnelRequirementType {
    
        private PersonnelClassIDType[] personnelClassIDField;
    
        private PersonIDType[] personIDField;
    
        private DescriptionType[] descriptionField;
    
        private PersonnelUseType personnelUseField;
    
        private QuantityValueType[] quantityField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OpPersonnelRequirementPropertyType[] personnelRequirementPropertyField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelClassID")]
        public PersonnelClassIDType[] PersonnelClassID {
            get {
                return personnelClassIDField;
            }
            set {
                personnelClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonID")]
        public PersonIDType[] PersonID {
            get {
                return personIDField;
            }
            set {
                personIDField = value;
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
        public PersonnelUseType PersonnelUse {
            get {
                return personnelUseField;
            }
            set {
                personnelUseField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return quantityField;
            }
            set {
                quantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirementProperty")]
        public OpPersonnelRequirementPropertyType[] PersonnelRequirementProperty {
            get {
                return personnelRequirementPropertyField;
            }
            set {
                personnelRequirementPropertyField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return requiredByRequestedSegmentResponseField;
            }
            set {
                requiredByRequestedSegmentResponseField = value;
            }
        }
    }
}
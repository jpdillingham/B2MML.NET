namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpPhysicalAssetActualType {
    
        private PhysicalAssetClassIDType[] _physicalAssetClassIDField;
    
        private PhysicalAssetIDType[] _physicalAssetIDField;
    
        private DescriptionType[] _descriptionField;
    
        private QuantityValueType[] _quantityField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OpPhysicalAssetActualPropertyType[] _physicalAssetActualPropertyField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get {
                return _physicalAssetClassIDField;
            }
            set {
                _physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public PhysicalAssetIDType[] PhysicalAssetID {
            get {
                return _physicalAssetIDField;
            }
            set {
                _physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return _quantityField;
            }
            set {
                _quantityField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActualProperty")]
        public OpPhysicalAssetActualPropertyType[] PhysicalAssetActualProperty {
            get {
                return _physicalAssetActualPropertyField;
            }
            set {
                _physicalAssetActualPropertyField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return _requiredByRequestedSegmentResponseField;
            }
            set {
                _requiredByRequestedSegmentResponseField = value;
            }
        }
    }
}
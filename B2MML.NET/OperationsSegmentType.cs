namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OperationsSegmentType {
    
        private IdentifierType idField;
    
        private DescriptionType descriptionField;
    
        private OperationsTypeType operationsTypeField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private string durationField;
    
        private ProcessSegmentIDType[] processSegmentIDField;
    
        private ParameterType[] parameterField;
    
        private OpPersonnelSpecificationType[] personnelSpecificationField;
    
        private OpEquipmentSpecificationType[] equipmentSpecificationField;
    
        private OpPhysicalAssetSpecificationType[] physicalAssetSpecificationField;
    
        private OpMaterialSpecificationType[] materialSpecificationField;
    
        private SegmentDependencyType[] segmentDependencyField;
    
        private OperationsSegmentType[] operationsSegmentField;
    
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
        public DescriptionType Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return operationsTypeField;
            }
            set {
                operationsTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get {
                return durationField;
            }
            set {
                durationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return processSegmentIDField;
            }
            set {
                processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecification")]
        public OpPersonnelSpecificationType[] PersonnelSpecification {
            get {
                return personnelSpecificationField;
            }
            set {
                personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public OpEquipmentSpecificationType[] EquipmentSpecification {
            get {
                return equipmentSpecificationField;
            }
            set {
                equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public OpPhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return physicalAssetSpecificationField;
            }
            set {
                physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public OpMaterialSpecificationType[] MaterialSpecification {
            get {
                return materialSpecificationField;
            }
            set {
                materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentDependency")]
        public SegmentDependencyType[] SegmentDependency {
            get {
                return segmentDependencyField;
            }
            set {
                segmentDependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSegment")]
        public OperationsSegmentType[] OperationsSegment {
            get {
                return operationsSegmentField;
            }
            set {
                operationsSegmentField = value;
            }
        }
    }
}
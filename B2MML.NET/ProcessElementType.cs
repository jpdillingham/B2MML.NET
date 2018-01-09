namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProcessElement", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProcessElementType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ProcessElementTypeType processElementType1Field;
    
        private LifeCycleStateType lifeCycleStateField;
    
        private SequenceOrderType sequenceOrderField;
    
        private NumericType sequencePathField;
    
        private GRecipeMaterialsType[] materialsField;
    
        private DirectedLinkType[] directedLinkField;
    
        private ProcedureChartElementType[] procedureChartElementField;
    
        private ProcessElementType[] processElementField;
    
        private ProcessElementParameterType[] processElementParameterField;
    
        private ResourceConstraintType[] resourceConstraintField;
    
        private GROtherInformationType[] otherInformationField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementType")]
        public ProcessElementTypeType ProcessElementType1 {
            get {
                return processElementType1Field;
            }
            set {
                processElementType1Field = value;
            }
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get {
                return lifeCycleStateField;
            }
            set {
                lifeCycleStateField = value;
            }
        }
    
        /// <remarks/>
        public SequenceOrderType SequenceOrder {
            get {
                return sequenceOrderField;
            }
            set {
                sequenceOrderField = value;
            }
        }
    
        /// <remarks/>
        public NumericType SequencePath {
            get {
                return sequencePathField;
            }
            set {
                sequencePathField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Materials")]
        public GRecipeMaterialsType[] Materials {
            get {
                return materialsField;
            }
            set {
                materialsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DirectedLink")]
        public DirectedLinkType[] DirectedLink {
            get {
                return directedLinkField;
            }
            set {
                directedLinkField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcedureChartElement")]
        public ProcedureChartElementType[] ProcedureChartElement {
            get {
                return procedureChartElementField;
            }
            set {
                procedureChartElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElement")]
        public ProcessElementType[] ProcessElement {
            get {
                return processElementField;
            }
            set {
                processElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameter")]
        public ProcessElementParameterType[] ProcessElementParameter {
            get {
                return processElementParameterField;
            }
            set {
                processElementParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraint")]
        public ResourceConstraintType[] ResourceConstraint {
            get {
                return resourceConstraintField;
            }
            set {
                resourceConstraintField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public GROtherInformationType[] OtherInformation {
            get {
                return otherInformationField;
            }
            set {
                otherInformationField = value;
            }
        }
    }
}
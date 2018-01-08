namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("ProcessElement", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementType")]
        public ProcessElementTypeType ProcessElementType1 {
            get {
                return this.processElementType1Field;
            }
            set {
                this.processElementType1Field = value;
            }
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get {
                return this.lifeCycleStateField;
            }
            set {
                this.lifeCycleStateField = value;
            }
        }
    
        /// <remarks/>
        public SequenceOrderType SequenceOrder {
            get {
                return this.sequenceOrderField;
            }
            set {
                this.sequenceOrderField = value;
            }
        }
    
        /// <remarks/>
        public NumericType SequencePath {
            get {
                return this.sequencePathField;
            }
            set {
                this.sequencePathField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Materials")]
        public GRecipeMaterialsType[] Materials {
            get {
                return this.materialsField;
            }
            set {
                this.materialsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DirectedLink")]
        public DirectedLinkType[] DirectedLink {
            get {
                return this.directedLinkField;
            }
            set {
                this.directedLinkField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcedureChartElement")]
        public ProcedureChartElementType[] ProcedureChartElement {
            get {
                return this.procedureChartElementField;
            }
            set {
                this.procedureChartElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElement")]
        public ProcessElementType[] ProcessElement {
            get {
                return this.processElementField;
            }
            set {
                this.processElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameter")]
        public ProcessElementParameterType[] ProcessElementParameter {
            get {
                return this.processElementParameterField;
            }
            set {
                this.processElementParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraint")]
        public ResourceConstraintType[] ResourceConstraint {
            get {
                return this.resourceConstraintField;
            }
            set {
                this.resourceConstraintField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public GROtherInformationType[] OtherInformation {
            get {
                return this.otherInformationField;
            }
            set {
                this.otherInformationField = value;
            }
        }
    }
}
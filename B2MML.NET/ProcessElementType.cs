using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProcessElement", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class ProcessElementType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private ProcessElementTypeType _processElementType1Field;
    
        private LifeCycleStateType _lifeCycleStateField;
    
        private SequenceOrderType _sequenceOrderField;
    
        private NumericType _sequencePathField;
    
        private List<GRecipeMaterialsType> _materialsField;
    
        private List<DirectedLinkType> _directedLinkField;
    
        private List<ProcedureChartElementType> _procedureChartElementField;
    
        private List<ProcessElementType> _processElementField;
    
        private List<ProcessElementParameterType> _processElementParameterField;
    
        private List<ResourceConstraintType> _resourceConstraintField;
    
        private GROtherInformationType[] _otherInformationField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementType")]
        public ProcessElementTypeType ProcessElementType1 {
            get => _processElementType1Field;
            set => _processElementType1Field = value;
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get => _lifeCycleStateField;
            set => _lifeCycleStateField = value;
        }
    
        /// <remarks/>
        public SequenceOrderType SequenceOrder {
            get => _sequenceOrderField;
            set => _sequenceOrderField = value;
        }
    
        /// <remarks/>
        public NumericType SequencePath {
            get => _sequencePathField;
            set => _sequencePathField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Materials")]
        public List<GRecipeMaterialsType> Materials {
            get => _materialsField;
            set => _materialsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DirectedLink")]
        public List<DirectedLinkType> DirectedLink {
            get => _directedLinkField;
            set => _directedLinkField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcedureChartElement")]
        public List<ProcedureChartElementType> ProcedureChartElement {
            get => _procedureChartElementField;
            set => _procedureChartElementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElement")]
        public List<ProcessElementType> ProcessElement {
            get => _processElementField;
            set => _processElementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameter")]
        public List<ProcessElementParameterType> ProcessElementParameter {
            get => _processElementParameterField;
            set => _processElementParameterField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraint")]
        public List<ResourceConstraintType> ResourceConstraint {
            get => _resourceConstraintField;
            set => _resourceConstraintField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public GROtherInformationType[] OtherInformation {
            get => _otherInformationField;
            set => _otherInformationField = value;
        }
    }
}
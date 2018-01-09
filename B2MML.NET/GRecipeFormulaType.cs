namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeFormulaType {
    
        private DescriptionType[] _descriptionField;
    
        private GRecipeMaterialsType _processInputsField;
    
        private GRecipeMaterialsType _processOutputsField;
    
        private GRecipeMaterialsType _processIntermediatesField;
    
        private ProcessElementParameterType[] _processElementParameterField;
    
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
        public GRecipeMaterialsType ProcessInputs {
            get {
                return _processInputsField;
            }
            set {
                _processInputsField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessOutputs {
            get {
                return _processOutputsField;
            }
            set {
                _processOutputsField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessIntermediates {
            get {
                return _processIntermediatesField;
            }
            set {
                _processIntermediatesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameter")]
        public ProcessElementParameterType[] ProcessElementParameter {
            get {
                return _processElementParameterField;
            }
            set {
                _processElementParameterField = value;
            }
        }
    }
}
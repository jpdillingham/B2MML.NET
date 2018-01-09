using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GRecipeFormulaType {
    
        private List<DescriptionType> _descriptionField;
    
        private GRecipeMaterialsType _processInputsField;
    
        private GRecipeMaterialsType _processOutputsField;
    
        private GRecipeMaterialsType _processIntermediatesField;
    
        private List<ProcessElementParameterType> _processElementParameterField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessInputs {
            get => _processInputsField;
            set => _processInputsField = value;
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessOutputs {
            get => _processOutputsField;
            set => _processOutputsField = value;
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessIntermediates {
            get => _processIntermediatesField;
            set => _processIntermediatesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameter")]
        public List<ProcessElementParameterType> ProcessElementParameter {
            get => _processElementParameterField;
            set => _processElementParameterField = value;
        }
    }
}
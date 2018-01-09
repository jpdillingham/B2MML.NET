using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProcedureLogic", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class ProcedureLogicType {
    
        private List<LinkType> _linkField;
    
        private List<StepType> _stepField;
    
        private List<TransitionType> _transitionField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public List<LinkType> Link {
            get => _linkField;
            set => _linkField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Step")]
        public List<StepType> Step {
            get => _stepField;
            set => _stepField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transition")]
        public List<TransitionType> Transition {
            get => _transitionField;
            set => _transitionField = value;
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProcedureLogic", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProcedureLogicType {
    
        private LinkType[] _linkField;
    
        private StepType[] _stepField;
    
        private TransitionType[] _transitionField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public LinkType[] Link {
            get => _linkField;
            set => _linkField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Step")]
        public StepType[] Step {
            get => _stepField;
            set => _stepField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transition")]
        public TransitionType[] Transition {
            get => _transitionField;
            set => _transitionField = value;
        }
    }
}
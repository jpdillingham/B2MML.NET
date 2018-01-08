namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("ProcedureLogic", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class ProcedureLogicType {
    
        private LinkType[] linkField;
    
        private StepType[] stepField;
    
        private TransitionType[] transitionField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Link")]
        public LinkType[] Link {
            get {
                return this.linkField;
            }
            set {
                this.linkField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Step")]
        public StepType[] Step {
            get {
                return this.stepField;
            }
            set {
                this.stepField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transition")]
        public TransitionType[] Transition {
            get {
                return this.transitionField;
            }
            set {
                this.transitionField = value;
            }
        }
    }
}
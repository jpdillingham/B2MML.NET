namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Constraint", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class ConstraintType {
    
        private IDType idField;
    
        private ConditionType conditionField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public ConditionType Condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Link", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class LinkType {
    
        private IDType idField;
    
        private FromIDType[] fromIDField;
    
        private ToIDType[] toIDField;
    
        private LinkTypeType linkType1Field;
    
        private DepictionType depictionField;
    
        private EvaluationOrderType evaluationOrderField;
    
        private DescriptionType[] descriptionField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("FromID")]
        public FromIDType[] FromID {
            get {
                return this.fromIDField;
            }
            set {
                this.fromIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToID")]
        public ToIDType[] ToID {
            get {
                return this.toIDField;
            }
            set {
                this.toIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinkType")]
        public LinkTypeType LinkType1 {
            get {
                return this.linkType1Field;
            }
            set {
                this.linkType1Field = value;
            }
        }
    
        /// <remarks/>
        public DepictionType Depiction {
            get {
                return this.depictionField;
            }
            set {
                this.depictionField = value;
            }
        }
    
        /// <remarks/>
        public EvaluationOrderType EvaluationOrder {
            get {
                return this.evaluationOrderField;
            }
            set {
                this.evaluationOrderField = value;
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
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeMaterialType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType materialIDField;
    
        private NumericType orderField;
    
        private QuantityValueType amountField;
    
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
        public IdentifierType MaterialID {
            get {
                return this.materialIDField;
            }
            set {
                this.materialIDField = value;
            }
        }
    
        /// <remarks/>
        public NumericType Order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
    
        /// <remarks/>
        public QuantityValueType Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
}
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
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType MaterialID {
            get {
                return materialIDField;
            }
            set {
                materialIDField = value;
            }
        }
    
        /// <remarks/>
        public NumericType Order {
            get {
                return orderField;
            }
            set {
                orderField = value;
            }
        }
    
        /// <remarks/>
        public QuantityValueType Amount {
            get {
                return amountField;
            }
            set {
                amountField = value;
            }
        }
    }
}
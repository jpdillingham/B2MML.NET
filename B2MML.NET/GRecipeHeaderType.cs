namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeHeaderType {
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType derivedFromIDField;
    
        private IdentifierType[] productIDField;
    
        private DescriptionType[] description1Field;
    
        private NameType[] productNameField;
    
        private ValueType[] batchSizeField;
    
        private DateTimeType effectiveDateField;
    
        private DateTimeType expirationDateField;
    
        private HeaderPropertyType headerPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=0)]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IdentifierType DerivedFromID {
            get {
                return derivedFromIDField;
            }
            set {
                derivedFromIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID", Order=2)]
        public IdentifierType[] ProductID {
            get {
                return productIDField;
            }
            set {
                productIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=3)]
        public DescriptionType[] Description1 {
            get {
                return description1Field;
            }
            set {
                description1Field = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductName", Order=4)]
        public NameType[] ProductName {
            get {
                return productNameField;
            }
            set {
                productNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchSize", Order=5)]
        public ValueType[] BatchSize {
            get {
                return batchSizeField;
            }
            set {
                batchSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public DateTimeType EffectiveDate {
            get {
                return effectiveDateField;
            }
            set {
                effectiveDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public DateTimeType ExpirationDate {
            get {
                return expirationDateField;
            }
            set {
                expirationDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public HeaderPropertyType HeaderProperty {
            get {
                return headerPropertyField;
            }
            set {
                headerPropertyField = value;
            }
        }
    }
}
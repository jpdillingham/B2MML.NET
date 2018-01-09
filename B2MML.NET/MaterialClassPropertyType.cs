namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MaterialClassPropertyType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ValueType[] valueField;
    
        private MaterialClassPropertyType[] materialClassPropertyField;
    
        private MaterialTestSpecificationIDType[] materialTestSpecificationIDField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassProperty")]
        public MaterialClassPropertyType[] MaterialClassProperty {
            get {
                return materialClassPropertyField;
            }
            set {
                materialClassPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpecificationID")]
        public MaterialTestSpecificationIDType[] MaterialTestSpecificationID {
            get {
                return materialTestSpecificationIDField;
            }
            set {
                materialTestSpecificationIDField = value;
            }
        }
    }
}
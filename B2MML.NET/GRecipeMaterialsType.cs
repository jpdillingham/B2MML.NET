namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeMaterialsType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private MaterialsTypeType materialsTypeField;
    
        private GRecipeMaterialType[] materialField;
    
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
        public MaterialsTypeType MaterialsType {
            get {
                return materialsTypeField;
            }
            set {
                materialsTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Material")]
        public GRecipeMaterialType[] Material {
            get {
                return materialField;
            }
            set {
                materialField = value;
            }
        }
    }
}
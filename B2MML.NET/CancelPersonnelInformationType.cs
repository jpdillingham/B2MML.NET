namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("CancelPersonnelInformation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class CancelPersonnelInformationType {
    
        private TransApplicationAreaType _applicationAreaField;
    
        private CancelPersonnelInformationTypeDataArea _dataAreaField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get => _applicationAreaField;
            set => _applicationAreaField = value;
        }
    
        /// <remarks/>
        public CancelPersonnelInformationTypeDataArea DataArea {
            get => _dataAreaField;
            set => _dataAreaField = value;
        }
    }
}
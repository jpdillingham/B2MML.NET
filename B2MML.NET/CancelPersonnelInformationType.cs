namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("CancelPersonnelInformation", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class CancelPersonnelInformationType {
    
        private TransApplicationAreaType applicationAreaField;
    
        private CancelPersonnelInformationTypeDataArea dataAreaField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get {
                return this.applicationAreaField;
            }
            set {
                this.applicationAreaField = value;
            }
        }
    
        /// <remarks/>
        public CancelPersonnelInformationTypeDataArea DataArea {
            get {
                return this.dataAreaField;
            }
            set {
                this.dataAreaField = value;
            }
        }
    }
}
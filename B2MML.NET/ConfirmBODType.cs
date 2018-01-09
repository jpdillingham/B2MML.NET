using System.Xml.Serialization;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ConfirmBOD", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ConfirmBODType
    {

        private TransApplicationAreaType applicationAreaField;

        private ConfirmBODTypeDataArea dataAreaField;

        /// <remarks/>
        public TransApplicationAreaType ApplicationArea
        {
            get { return this.applicationAreaField; }
            set { this.applicationAreaField = value; }
        }

        /// <remarks/>
        public ConfirmBODTypeDataArea DataArea
        {
            get { return this.dataAreaField; }
            set { this.dataAreaField = value; }
        }
    }

}
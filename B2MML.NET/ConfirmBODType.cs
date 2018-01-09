using System.Xml.Serialization;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     XmlRootAttribute("ConfirmBOD", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ConfirmBODType
    {

        private TransApplicationAreaType applicationAreaField;

        private ConfirmBODTypeDataArea dataAreaField;

        /// <remarks/>
        public TransApplicationAreaType ApplicationArea
        {
            get { return applicationAreaField; }
            set { applicationAreaField = value; }
        }

        /// <remarks/>
        public ConfirmBODTypeDataArea DataArea
        {
            get { return dataAreaField; }
            set { dataAreaField = value; }
        }
    }

}
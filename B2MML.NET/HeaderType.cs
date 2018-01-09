namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Header", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class HeaderType {
    
        private ModificationLogType[] modificationLogField;
    
        private ApprovalHistoryType[] approvalHistoryField;
    
        private EffectiveDateType effectiveDateField;
    
        private ExpirationDateType expirationDateField;
    
        private ProductIDType productIDField;
    
        private ProductNameType productNameField;
    
        private BatchSizeType batchSizeField;
    
        private ActualProductProducedType[] actualProductProducedField;
    
        private BatchStatusType statusField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModificationLog")]
        public ModificationLogType[] ModificationLog {
            get {
                return modificationLogField;
            }
            set {
                modificationLogField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApprovalHistory")]
        public ApprovalHistoryType[] ApprovalHistory {
            get {
                return approvalHistoryField;
            }
            set {
                approvalHistoryField = value;
            }
        }
    
        /// <remarks/>
        public EffectiveDateType EffectiveDate {
            get {
                return effectiveDateField;
            }
            set {
                effectiveDateField = value;
            }
        }
    
        /// <remarks/>
        public ExpirationDateType ExpirationDate {
            get {
                return expirationDateField;
            }
            set {
                expirationDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get {
                return productIDField;
            }
            set {
                productIDField = value;
            }
        }
    
        /// <remarks/>
        public ProductNameType ProductName {
            get {
                return productNameField;
            }
            set {
                productNameField = value;
            }
        }
    
        /// <remarks/>
        public BatchSizeType BatchSize {
            get {
                return batchSizeField;
            }
            set {
                batchSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualProductProduced")]
        public ActualProductProducedType[] ActualProductProduced {
            get {
                return actualProductProducedField;
            }
            set {
                actualProductProducedField = value;
            }
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get {
                return statusField;
            }
            set {
                statusField = value;
            }
        }
    }
}
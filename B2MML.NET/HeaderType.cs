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
                return this.modificationLogField;
            }
            set {
                this.modificationLogField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApprovalHistory")]
        public ApprovalHistoryType[] ApprovalHistory {
            get {
                return this.approvalHistoryField;
            }
            set {
                this.approvalHistoryField = value;
            }
        }
    
        /// <remarks/>
        public EffectiveDateType EffectiveDate {
            get {
                return this.effectiveDateField;
            }
            set {
                this.effectiveDateField = value;
            }
        }
    
        /// <remarks/>
        public ExpirationDateType ExpirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get {
                return this.productIDField;
            }
            set {
                this.productIDField = value;
            }
        }
    
        /// <remarks/>
        public ProductNameType ProductName {
            get {
                return this.productNameField;
            }
            set {
                this.productNameField = value;
            }
        }
    
        /// <remarks/>
        public BatchSizeType BatchSize {
            get {
                return this.batchSizeField;
            }
            set {
                this.batchSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualProductProduced")]
        public ActualProductProducedType[] ActualProductProduced {
            get {
                return this.actualProductProducedField;
            }
            set {
                this.actualProductProducedField = value;
            }
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
}
namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Header", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class HeaderType {
    
        private ModificationLogType[] _modificationLogField;
    
        private ApprovalHistoryType[] _approvalHistoryField;
    
        private EffectiveDateType _effectiveDateField;
    
        private ExpirationDateType _expirationDateField;
    
        private ProductIDType _productIDField;
    
        private ProductNameType _productNameField;
    
        private BatchSizeType _batchSizeField;
    
        private ActualProductProducedType[] _actualProductProducedField;
    
        private BatchStatusType _statusField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModificationLog")]
        public ModificationLogType[] ModificationLog {
            get {
                return _modificationLogField;
            }
            set {
                _modificationLogField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApprovalHistory")]
        public ApprovalHistoryType[] ApprovalHistory {
            get {
                return _approvalHistoryField;
            }
            set {
                _approvalHistoryField = value;
            }
        }
    
        /// <remarks/>
        public EffectiveDateType EffectiveDate {
            get {
                return _effectiveDateField;
            }
            set {
                _effectiveDateField = value;
            }
        }
    
        /// <remarks/>
        public ExpirationDateType ExpirationDate {
            get {
                return _expirationDateField;
            }
            set {
                _expirationDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get {
                return _productIDField;
            }
            set {
                _productIDField = value;
            }
        }
    
        /// <remarks/>
        public ProductNameType ProductName {
            get {
                return _productNameField;
            }
            set {
                _productNameField = value;
            }
        }
    
        /// <remarks/>
        public BatchSizeType BatchSize {
            get {
                return _batchSizeField;
            }
            set {
                _batchSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualProductProduced")]
        public ActualProductProducedType[] ActualProductProduced {
            get {
                return _actualProductProducedField;
            }
            set {
                _actualProductProducedField = value;
            }
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get {
                return _statusField;
            }
            set {
                _statusField = value;
            }
        }
    }
}
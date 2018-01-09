namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OrderedDataType {
    
        private NumericType _orderIndexField;
    
        private DateTimeType _timeValueField;
    
        private DataValueType[] _dataValueField;
    
        /// <remarks/>
        public NumericType OrderIndex {
            get {
                return _orderIndexField;
            }
            set {
                _orderIndexField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType TimeValue {
            get {
                return _timeValueField;
            }
            set {
                _timeValueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataValue")]
        public DataValueType[] DataValue {
            get {
                return _dataValueField;
            }
            set {
                _dataValueField = value;
            }
        }
    }
}
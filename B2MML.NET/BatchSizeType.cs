namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchSize", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchSizeType {
    
        private NominalType _nominalField;
    
        private MinType _minField;
    
        private MaxType _maxField;
    
        private ScaleReferenceType _scaleReferenceField;
    
        private ScaledSizeType _scaledSizeField;
    
        private UnitOfMeasureType _unitOfMeasureField;
    
        /// <remarks/>
        public NominalType Nominal {
            get {
                return _nominalField;
            }
            set {
                _nominalField = value;
            }
        }
    
        /// <remarks/>
        public MinType Min {
            get {
                return _minField;
            }
            set {
                _minField = value;
            }
        }
    
        /// <remarks/>
        public MaxType Max {
            get {
                return _maxField;
            }
            set {
                _maxField = value;
            }
        }
    
        /// <remarks/>
        public ScaleReferenceType ScaleReference {
            get {
                return _scaleReferenceField;
            }
            set {
                _scaleReferenceField = value;
            }
        }
    
        /// <remarks/>
        public ScaledSizeType ScaledSize {
            get {
                return _scaledSizeField;
            }
            set {
                _scaledSizeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return _unitOfMeasureField;
            }
            set {
                _unitOfMeasureField = value;
            }
        }
    }
}
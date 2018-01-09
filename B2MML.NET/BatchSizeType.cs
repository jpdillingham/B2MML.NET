namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchSize", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchSizeType {
    
        private NominalType nominalField;
    
        private MinType minField;
    
        private MaxType maxField;
    
        private ScaleReferenceType scaleReferenceField;
    
        private ScaledSizeType scaledSizeField;
    
        private UnitOfMeasureType unitOfMeasureField;
    
        /// <remarks/>
        public NominalType Nominal {
            get {
                return nominalField;
            }
            set {
                nominalField = value;
            }
        }
    
        /// <remarks/>
        public MinType Min {
            get {
                return minField;
            }
            set {
                minField = value;
            }
        }
    
        /// <remarks/>
        public MaxType Max {
            get {
                return maxField;
            }
            set {
                maxField = value;
            }
        }
    
        /// <remarks/>
        public ScaleReferenceType ScaleReference {
            get {
                return scaleReferenceField;
            }
            set {
                scaleReferenceField = value;
            }
        }
    
        /// <remarks/>
        public ScaledSizeType ScaledSize {
            get {
                return scaledSizeField;
            }
            set {
                scaledSizeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return unitOfMeasureField;
            }
            set {
                unitOfMeasureField = value;
            }
        }
    }
}
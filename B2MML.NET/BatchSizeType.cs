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
                return this.nominalField;
            }
            set {
                this.nominalField = value;
            }
        }
    
        /// <remarks/>
        public MinType Min {
            get {
                return this.minField;
            }
            set {
                this.minField = value;
            }
        }
    
        /// <remarks/>
        public MaxType Max {
            get {
                return this.maxField;
            }
            set {
                this.maxField = value;
            }
        }
    
        /// <remarks/>
        public ScaleReferenceType ScaleReference {
            get {
                return this.scaleReferenceField;
            }
            set {
                this.scaleReferenceField = value;
            }
        }
    
        /// <remarks/>
        public ScaledSizeType ScaledSize {
            get {
                return this.scaledSizeField;
            }
            set {
                this.scaledSizeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
    }
}
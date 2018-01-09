﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class MaterialSpecificationType {
    
        private MaterialClassIDType _materialClassIDField;
    
        private MaterialDefinitionIDType _materialDefinitionIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private MaterialUseType _materialUseField;
    
        private List<QuantityValueType> _quantityField;
    
        private List<MaterialSpecificationType> _assemblySpecificationField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private List<MaterialSpecificationPropertyType> _materialSpecificationPropertyField;
    
        /// <remarks/>
        public MaterialClassIDType MaterialClassID {
            get => _materialClassIDField;
            set => _materialClassIDField = value;
        }
    
        /// <remarks/>
        public MaterialDefinitionIDType MaterialDefinitionID {
            get => _materialDefinitionIDField;
            set => _materialDefinitionIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public MaterialUseType MaterialUse {
            get => _materialUseField;
            set => _materialUseField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public List<QuantityValueType> Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblySpecification")]
        public List<MaterialSpecificationType> AssemblySpecification {
            get => _assemblySpecificationField;
            set => _assemblySpecificationField = value;
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get => _assemblyTypeField;
            set => _assemblyTypeField = value;
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get => _assemblyRelationshipField;
            set => _assemblyRelationshipField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecificationProperty")]
        public List<MaterialSpecificationPropertyType> MaterialSpecificationProperty {
            get => _materialSpecificationPropertyField;
            set => _materialSpecificationPropertyField = value;
        }
    }
}
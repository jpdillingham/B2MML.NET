﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class MaterialRequirementType {
    
        private MaterialClassIDType[] _materialClassIDField;
    
        private MaterialDefinitionIDType[] _materialDefinitionIDField;
    
        private MaterialLotIDType[] _materialLotIDField;
    
        private MaterialSubLotIDType[] _materialSubLotIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private MaterialUseType _materialUseField;
    
        private List<QuantityValueType> _quantityField;
    
        private List<MaterialRequirementType> _assemblyRequirementField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private List<MaterialRequirementPropertyType> _materialRequirementPropertyField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassID")]
        public MaterialClassIDType[] MaterialClassID {
            get => _materialClassIDField;
            set => _materialClassIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinitionID")]
        public MaterialDefinitionIDType[] MaterialDefinitionID {
            get => _materialDefinitionIDField;
            set => _materialDefinitionIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLotID")]
        public MaterialLotIDType[] MaterialLotID {
            get => _materialLotIDField;
            set => _materialLotIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLotID")]
        public MaterialSubLotIDType[] MaterialSubLotID {
            get => _materialSubLotIDField;
            set => _materialSubLotIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public LocationType Location {
            get => _locationField;
            set => _locationField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblyRequirement")]
        public List<MaterialRequirementType> AssemblyRequirement {
            get => _assemblyRequirementField;
            set => _assemblyRequirementField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirementProperty")]
        public List<MaterialRequirementPropertyType> MaterialRequirementProperty {
            get => _materialRequirementPropertyField;
            set => _materialRequirementPropertyField = value;
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get => _requiredByRequestedSegmentResponseField;
            set => _requiredByRequestedSegmentResponseField = value;
        }
    }
}
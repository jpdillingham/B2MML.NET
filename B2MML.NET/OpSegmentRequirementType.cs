﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class OpSegmentRequirementType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _operationsTypeField;
    
        private ProcessSegmentIDType _processSegmentIDField;
    
        private EarliestStartTimeType _earliestStartTimeField;
    
        private LatestEndTimeType _latestEndTimeField;
    
        private string _durationField;
    
        private OperationsDefinitionIDType _operationsDefinitionIDField;
    
        private RequestStateType _segmentStateField;
    
        private List<ParameterType> _segmentParameterField;
    
        private List<OpPersonnelRequirementType> _personnelRequirementField;
    
        private List<OpEquipmentRequirementType> _equipmentRequirementField;
    
        private List<OpPhysicalAssetRequirementType> _physicalAssetRequirementField;
    
        private List<OpMaterialRequirementType> _materialRequirementField;
    
        private List<OpSegmentRequirementType> _segmentRequirementField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get => _operationsTypeField;
            set => _operationsTypeField = value;
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
        }
    
        /// <remarks/>
        public EarliestStartTimeType EarliestStartTime {
            get => _earliestStartTimeField;
            set => _earliestStartTimeField = value;
        }
    
        /// <remarks/>
        public LatestEndTimeType LatestEndTime {
            get => _latestEndTimeField;
            set => _latestEndTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get => _durationField;
            set => _durationField = value;
        }
    
        /// <remarks/>
        public OperationsDefinitionIDType OperationsDefinitionID {
            get => _operationsDefinitionIDField;
            set => _operationsDefinitionIDField = value;
        }
    
        /// <remarks/>
        public RequestStateType SegmentState {
            get => _segmentStateField;
            set => _segmentStateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentParameter")]
        public List<ParameterType> SegmentParameter {
            get => _segmentParameterField;
            set => _segmentParameterField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public List<OpPersonnelRequirementType> PersonnelRequirement {
            get => _personnelRequirementField;
            set => _personnelRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public List<OpEquipmentRequirementType> EquipmentRequirement {
            get => _equipmentRequirementField;
            set => _equipmentRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public List<OpPhysicalAssetRequirementType> PhysicalAssetRequirement {
            get => _physicalAssetRequirementField;
            set => _physicalAssetRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public List<OpMaterialRequirementType> MaterialRequirement {
            get => _materialRequirementField;
            set => _materialRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public List<OpSegmentRequirementType> SegmentRequirement {
            get => _segmentRequirementField;
            set => _segmentRequirementField = value;
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get => _requiredByRequestedSegmentResponseField;
            set => _requiredByRequestedSegmentResponseField = value;
        }
    }
}
﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("TendererPartyQualification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TendererPartyQualificationType {
    
        /// <remarks/>
        [XmlElement("InterestedProcurementProjectLot")]
        public ProcurementProjectLotType[] InterestedProcurementProjectLot;
    
        /// <remarks/>
        public QualifyingPartyType MainQualifyingParty;
    
        /// <remarks/>
        [XmlElement("AdditionalQualifyingParty")]
        public QualifyingPartyType[] AdditionalQualifyingParty;
    }
}
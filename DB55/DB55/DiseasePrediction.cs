//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB55
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiseasePrediction
    {
        public int DiseaseId { get; set; }
        public int SymptomsId { get; set; }
        public int ReasonId { get; set; }
    
        public virtual Disease Disease { get; set; }
        public virtual Reason Reason { get; set; }
        public virtual Symptom Symptom { get; set; }
    }
}
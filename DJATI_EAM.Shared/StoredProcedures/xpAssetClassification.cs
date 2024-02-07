using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class XpAssetClassification
    {
        [Key]
        public string? Classification { get; set; }
    }
}

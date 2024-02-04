using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class xpAssetClassification
    {
        [Key]
        public string? Classification { get; set; }
    }
}

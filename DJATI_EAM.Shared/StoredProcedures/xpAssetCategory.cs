using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class XpAssetCategory
    {
        [Key]
        public string? Category { get; set; }
    }
}

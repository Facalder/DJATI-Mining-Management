using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class xpAssetCategory
    {
        [Key]
        public string? Category { get; set; }
    }
}

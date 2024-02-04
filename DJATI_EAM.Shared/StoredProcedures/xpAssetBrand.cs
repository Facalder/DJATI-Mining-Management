using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class xpAssetBrand
    {
        [Key]
        public string? Brand { get; set; }
    }
}

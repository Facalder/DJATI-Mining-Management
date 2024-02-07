using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class XpAssetBrand
    {
        [Key]
        public string? Brand { get; set; }
    }
}

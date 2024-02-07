using System;
using System.ComponentModel.DataAnnotations;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class XpAssetGroup
    {
        [Key]
        public string? Id { get; set; }
        public string? Description { get; set; }
        public string? Stream { get; set; }
    }
}

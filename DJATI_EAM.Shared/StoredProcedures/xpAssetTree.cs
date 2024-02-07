using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DJATI_EAM.Shared.StoredProcedures
{
    public class XpAssetTree
    {
        public string? Parent_Id { get; set; }
        public string? Id { get; set; }
        public int? Level { get; set; }
        public string? Name { get; set; }
        public string? Indent_Name { get; set; }

        [JsonIgnore, NotMapped]
        [ForeignKey("Id")]
        public virtual ICollection<XpAssetTree>? XpAssetTrees { get; set; } = new List<XpAssetTree>();

        //public xpAsset_Tree()
        //{
        //    xpAsset_Trees = new List<xpAsset_Tree>();
        //}
    }
}

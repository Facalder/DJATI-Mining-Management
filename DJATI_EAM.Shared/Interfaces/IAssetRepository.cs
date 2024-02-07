using DJATI_EAM.Shared.StoredProcedures;

namespace DJATI_EAM.Shared.Interfaces
{
    public interface IAssetRepository
    {
        Task<List<XpAssetGroup>> AssetGroupAsync(string company_Id);
        Task<List<XpAssetCategory>> AssetCategoryAsync(string company_Id);
        Task<List<XpAssetClassification>> AssetClassificationAsync(string company_Id, string category);
        Task<List<XpAssetBrand>> AssetBrandAsync(string company_Id, string category);
        Task<List<XpAsset>> AssetListAsync(string company_Id, string category);
        Task<XpAsset> AssetSingleAsync(string Id);
        Task<XpAsset> AssetAddAsync(XpAsset asset);
        Task<XpAsset> AssetUpdateAsync(XpAsset asset);
        Task<XpAsset> AssetDeleteAsync(string Id);
    }
}
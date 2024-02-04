using DJATI_EAM.Shared.StoredProcedures;

namespace DJATI_EAM.Shared.Interfaces
{
    public interface IAssetRepository
    {
        Task<List<xpAssetGroup>> AssetGroupAsync(string company_Id);
        Task<List<xpAssetCategory>> AssetCategoryAsync(string company_Id);
        Task<List<xpAssetClassification>> AssetClassificationAsync(string company_Id, string category);
        Task<List<xpAssetBrand>> AssetBrandAsync(string company_Id, string category);
        Task<List<xpAsset>> AssetListAsync(string company_Id, string category);
        Task<xpAsset> AssetSingleAsync(string Id);
        Task<xpAsset> AssetAddAsync(xpAsset asset);
        Task<xpAsset> AssetUpdateAsync(xpAsset asset);
        Task<xpAsset> AssetDeleteAsync(string Id);
    }
}

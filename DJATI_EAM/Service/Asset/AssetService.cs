using DJATI_EAM.Shared.Interfaces;
using DJATI_EAM.Shared.StoredProcedures;
using System.Net.Http.Json;

namespace DJATI_EAM.Service.Asset
{
    public class AssetService : IAssetRepository
    {
        private readonly HttpClient httpClient;

        public AssetService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<XpAssetGroup>> AssetGroupAsync(string company_Id)
        {
            List<XpAssetGroup>? assetsGroup = await httpClient.GetFromJsonAsync<List<XpAssetGroup>>($"/api/djati/asset-group/{company_Id}");

            return assetsGroup;
        }

        public async Task<List<XpAssetCategory>> AssetCategoryAsync(string company_Id)
        {
            List<XpAssetCategory>? assetsCategory = await httpClient.GetFromJsonAsync<List<XpAssetCategory>>($"/api/djati/asset-category/{company_Id!}");

            return assetsCategory;
        }

        public async Task<List<XpAssetClassification>> AssetClassificationAsync(string company_Id, string category)
        {
            List<XpAssetClassification>? assetClassifications = await httpClient.GetFromJsonAsync<List<XpAssetClassification>>($"api/djati/asset-classification/{company_Id}/{category}");

            return assetClassifications;
        }

        public async Task<List<XpAssetBrand>> AssetBrandAsync(string company_Id, string category)
        {
            List<XpAssetBrand>? assetBrands = await httpClient.GetFromJsonAsync<List<XpAssetBrand>>($"api/djati/asset-brand/{company_Id}/{category}");

            return assetBrands;
        }

        public async Task<List<XpAsset>> AssetListAsync(string company_Id, string category)
        {
            List<XpAsset>? assets = await httpClient.GetFromJsonAsync<List<XpAsset>>($"api/djati/asset-list/{company_Id}/{category}");

            return assets;
        }

        public async Task<XpAsset> AssetSingleAsync(string asset_Id)
        {
            HttpResponseMessage? singleAssets = await httpClient.GetAsync("api/djati/asset-single");

            XpAsset? response = await singleAssets.Content.ReadFromJsonAsync<XpAsset>();
            return response;
        }

        // Asset CRUD Operations 
        public async Task<XpAsset> AssetAddAsync(XpAsset asset)
        {
            HttpResponseMessage? newAsset = await httpClient.PostAsJsonAsync("api/djati/asset-add", asset);
            XpAsset? response = await newAsset.Content.ReadFromJsonAsync<XpAsset>();

            return response;
        }

        public async Task<XpAsset> AssetUpdateAsync(XpAsset asset)
        {
            HttpResponseMessage? updateAsset = await httpClient.PostAsJsonAsync("api/djati/asset-update", asset);
            XpAsset? response = await updateAsset.Content.ReadFromJsonAsync<XpAsset>();

            return response;
        }

        public async Task<XpAsset> AssetDeleteAsync(string id)
        {
            HttpResponseMessage? deleteAsset = await httpClient.DeleteAsync($"api/djati/asset-delete/{id}");
            XpAsset? response = await deleteAsset.Content.ReadFromJsonAsync<XpAsset>();

            return response;
        }
    }
}

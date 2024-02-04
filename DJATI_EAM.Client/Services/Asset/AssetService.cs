using DJATI_EAM.Shared.Interfaces;
using DJATI_EAM.Shared.StoredProcedures;
using System.Net.Http.Json;

namespace DJATI_EAM.Client.Services
{
    public class AssetService : IAssetRepository
    {
        private readonly HttpClient httpClient;

        public AssetService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<xpAssetGroup>> AssetGroupAsync(string company_Id)
        {
            List<xpAssetGroup>? assetsGroup = await httpClient.GetFromJsonAsync<List<xpAssetGroup>>($"/api/djati/asset-group/{company_Id}");

            return assetsGroup;
        }

        public async Task<List<xpAssetCategory>> AssetCategoryAsync(string company_Id)
        {
            List<xpAssetCategory>? assetsCategory = await httpClient.GetFromJsonAsync<List<xpAssetCategory>>($"/api/djati/asset-category/{company_Id}");

            return assetsCategory;
        }

        public async Task<List<xpAssetClassification>> AssetClassificationAsync(string company_Id, string category)
        {
            List<xpAssetClassification>? assetClassifications = await httpClient.GetFromJsonAsync<List<xpAssetClassification>>($"api/djati/asset-classification/{company_Id}/{category}");

            return assetClassifications;
        }

        public async Task<List<xpAssetBrand>> AssetBrandAsync(string company_Id, string category)
        {
            List<xpAssetBrand>? assetBrands = await httpClient.GetFromJsonAsync<List<xpAssetBrand>>($"api/djati/asset-brand/{company_Id}/{category}");

            return assetBrands;
        }

        public async Task<List<xpAsset>> AssetListAsync(string company_Id, string category)
        {
            List<xpAsset>? assets = await httpClient.GetFromJsonAsync<List<xpAsset>>($"api/djati/asset-list*/{company_Id}/{category}");

            return assets;
        }

        public async Task<xpAsset> AssetSingleAsync(string asset_Id)
        {
            HttpResponseMessage? singleAssets = await httpClient.GetAsync("api/djati/asset-single");

            xpAsset? response = await singleAssets.Content.ReadFromJsonAsync<xpAsset>();
            return response;
        }

        // Asset CRUD Operations 
        public async Task<xpAsset> AssetAddAsync(xpAsset asset)
        {
            HttpResponseMessage? newAsset = await httpClient.PostAsJsonAsync("api/djati/asset-add", asset);
            xpAsset? response = await newAsset.Content.ReadFromJsonAsync<xpAsset>();

            return response;
        }

        public async Task<xpAsset> AssetUpdateAsync(xpAsset asset)
        {
            HttpResponseMessage? updateAsset = await httpClient.PostAsJsonAsync("api/djati/asset-update", asset);
            xpAsset? response = await updateAsset.Content.ReadFromJsonAsync<xpAsset>();

            return response;
        }

        public async Task<xpAsset> AssetDeleteAsync(string id)
        {
            HttpResponseMessage? deleteAsset = await httpClient.DeleteAsync($"api/djati/asset-delete/{id}");
            xpAsset? response = await deleteAsset.Content.ReadFromJsonAsync<xpAsset>();

            return response;
        }
    }
}

namespace Crypto.Models;

public class AssetsRepository
{
    private static List<Asset> _assets = [
        new Asset { AssetId = 1, Name = "Bitcoin", Price = 60009.80, CategoryId = 1},
        new Asset { AssetId = 2, Name = "Bitcoin Cash", Price = 369.17, CategoryId = 1},
        new Asset { AssetId = 3, Name = "Stacks", Price = 1.69, CategoryId = 1},
        new Asset { AssetId = 4, Name = "Ethereum", Price = 3191.27, CategoryId  = 2},
        new Asset { AssetId = 5, Name = "Shiba Inu", Price = 0.00001721, CategoryId  = 2},
        new Asset { AssetId = 6, Name = "The Sandbox", Price = 0.3171, CategoryId  = 2},
        new Asset { AssetId = 7, Name = "Polkadot", Price = 6.25, CategoryId  = 3},
        new Asset { AssetId = 8, Name = "Kusama", Price = 22.33, CategoryId  = 3},
        new Asset { AssetId = 9, Name = "Moonbeam", Price = 0.2153, CategoryId  = 3},
        new Asset { AssetId = 10, Name = "Cosmos", Price = 6.14, CategoryId  = 4},
        new Asset { AssetId = 11, Name = "Akash Network", Price = 3.40, CategoryId  = 4},
        new Asset { AssetId = 12, Name = "Osmosis", Price = 0.4801, CategoryId  = 4},
    ];

    public static List<Asset> GetAssets() => _assets;

    public static List<Asset> GetAssetByCategory(int categoryId)
    {
        return _assets.Where(a => a.CategoryId == categoryId).ToList();
    }

    public static void UpdateAsset(int assetId, Asset asset)
    {
        if (assetId != asset.AssetId)
        {
            return;
        }

        var assetToUpdate = _assets.FirstOrDefault(a => a.AssetId == assetId);
        if (assetToUpdate != null)
        {
            assetToUpdate.Name = asset.Name;
            assetToUpdate.Price = asset.Price;
        }
    }

    public static void DeleteAsset(int assetId)
    {
        var asset = _assets.FirstOrDefault(a => a.AssetId == assetId);
        if (asset != null)
        {
            _assets.Remove(asset);
        }
    }

    public static List<Asset> SearchAssets(string asset)
    {
        return _assets.Where(a => a.Name.Contains(asset, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static Asset? GetAssetById(int id)
    {
        var asset = _assets.FirstOrDefault(a => a.AssetId == id);
        if (asset != null)
        {
            return new Asset
            {
                AssetId = asset.AssetId,
                Name = asset.Name,
                Price = asset.Price,
                CategoryId = asset.CategoryId,
            };
        }

        return null;
    }

    public static void AddAsset(Asset asset)
    {
        var maxId = _assets.Max(a => a.AssetId);
        asset.AssetId = maxId + 1;
        _assets.Add(asset);
    }
}
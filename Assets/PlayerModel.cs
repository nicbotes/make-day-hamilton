using System;
using System.Collections.Generic;

public class PlayerModel
{
    private List<AssetModel> assets = new List<AssetModel>();
    public PlayerModel()
    {
    }

    public string PlayerName()
    {
        return "RainbowDash!";
    }

    public List<AssetModel> GetAssets()
    {
        return assets;
    }

    public void SetAssets(List<AssetModel> newAssets)
    {
        assets = newAssets;
    }

    public void AddAsset(AssetModel phone)
    {
        assets.Add(phone);
    }
}

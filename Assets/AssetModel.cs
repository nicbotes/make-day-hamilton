using System;

public abstract class AssetModel
{
    public abstract string AssetName();

    public bool IsInsured { get; set; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public Text gameStats;
    public PlayerModel currentPlayer;

	// Use this for initialization
	void Start () {
        gameStats.text = "Current player: N/A";
	}

    public void RegisterAsset(AssetModel asset) {
        if(currentPlayer != null) {
            currentPlayer.AddAsset(asset);
        }
    }

    public void InsureAssets() {
        if(currentPlayer != null) {
            currentPlayer.GetAssets().ForEach((AssetModel obj) =>
            {
                obj.IsInsured = true;
            });
        }
    }

    public void DestroyAssets(bool forceDestroy = false) {
        if (currentPlayer != null)
        {
            List<AssetModel> newAssets = new List<AssetModel>();
            currentPlayer.GetAssets().ForEach((AssetModel obj) => {
                if(!forceDestroy && obj.IsInsured) newAssets.Add(obj);
            });
            currentPlayer.SetAssets(newAssets);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(currentPlayer != null){
            gameStats.text = "Current player: " + currentPlayer.PlayerName();
            gameStats.text += "\nAssets:\n";
            currentPlayer.GetAssets().ForEach((AssetModel obj) => gameStats.text += obj.AssetName() + " (Insured: " + obj.IsInsured + ")\n");
        }
	}
} 
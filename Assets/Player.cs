using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : DefaultTrackableEventHandler {
    public GameController gameController;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        if (gameController.currentPlayer == null)
        {
            gameController.currentPlayer = new PlayerModel();
            PolicyHolders holder = gameObject.AddComponent<PolicyHolders>();
            holder.firstName = "Rainbow";
            holder.lastName = "Dash!";
            holder.number = "8812165059080";
            holder.country = "ZA";
            holder.email = "nic@offerzen.com";
        }
    }
}

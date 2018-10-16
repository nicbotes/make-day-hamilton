using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disaster : DefaultTrackableEventHandler
{
    public GameController gameController;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        gameController.DestroyAssets(true);
    }
}

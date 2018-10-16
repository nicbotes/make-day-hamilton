using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insurance : DefaultTrackableEventHandler
{
    public GameController gameController;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        gameController.InsureAssets();
    }
}

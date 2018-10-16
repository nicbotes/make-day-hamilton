using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : DefaultTrackableEventHandler
{
    public GameController gameController;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        gameController.RegisterAsset(new CarModel());
    }
}

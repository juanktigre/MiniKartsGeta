using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class SlowDownPowerUp : ArcadeKartPowerup
{
    protected override void  OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        
        var rb = other.attachedRigidbody;
        if (rb) {

            var kart = rb.GetComponent<ArcadeKart>();

            if (kart)
            { 
                kart.GetComponent<SlowdownPowerUpBehaviour>().PerformPowerUp(this);
            }
        }
        
    }
}

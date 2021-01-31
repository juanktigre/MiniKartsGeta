using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class JumpPowerUpBehaviour : MonoBehaviour
{
    private ArcadeKart kart;

    void Awake()
    {
        kart= GetComponent<ArcadeKart>();
    }

    public void PerformPowerUp(float value)
    {
        print("Jump powerUp");
        kart.Rigidbody.velocity= kart.Rigidbody.velocity + Vector3.up * value;
    }
}

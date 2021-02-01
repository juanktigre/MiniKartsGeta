using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class BoostPowerUpBehaviour : MonoBehaviour
{
    private ArcadeKart kart;
    public bool isPerformingPoweUp;
    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup();
    [SerializeField] private GameObject powerUpFVX;


    void Awake()
    {
        kart = GetComponent<ArcadeKart>();
        if(powerUpFVX)
            powerUpFVX?.SetActive(false);
    }

    public void PerformPowerUp(ArcadeKartPowerup power)
    {
        boostStats= power.boostStats ;
        power.onPowerupFinishCooldownAction = () =>
        {
            isPerformingPoweUp = false;
            if(powerUpFVX)
                powerUpFVX?.SetActive(false);

        };
        isPerformingPoweUp = true;
        if(powerUpFVX)
            powerUpFVX?.SetActive(true);
    }

    public void FixedUpdate()
    {
        if (isPerformingPoweUp)
        {
            Vector3 adjustedVelocity = kart.Rigidbody.velocity;
            Vector3 restVelocity = kart.Rigidbody.velocity * boostStats.modifiers.boostForce;
            adjustedVelocity = Vector3.MoveTowards(adjustedVelocity, restVelocity, 
                Time.deltaTime * boostStats.modifiers.boostForceAcceleration);

            kart.Rigidbody.velocity = adjustedVelocity;
        }
    }
}
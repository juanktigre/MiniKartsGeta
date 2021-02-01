using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class SlowdownPowerUpBehaviour : MonoBehaviour
{
    private ArcadeKart kart;
    public bool isPerformingPoweUp;
    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup();
    [SerializeField] private GameObject slowDownFVX;

    void Awake()
    {
        kart = GetComponent<ArcadeKart>();
        if(slowDownFVX)
            slowDownFVX?.SetActive(false);
    }

    public void PerformPowerUp(ArcadeKartPowerup power)
    {
        boostStats= power.boostStats ;
        power.onPowerupFinishCooldownAction = () =>
        {
            isPerformingPoweUp = false;
            if(slowDownFVX)
                slowDownFVX?.SetActive(false);

        };
        isPerformingPoweUp = true;
        if(slowDownFVX)
            slowDownFVX?.SetActive(true);
    }

    public void FixedUpdate()
    {
        if (isPerformingPoweUp)
        {
            Vector3 adjustedVelocity = kart.Rigidbody.velocity;
            Vector3 restVelocity = new Vector3(0, kart.Rigidbody.velocity.y,0);
            
            adjustedVelocity = Vector3.MoveTowards(adjustedVelocity, restVelocity, 
                Time.deltaTime * boostStats.modifiers.slowDownForceAcceleration);
            
            kart.Rigidbody.velocity = adjustedVelocity;
        }
    }
}
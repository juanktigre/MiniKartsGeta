using KartGame.KartSystems;
using UnityEngine;
using UnityEngine.Events;

public class ArcadeKartPowerup : MonoBehaviour {

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };

    [SerializeField] private bool coolingDown;
    public bool isCoolingDown { get; private set; }
    public float lastActivatedTimestamp { get; private set; }

    public float cooldown = 5f;

    public bool disableGameObjectWhenActivated;
    public UnityEvent onPowerupActivated;
    public UnityEvent onPowerupFinishCooldown;
    public System.Action onPowerupFinishCooldownAction;

    private void Awake()
    {
        lastActivatedTimestamp = -9999f;
    }


    private void Update()
    {
        coolingDown = isCoolingDown;
        if (isCoolingDown) { 

            if (Time.time - lastActivatedTimestamp > cooldown) {
                //finished cooldown!
                isCoolingDown = false;
                onPowerupFinishCooldown.Invoke();
                onPowerupFinishCooldownAction?.Invoke();
            }

        }
    }


    protected virtual void OnTriggerEnter(Collider other)
    {
         if (isCoolingDown) return;

         var rb = other.attachedRigidbody;
        if (rb) {
        
            var kart = rb.GetComponent<ArcadeKart>();
        
            if (kart)
            { 
                    // kart.PowerUpSlowDown(this);
                    // kart.JumpPowerup(boostStats.modifiers.TopSpeed);
                    // kart.AddPowerup(this.boostStats);
                    // onPowerupActivated.Invoke();
                lastActivatedTimestamp = Time.time;
        
                isCoolingDown = true;
        
                if (disableGameObjectWhenActivated) this.gameObject.SetActive(false);
            }
        }
    }

}

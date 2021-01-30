using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKartLookController : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnTiresLook;
    [SerializeField] private Button btnCharacterLook;
    [SerializeField] private Button btnChasisLook;
    [SerializeField] private Button btnbackToPlay;
    
    [Header("Scrolls")]
    [SerializeField] private GameObject scrollTires;
    [SerializeField] private GameObject scrollChasis;
    [SerializeField] private GameObject scrollChar;


    private System.Action onKartLookBackBtn;


    void Start()
    {
        DisaableAllScrolls();

        btnChasisLook.onClick.AddListener(OnBtnChasisLookPressed);
        btnCharacterLook.onClick.AddListener(OnBtnCharacterLookPressed);
        btnTiresLook.onClick.AddListener(OnBtnTiresPressed);
        btnbackToPlay.onClick.AddListener(OnBtnBackToPLayPressed);
    }

    public void OnBtnTiresPressed()
    {
        DisaableAllScrolls();
        scrollTires.gameObject.SetActive(true);
        print("OnBtnTiresPressed");
    }
    public void OnBtnCharacterLookPressed()
    {
        DisaableAllScrolls();
        scrollChar.gameObject.SetActive(true);

        print("OnBtnCharacterLookPressed");

    }
    public void OnBtnChasisLookPressed()
    {
        DisaableAllScrolls();
        scrollChasis.gameObject.SetActive(true);

        print("OnBtnChasisLookPressed");

    }
    
    public void OnBtnBackToPLayPressed()
    {
        DisaableAllScrolls();
        onKartLookBackBtn?.Invoke();
        gameObject.SetActive(false);

    }

    private void DisaableAllScrolls()
    {
        scrollChasis.gameObject.SetActive(false);
        scrollChar.gameObject.SetActive(false);
        scrollTires.gameObject.SetActive(false);

    }
}

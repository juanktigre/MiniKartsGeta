using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GetaGames.Interfaces;

namespace GetaGames
{
    public class UIGoToPlayController : GoToPlay
    {
        [Header("Buttons")] [SerializeField] private Button btnTiresLook;

        private System.Action onKartLookBtnPressed;

        // Start is called before the first frame update
        void Start()
        {
            btnTiresLook.onClick.AddListener(OnBackBtnPressed);
        }

        private void OnBackBtnPressed()
        {
            onKartLookBtnPressed?.Invoke();
        }
    }
}
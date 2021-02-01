using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GetaGames.BaseClasses;
using UnityEngine.Serialization;

namespace GetaGames
{
    public class UIGoToPlayController : GoToPlayBaseClass
    {
        [FormerlySerializedAs("btnGotoPlay")]
        [Header("Buttons")]
        [SerializeField] private Button btnGoToEditKart;


        // Start is called before the first frame update
        public override Action onKartLookBtnPressed { get; set; }

        public override void Init()
        {
            btnGoToEditKart.onClick.AddListener(OnBackBtnPressed);
        }

        private void OnBackBtnPressed()
        {
            onKartLookBtnPressed?.Invoke();
            gameObject.SetActive(false);
            print("OnBackBtnPressed");
        }
    }
}
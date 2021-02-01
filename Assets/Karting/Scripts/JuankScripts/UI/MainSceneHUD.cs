using System;
using System.Collections;
using System.Collections.Generic;
using GetaGames.BaseClasses;
using UnityEngine;
using UnityEngine.Serialization;


namespace GetaGames
{   
    public class MainSceneHUD : MonoBehaviour   
    {
        [SerializeField] private KartLookSetUpScriptable lookTypeSetUp;

        [SerializeField] private KartLookEditableBaseClass kartLookUIPanel;
        [FormerlySerializedAs("playUIPanel")] [SerializeField] private GoToPlayBaseClass playBaseClassUIPanel; 
        [SerializeField] private KartEditLookController kartEditLookCtrl;

        private void Start()
        {
            kartEditLookCtrl.Init(lookTypeSetUp);
            kartLookUIPanel.Init(kartEditLookCtrl.GetComponent<IKartEditLookable>());
            playBaseClassUIPanel.Init();
            
            kartLookUIPanel.onKartLookBackBtn = ActivateGoPlayPanel ;
            playBaseClassUIPanel.onKartLookBtnPressed =  ActivateLookPanel;
        }

        private void ActivateLookPanel()
        {
            kartLookUIPanel.gameObject.SetActive(true);
            print("ActivateLookPanel");
        }

        private void ActivateGoPlayPanel()
        {
            playBaseClassUIPanel.gameObject.SetActive(true);
            print("ActivateGoPlayPanel");

        }
    }
}
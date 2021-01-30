using System;
using System.Collections;
using System.Collections.Generic;
using GetaGames.BaseClasses;
using UnityEngine;


namespace GetaGames
{   
    public class MainSceneHUD : MonoBehaviour   
    {

        [SerializeField] private KartLookEditable kartLookUIPanel;
        [SerializeField] private GoToPlay playUIPanel; 
        [SerializeField] private KartEditLookController kartEditLookCtrl; 
       
        

        private void Start()
        {
            
            kartLookUIPanel.Init();
            playUIPanel.Init();
            
            kartLookUIPanel.onKartLookBackBtn = ActivateGoPlayPanel ;
            playUIPanel.onKartLookBtnPressed =  ActivateLookPanel;
        }

        private void ActivateLookPanel()
        {
            kartLookUIPanel.gameObject.SetActive(true);
            print("ActivateLookPanel");
        }

        private void ActivateGoPlayPanel()
        {
            playUIPanel.gameObject.SetActive(true);
            print("ActivateGoPlayPanel");

        }
    }
}
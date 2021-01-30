using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GetaGames
{   
    public class MainSceneHUD : MonoBehaviour   
    {
        [SerializeField] private GoToPlay kartLookUIPanel;
        [SerializeField] private GameObject playUIPanel;
       
        

        private void Awake()
        {
            ActivateLookPanel(false);
            ActivateGoPlayPanel(true);
        }

        private void ActivateLookPanel(bool isActive)
        {
            kartLookUIPanel.SetActive(isActive);
        }

        private void ActivateGoPlayPanel(bool isActive)
        {
            playUIPanel.SetActive(isActive);
        }
    }
}
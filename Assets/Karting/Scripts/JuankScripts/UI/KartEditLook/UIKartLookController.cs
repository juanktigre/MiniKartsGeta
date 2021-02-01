using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using GetaGames.BaseClasses;
using GetaGames.Interfaces;


namespace GetaGames
{
    public class UIKartLookController :  KartLookEditableBaseClass
    {
        [Header("Buttons")] [SerializeField] private Button btnTiresLook;
        [SerializeField] private Button btnCharacterLook;
        [SerializeField] private Button btnChasisLook;
        [SerializeField] private Button btnbackToPlay;

        [Header("Scrolls")] [SerializeField] private GameObject scrollTires;
        [SerializeField] private GameObject scrollChasis;
        [SerializeField] private GameObject scrollChar;
        
        private List<IKartLookEditableSet> lookEditableSetList;
        [SerializeField] private List<GameObject> lookEditableObjSetList;



        public override Action onKartLookBackBtn { get; set; }
        public override Action<int> onChangeCharBtn { get; set; }
        public override Action<int> onChangeTiresBtn { get; set; }
        public override Action<int> onChangeChasisBtn { get; set; }

        public override void Init(IKartEditLookable kartEditCtrl)
        {
            

            btnChasisLook.onClick.AddListener(OnBtnChasisLookPressed);
            btnCharacterLook.onClick.AddListener(OnBtnCharacterLookPressed);
            btnTiresLook.onClick.AddListener(OnBtnTiresPressed);
            btnbackToPlay.onClick.AddListener(OnBtnBackToPLayPressed);
            
            lookEditableSetList= GetComponentsInChildren<IKartLookEditableSet>().ToList();
            
            for (int i = 0; i < lookEditableSetList.Count; i++)
            {
                lookEditableObjSetList.Add(lookEditableSetList[i].GetObj);
                lookEditableSetList[i].onKartLookbtnPressed += kartEditCtrl.OnLookEditableSetPressed;
                lookEditableSetList[i].Init();
            }
            
            DisaableAllScrolls();
            gameObject.SetActive(false);
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

        }

        public void OnBtnChasisLookPressed()
        {
            DisaableAllScrolls();
            scrollChasis.gameObject.SetActive(true);

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
        
        //Btns sliders

        public void OnBtnChangeTiresPressed(int index)
        {
            onChangeTiresBtn?.Invoke(index);

        }
        
        public void OnBtnChangeChasisPressed(int index)
        {
            onChangeChasisBtn?.Invoke( index);

        }
        
        public void OnBtnChangeCharPressed(int index)
        {
            onChangeCharBtn?.Invoke(index);

        }
    }
}
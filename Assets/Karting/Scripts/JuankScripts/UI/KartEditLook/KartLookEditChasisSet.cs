using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GetaGames.Interfaces;
using UnityEngine.UI;
using Object = System.Object;

namespace GetaGames
{
    public class KartLookEditChasisSet : MonoBehaviour,IKartLookEditableSet
    {
        [SerializeField] private KartLookSetUpScriptable lookTypeSetUp;
        [SerializeField] private LookType lookType;
        [SerializeField] private Transform parentContainer;

        public  Transform container => parentContainer;
        public GameObject GetObj => this.gameObject;

        public  System.Action<int,LookType> onKartLookbtnPressed { get; set; }

        public void Init()
        {
            var list =  lookTypeSetUp.GetListChasisrColors();
            //Intantiate btns
             for (int i = 0; i < list.colorsList.Count; i++)
             {
                 var uiElemnt=  Instantiate(list.prefabUI,parentContainer);
                 uiElemnt.GetComponent<Image>().color = list.colorsList[i];
                 uiElemnt.GetComponent<UIEditLookElementEntity>().Init(i);

                 uiElemnt.GetComponent<UIEditLookElementEntity>().onLookElementPressed += OnKartLookEntityPressed;


             }
            //subscribe to those btns onClick
        }

        private void OnKartLookEntityPressed(int elementID)
        {
            print("OnKartLookEntityPressed elementID: " + elementID + " lookType " +  lookType);

             onKartLookbtnPressed?.Invoke(elementID,lookType);
        }



    }
}

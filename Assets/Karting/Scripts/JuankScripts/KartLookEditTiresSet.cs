using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GetaGames.Interfaces;
using UnityEngine.UI;
using Object = System.Object;

namespace GetaGames
{
    public class KartLookEditTiresSet : MonoBehaviour,IKartLookEditableSet
    {
        [SerializeField] private KartLookSetUpScriptable lookTypeSetUp;
        [SerializeField] private LookType lookType;
        [SerializeField] private Transform parentContainer;

        public  Transform container => parentContainer;
        public  System.Action<int,LookType> onKartLookbtnPressed { get; set; }
        public GameObject GetObj => this.gameObject;


        public void Init()
        {
            var list =  lookTypeSetUp.GetListTiresMeshSetUp();
            //Intantiate btns
             for (int i = 0; i < list.meshLookSetUp.Count; i++)
             {
                 var uiElemnt=  Instantiate(list.prefabUI,parentContainer);
                 uiElemnt.GetComponent<Image>().sprite = list.meshLookSetUp[i].tiresSprite;
                 uiElemnt.GetComponent<UIEditLookElementEntity>().Init(i);
                 uiElemnt.GetComponent<UIEditLookElementEntity>().onLookElementPressed += OnKartLookEntityPressed;
             }
            
        }

        private void OnKartLookEntityPressed(int elementID)
        {
            print("OnKartLookEntityPressed elementID: " + elementID + " lookType " +  lookType);

             onKartLookbtnPressed?.Invoke(elementID,lookType);
        }

        
    }
}

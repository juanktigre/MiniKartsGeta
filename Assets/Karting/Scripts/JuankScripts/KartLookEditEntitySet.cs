using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GetaGames.Interfaces;
using Object = System.Object;

namespace GetaGames
{
    public class KartLookEditEntitySet : MonoBehaviour,IKartLookEditableSet
    {
        [SerializeField] private KartLookSetUpScriptable lookTypeSetUp;
        [SerializeField] private LookType lookType;
        [SerializeField] private Transform parentContainer;

        public  Transform container => parentContainer;
        public  System.Action<int> onKartLookbtnPressed { get; set; }

        public void Init()
        {
            var list =  lookTypeSetUp.GetListCharColors();
            //Intantiate btns
             for (int i = 0; i < list.Count; i++)
             {
                  // Instantiate(list[i].)

             }
            //subscribe to those btns onClick
        }

        private void OnKartLookEntityPressed(int index)
        {
            // onKartLookbtnPressed?.Invoke(index);
        }

        
    }
}

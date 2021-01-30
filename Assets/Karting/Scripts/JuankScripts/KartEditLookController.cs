using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GetaGames.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace GetaGames
{
    public class KartEditLookController : MonoBehaviour,IKartEditLookable
    {
         [SerializeField] private KartLookSetUpScriptable kartLookSetUp;

        [SerializeField] private Transform tiresParent;
        [SerializeField] private SkinnedMeshRenderer chasis;
        [SerializeField] private SkinnedMeshRenderer character;

        private GameObject currTires;
        

        public void Init(KartLookSetUpScriptable kartLookSetUp)
        {
            this.kartLookSetUp = kartLookSetUp;
            SetTiresType(0);

        }

        public void OnLookEditableSetPressed(int index, LookType type)
        {
            print("OnLookEditableSetPressed: " + index + " " + type);
            switch (type)
            {
                case LookType.CharColor:
                    SetCharColor(index);
                    break;
                case LookType.ChasisColor:
                    SetChasisColor(index);
                    break;
                case LookType.TiresMesh:
                    SetTiresType(index);
                    break;
            }
        }
        
        public void SetChasisColor(int color)
        {
             chasis.material.color = kartLookSetUp.GetListChasisrColors().colorsList[color];
        }

        public void SetCharColor(int color)
        {
             character.material.color = kartLookSetUp.GetListCharSetUp().colorsList[color];
        }

        public void SetTiresType(int elementID)
        {
            var tiresObj = kartLookSetUp.GetListTiresMeshSetUp().meshLookSetUp[elementID].tiresTypes;
            if(currTires!= null)
                Destroy(currTires);
            currTires= Instantiate(tiresObj,tiresParent);
        }
    }
    
    
}
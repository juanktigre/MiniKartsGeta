using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GetaGames.Interfaces;
using GetaGames.Services;
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

        private IDataSaver datasaver;
        private GameObject currTires;

        private string tiresKey = "tiresMeshID";
        private string characcterKey = "charColorID";
        private string chasisKey="chasisColorID";

        private bool isInit;
        private void Awake()
        {
            if(!isInit)
                Init(kartLookSetUp);
        }

        public void Init(KartLookSetUpScriptable kartLookSetUp)
        {
            this.kartLookSetUp = kartLookSetUp;
            datasaver = ServiceLocator.Instance.GetService<IDataSaver>();
            SetTiresType(datasaver.GetInt(tiresKey));
            SetChasisColor(datasaver.GetInt(chasisKey));
            SetCharColor(datasaver.GetInt(characcterKey));

            isInit = true;

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
        
        public void SetChasisColor(int elementID)
        {
             chasis.material.color = kartLookSetUp.GetListChasisrColors().colorsList[elementID];
             datasaver.SetInt(chasisKey, elementID);
        }

        public void SetCharColor(int elementID)
        {
             character.material.color = kartLookSetUp.GetListCharSetUp().colorsList[elementID];
             datasaver.SetInt(characcterKey, elementID);

        }

        public void SetTiresType(int elementID)
        {
            var tiresObj = kartLookSetUp.GetListTiresMeshSetUp().meshLookSetUp[elementID].tiresTypes;
            if(currTires!= null)
                Destroy(currTires);
            
            currTires= Instantiate(tiresObj,tiresParent);
            
            datasaver.SetInt(tiresKey, elementID);

        }
    }
    
    
}
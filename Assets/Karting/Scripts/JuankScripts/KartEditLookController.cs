using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace GetaGames
{
    public class KartEditLookController : MonoBehaviour
    {
        // [SerializeField] private KartLookSetUpScriptable kartLookSetUp;

        [SerializeField] private Transform tiresParent;
        [SerializeField] private SkinnedMeshRenderer chasis;
        [SerializeField] private SkinnedMeshRenderer character;

        public void Start()
        {
        }

        public void SetChasisColor(int color)
        {
            // chasis.material.color = color;
        }

        public void SetCharColor(int color)
        {
            // character.material.color = color;
        }

        public void SetTiresType(int tiresObj)
        {
            // Instantiate(tiresObj, tiresParent);
        }
    }
    
    
}
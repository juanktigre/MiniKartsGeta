using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = System.Object;


namespace GetaGames
{
    public enum LookType
    {
        ChasisColor,
        CharColor,
        TiresMesh
    }

    [Serializable]
    public class TiresModel
    {
        public Image tiresTypesUI;
        public  GameObject tiresTypes;
    }


    [CreateAssetMenu(menuName = "GetaGames/KartLookSetUp")]
    public class KartLookSetUpScriptable : ScriptableObject
    {
        [Header("Colors")]
        [SerializeField] private List<Color> charColors;
        [SerializeField] private List<Color> chasisColors;
        
        
        [Header("Tires")]
        [SerializeField] private List<TiresModel> tiresModel;
        


        public List<Color> GetListCharColors()
        {
            return charColors;
        }
        
        public List<Color> GetListChasisrColors()
        {
            return chasisColors;
        }
        
        public List<TiresModel> GetListCharrColors()
        {
            return tiresModel;
        }
    }
    
}
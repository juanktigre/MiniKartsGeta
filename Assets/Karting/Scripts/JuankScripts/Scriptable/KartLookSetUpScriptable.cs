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
    public class MeshLookSetUpModel
    {
        public Sprite tiresSprite;
        public  GameObject tiresTypes;
    }
    
    [Serializable]
    public class UIMeshLookSetUpModel
    {
        public List<MeshLookSetUpModel> meshLookSetUp;
        public  GameObject prefabUI;
    }
    
    [Serializable]
    public class UIColorLookSetUpModel
    {
        public List<Color> colorsList;
        public  GameObject prefabUI;
    }
    

    [CreateAssetMenu(menuName = "GetaGames/KartLookSetUp")]
    public class KartLookSetUpScriptable : ScriptableObject
    {
        [Header("Colors")]
        
        [SerializeField] private UIColorLookSetUpModel chasisSetUp;
        [SerializeField] private UIColorLookSetUpModel characterSetUp;
        
        
        [Header("Tires")]
        [SerializeField] private UIMeshLookSetUpModel tiresSetUp;
        


        public UIColorLookSetUpModel GetListCharSetUp()
        {
            return characterSetUp;
        }
        
        public UIColorLookSetUpModel GetListChasisrColors()
        {
            return chasisSetUp;
        }
        
        public UIMeshLookSetUpModel GetListTiresMeshSetUp()
        {
            return tiresSetUp;
        }
    }
    
}
using UnityEngine;

namespace GetaGames.BaseClasses
{
    public  abstract  class GoToPlayBaseClass : MonoBehaviour
    {
        public abstract System.Action onKartLookBtnPressed { get; set; }
        public abstract void Init();

    }
}
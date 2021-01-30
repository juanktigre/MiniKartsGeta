using UnityEngine;

namespace GetaGames.BaseClasses
{
    public  abstract  class GoToPlay : MonoBehaviour
    {
        public abstract System.Action onKartLookBtnPressed { get; set; }
        public abstract void Init();

    }
}
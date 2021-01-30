using UnityEngine;

namespace GetaGames.Interfaces
{
    public interface IKartLookEditableSet
    {
        Transform container { get;  }
        System.Action<int,LookType> onKartLookbtnPressed { get; set; }
        void Init();
        GameObject GetObj { get; }
    }
}
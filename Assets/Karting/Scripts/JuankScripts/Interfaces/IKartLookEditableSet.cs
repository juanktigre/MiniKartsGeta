using UnityEngine;

namespace GetaGames.Interfaces
{
    public interface IKartLookEditableSet
    {
        Transform container { get;  }
        System.Action<int> onKartLookbtnPressed { get; set; }
    }
}
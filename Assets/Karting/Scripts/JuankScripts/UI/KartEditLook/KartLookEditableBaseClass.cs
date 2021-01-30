using UnityEngine;
using System;

namespace GetaGames.BaseClasses
{
    public abstract class KartLookEditable : MonoBehaviour
    {
        public abstract Action onKartLookBackBtn { get; set; }
        public abstract Action<int> onChangeCharBtn { get; set; }
        public abstract Action<int> onChangeTiresBtn { get; set; }
        public abstract Action<int> onChangeChasisBtn { get; set; }
        public abstract void Init(IKartEditLookable kartEditCtrl);
    }
}
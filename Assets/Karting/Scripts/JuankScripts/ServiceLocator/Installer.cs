using System;
using System.Collections;
using System.Collections.Generic;
using GetaGames;
using UnityEngine;

namespace GetaGames.Services
{
    namespace GetaGames
    {
        public class Installer : MonoBehaviour
        {
            private void Awake()
            {
                ServiceLocator.Instance.RegisterService<IDataSaver>(new PlayerPrefsAdapter());
                DontDestroyOnLoad(this);
            }
        }
    }
}
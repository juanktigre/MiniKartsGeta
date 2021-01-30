using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Object = System.Object;

namespace GetaGames.Services
{
   public class ServiceLocator
   {
      public static ServiceLocator Instance => _instance ?? (_instance = new ServiceLocator());
      private static ServiceLocator _instance;

      private Dictionary<Type, object> _services;

      public ServiceLocator()
      {
         _services = new Dictionary<Type, object>();
      }

      public void RegisterService<T>(T service)
      {
         var type = typeof(T);
         //Assert.IsFalse(_services.ContainsKey(type), $"Service {type} already registered");
         if(_services.ContainsKey(type))
            return;
         _services.Add(type, service);
      }

      public T GetService<T>()
      {
         var type = typeof(T);
         if (!_services.TryGetValue(type, out var service))
         {
            throw new Exception($"Service {type} Not Found");
         }

         return (T) service;
      }


   }

}

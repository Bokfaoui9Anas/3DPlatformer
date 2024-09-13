using System;
using Project_2.Scripts.Controllers;
using UnityEngine;

namespace Project_2.Scripts
{
    public class Area : MonoBehaviour
    {
        public string name = "";
        public static event Action<string> OnAreaEnter;

       
        private void OnTriggerEnter(Collider other)
        {
            OnAreaEnter?.Invoke(name);
        }
        

       
    }
}

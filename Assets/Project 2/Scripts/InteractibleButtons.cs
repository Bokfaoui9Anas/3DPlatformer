using System;
using UnityEngine;
using UnityEngine.UI;

namespace Project_2.Scripts
{
    public class InteractibleButtons : MonoBehaviour
    {
        public static event Action<Button> OnButtonPressed;
        

        private static void OnOnButtonPressed(Button obj)
        {
            OnButtonPressed?.Invoke(obj);
        }
    }
}

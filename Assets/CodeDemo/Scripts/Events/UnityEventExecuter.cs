using System.Collections;
using System.Collections.Generic;
using UnityEditor.Purchasing;
using UnityEngine;

namespace CodeDemo
{
    public class UnityEventExecuter : MonoBehaviour
    {
        [SerializeField] private UnityEventHolder unityEventHolder;

        private void OnEnable() { unityEventHolder.demoEvent.AddListener(SomeMehtod); }

        private void OnDisable() { unityEventHolder.demoEvent.RemoveListener(SomeMehtod); }

        [ContextMenu("TiggerUnityEvent")]
        void TiggerUnityEvent()
        {
            var number = 19;
            unityEventHolder.InvokeUnityEvent(number); //das geht
            unityEventHolder.demoEvent.Invoke(number); // das geht auch
        }

        void SomeMehtod(int number)
        { Debug.Log("The secret number was: " + number); }
    }
}

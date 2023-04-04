using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodeDemo
{
    public class UnityEventHolder : MonoBehaviour
    {
        [SerializeField] public UnityEvent<int> demoEvent;

        public void InvokeUnityEvent(int number)
        {
            demoEvent.Invoke(number);
        }
    }
}

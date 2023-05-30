using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeDemo
{
    public class Listener : MonoBehaviour
    {
        [field: SerializeField] VoidEventChannelSO VoidEventChannel { get; set; }

        private void OnEnable()
        {
            VoidEventChannel.OnEventRaised += DoSomething;
        }

        private void OnDisable()
        {
            VoidEventChannel.OnEventRaised -= DoSomething;
        }

        //Do Something When Event Is Triggered
        void DoSomething()
        {
            Debug.Log("Event was triggered");
        }
    }
}
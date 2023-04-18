using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeDemo
{
    public class EventRaiser : MonoBehaviour
    {
        [field: SerializeField] VoidEventChannelSO VoidEventChannel { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            VoidEventChannel.RaiseEvent();
        }
    }
}
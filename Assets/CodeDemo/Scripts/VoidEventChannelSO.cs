using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace CodeDemo
{
    /// <summary>
    /// General Event Channel that carries no extra data.
    /// </summary>

    [CreateAssetMenu(fileName = "VoidEventChannel", menuName = "ScriptableObjects/VoidEventChannel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        [Tooltip("The action to perform")]
        public UnityAction OnEventRaised;

        public void RaiseEvent()
        {
            OnEventRaised?.Invoke();
        }
    }
}

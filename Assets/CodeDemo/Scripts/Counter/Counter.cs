using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace CodeDemo.Counter
{
    public class Counter : MonoBehaviour
    {
        [SerializeField] VoidEventChannelSO countEvent;

        private void OnEnable()
        {
            countEvent.OnEventRaised += CountUp;
        }

        private void OnDisable()
        {
            countEvent.OnEventRaised -= CountUp;
        }

        void CountUp()
        {
            Debug.Log("Counted Up");
        }
    } 
}

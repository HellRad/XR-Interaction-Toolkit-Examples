using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace CodeDemo.Counter
{
    public class Counter : MonoBehaviour
    {
        [SerializeField] VoidEventChannelSO countEvent;
        [SerializeField] IntEventChannelSO onCounterIncrement;

        private int counter;

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
            counter++;
            Debug.Log("Counted Up");

            onCounterIncrement.RaiseEvent(counter);

            if (counter == 10)
            {
                if (GameManager.Instance.CurrentState == GameStates.GameOver)
                {

                }
            }
        }
    } 
}

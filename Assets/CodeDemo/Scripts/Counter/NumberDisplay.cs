using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace CodeDemo
{
    public class NumberDisplay : MonoBehaviour
    {
        [SerializeField] IntEventChannelSO onCounterIncrement;
        [SerializeField] TMP_Text tmpText;

        private void OnEnable()
        {
            onCounterIncrement.OnEventRaised += UpdateText;
        }

        private void OnDisable()
        {
            onCounterIncrement.OnEventRaised -= UpdateText;
        }

        void UpdateText(int value)
        {
            tmpText.text = value.ToString();
        }
    }
}

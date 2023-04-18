using System;
using System.Collections.Generic;
using UnityEngine;

namespace CodeDemo
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings")]
    public class GameSettingsSO : ScriptableObject
    {
        [field: SerializeField] public string DefaultNameOfPlayer { get; private set; }
        [field: SerializeField] public int MaxNumberOfPoints { get; private set; }
    }
}
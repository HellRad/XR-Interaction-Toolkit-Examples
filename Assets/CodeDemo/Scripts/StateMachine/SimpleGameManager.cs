using CodeDemo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CodeDemo
{
    public class SimpleGameManager : MonoBehaviour
    {
        [field: SerializeField] public GameSettingsSO GameSettings { get; private set; }
        [field: SerializeField] public SimpleGameData GameData { get; private set; } = new();

        public bool IsCool { get { return isCool; } set { isCool = value; } }
        [SerializeField] private bool isCool;


        public static SimpleGameManager Instance { get; private set; }

        void Awake()
        {

            if (Instance != null)
            {
                Debug.Log("There was more the one instance of " + this.GetType().Name + " deleting additional instance");
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }
        }

        public void DoSomething()
        { }
    }
}

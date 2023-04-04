using System.Collections;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeDemo
{
    public class SingletonDemo : MonoBehaviour
    {
        public static SingletonDemo Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
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
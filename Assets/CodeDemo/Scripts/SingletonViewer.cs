using System.Collections;
using UnityEngine;

namespace CodeDemo
{
    public class SingletonViewer : MonoBehaviour
    {
        void Start()
        {
            SingletonDemo.Instance.DoSomething();
        }
    }
}
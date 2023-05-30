using UnityEditor;
using UnityEngine;

namespace CodeDemo
{
    [CreateAssetMenu(fileName = "DemoScriptableObject", menuName = "ScriptableObjects/DemoScriptableObject", order = 1)]
    public class DemoScriptableObject : ScriptableObject
    {
        [field: SerializeField] public string SomeText { get; private set; }
        [field: SerializeField] public DemoStruct SomeStruct { get; private set; }

        public void DoSomething()
        { }
    }
}
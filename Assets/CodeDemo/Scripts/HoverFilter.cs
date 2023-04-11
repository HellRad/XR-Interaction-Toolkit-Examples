using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

[CreateAssetMenu(fileName = "HoverFilter", menuName = "ScriptableObjects/HoverFilter")]
public class HoverFilter : ScriptableObject, IXRHoverFilter
{
    public bool canProcess => throw new System.NotImplementedException();

    public bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
    {
        throw new System.NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class EventListenerDemo : MonoBehaviour
{
    [SerializeField] Material hoverMaterial;
    [SerializeField] XRGrabInteractable grabInteractable;

    //When on he same game object and or will never be disabled or spawned or deleted
    void Awake()
    {
        grabInteractable.hoverEntered.AddListener(DoSomething);
    }

    //Any other case:

    //void OnEnable()
    //{
    //    grabInteractable.hoverEntered.AddListener(DoSomething);
    //}

    //void OnDisable()
    //{
    //    grabInteractable.hoverEntered.RemoveListener(DoSomething);
    //}


    //Add a event functionality
    void DoSomething(HoverEnterEventArgs args)
    {
        Debug.Log("hovered over event listenter demo");
    }
}

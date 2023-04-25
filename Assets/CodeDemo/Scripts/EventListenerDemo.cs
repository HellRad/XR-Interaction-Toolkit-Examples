using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;
using CodeDemo;
using Unity.VisualScripting;

public class EventListenerDemo : MonoBehaviour
{
    [SerializeField] Material hoverMaterial;
    [SerializeField] XRGrabInteractable grabInteractable;
    [SerializeField] VoidEventChannelSO voidEventChannelSO;

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
        Debug.Log("hovered over: " + args.interactableObject.transform.gameObject.name);
        voidEventChannelSO.RaiseEvent();
    }
}

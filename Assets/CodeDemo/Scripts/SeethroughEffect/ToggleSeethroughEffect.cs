using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace CodeDemo
{
    public class ToggleSeethroughEffect : MonoBehaviour
    {
        [SerializeField] RenderObjects renderObjectsFeature;
        [SerializeField] InputActionReference toggleActionRef;

        void Awake()
        {
            toggleActionRef.action.performed += Action_performed;
        }

        void OnDestroy()
        {
            toggleActionRef.action.performed -= Action_performed;
        }

        void Action_performed(InputAction.CallbackContext context)
        {
            Toggle();
        }

        [ContextMenu("ToggleEffect")]
        void Toggle()
        {
            renderObjectsFeature.SetActive(!renderObjectsFeature.isActive);
        }
    } 
}

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
        //private bool triggered;

        void Awake()
        {
            toggleActionRef.action.performed += Action_performed;
        }

        void OnDestroy()
        {
            toggleActionRef.action.performed -= Action_performed;
        }

        /*
        private void Update()
        {
            float val = toggleActionRef.action.ReadValue<float>();

            if (val > 0 && !triggered)
            {
                Debug.Log("executed");
                Toggle();
                triggered = true;
            }
            else
            {
                triggered = false;
            }
        }
        */

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

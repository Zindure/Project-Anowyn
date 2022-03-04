#if ENABLE_INPUT_SYSTEM 
using UnityEngine.InputSystem;
#endif

using UnityEngine;
    public class SimpleCameraController : MonoBehaviour
    {
        public Transform target;

        public float smoothSpeed = 0.125f;

        void LateUpdate()
        {
            transform.position = target.position;
        }

    }
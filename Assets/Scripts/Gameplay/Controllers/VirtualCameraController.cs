using System.Collections;
using UnityEngine;
using Cinemachine;

namespace Assets.Scripts.Gameplay.Controllers
{
    [RequireComponent(typeof(CinemachineVirtualCameraBase))]
    public class VirtualCameraController : MonoBehaviour
    {
        public float Speed = 5f;
        public float PitchMax = 70f;
        public float PitchMin = 45f;

        public Camera mainCamera;
        private CinemachineVirtualCamera virtualCamera;
        private Transform lookAt;

        private float _currentX, _currentY;

        // Use this for initialization
        void Start()
        {
            virtualCamera = GetComponent<CinemachineVirtualCamera>();

            lookAt = new GameObject("LookAtTarget").transform;
            lookAt.position = transform.position;
            lookAt.position += transform.forward * 10f;

            virtualCamera.LookAt = lookAt;
        }

        // Update is called once per frame
        void Update()
        {
            float x = virtualCamera.GetInputAxisProvider().GetAxisValue(0);
            float y = virtualCamera.GetInputAxisProvider().GetAxisValue(1);
            //Debug.Log($"{x},{y}");

            _currentX = Mathf.Clamp(_currentX + y * Speed, PitchMin, PitchMax);
            _currentY += x * Speed;

            Vector3 dir = Vector3.forward * 10f;

            Vector3 input = new Vector3(-_currentX, _currentY);
            Quaternion r = Quaternion.Euler(input);

            Vector3 freeLook = r * dir;
            Vector3 pos = transform.position + freeLook;
            lookAt.position = pos;
            //Debug.Log(pos);

            Debug.DrawLine(lookAt.position, transform.position, Color.green);
        }
    }
}
using UnityEngine;
using UnityEngine.EventSystems;

namespace BaseGame.Scripts.Gameplay.Input.Service
{
    public class StandaloneInputService : IInputService
    {
        public float GetVerticalAxis() => UnityEngine.Input.GetAxis("Vertical");

        public float GetHorizontalAxis() => UnityEngine.Input.GetAxis("Horizontal");

        public bool HasAxisInput() => GetHorizontalAxis() != 0 || GetVerticalAxis() != 0;
        
        public bool GetLeftMouseButton() => UnityEngine.Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetLeftMouseButtonDown() => UnityEngine.Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject();

        public bool GetLeftMouseButtonUp() => UnityEngine.Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject();

        public Vector2 GetScreenMousePosition() => throw new System.NotImplementedException(); //CameraMain ? UnityEngine.Input.mousePosition : new Vector3();

        public Vector2 GetWorldMousePosition() => throw new System.NotImplementedException();
    }
}
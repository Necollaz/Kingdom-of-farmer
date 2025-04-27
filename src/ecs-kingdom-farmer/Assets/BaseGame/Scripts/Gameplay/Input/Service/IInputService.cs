using UnityEngine;

namespace BaseGame.Scripts.Gameplay.Input.Service
{
    public interface IInputService
    {
        public float GetVerticalAxis();
        public float GetHorizontalAxis();

        public bool HasAxisInput();
        public bool GetLeftMouseButtonDown();
        public bool GetLeftMouseButtonUp();
        
        public Vector3 GetScreenMousePosition();
        public Vector3 GetWorldMousePosition();
    }
}
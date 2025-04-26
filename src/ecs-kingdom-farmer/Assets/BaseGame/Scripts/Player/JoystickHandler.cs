using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BaseGame.Scripts.Player
{
    public abstract class JoystickHandler : MonoBehaviour
    {
        [SerializeField] private Image _joystickBackground;
        [SerializeField] private Image _joystick;
        [SerializeField] private Image _joystickArea;
        [SerializeField] private Color _inActiveJoystickColor;
        [SerializeField] private Color _activeJoystickColor;
        
        private Vector2 _joystickBackgroundStartPosition;
        private bool _isJoystickActive;

        protected Vector2 _inputVector;

        private void Start()
        {
            ClickEffect();
            
            _joystickBackgroundStartPosition = _joystickBackground.rectTransform.anchoredPosition;
        }

        public void OnDrag(PointerEventData eventData)
        {
            Debug.Log("Down");
                
            Vector2 joystickPosition;

            if(RectTransformUtility.ScreenPointToLocalPointInRectangle(_joystickBackground.rectTransform, eventData.position, null, out joystickPosition))
            {
                joystickPosition.x = joystickPosition.x * 2 / _joystickBackground.rectTransform.sizeDelta.x;
                joystickPosition.y = joystickPosition.y * 2 / _joystickBackground.rectTransform.sizeDelta.y;

                _inputVector = new Vector2(joystickPosition.x, joystickPosition.y);
                _inputVector = (_inputVector.magnitude > 1) ? _inputVector.normalized : _inputVector;

                _joystick.rectTransform.anchoredPosition = new Vector2(_inputVector.x * (_joystickBackground.rectTransform.sizeDelta.x / 2), _inputVector.y * (_joystickBackground.rectTransform.sizeDelta.y / 2));
                
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("Down");
            
            ClickEffect();

            Vector2 joystickBackgroundPosition;

            if(RectTransformUtility.ScreenPointToLocalPointInRectangle(_joystickArea.rectTransform, eventData.position, null, out joystickBackgroundPosition))
            {
                _joystickBackground.rectTransform.anchoredPosition = new Vector2(joystickBackgroundPosition.x, joystickBackgroundPosition.y);
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _joystickBackground.rectTransform.anchoredPosition = _joystickBackgroundStartPosition;
            
            ClickEffect();

            _inputVector = Vector2.zero;
            _joystick.rectTransform.anchoredPosition = Vector2.zero;
        }
        
        private void ClickEffect()
        {
            if(!_isJoystickActive)
            {
                _joystick.color = _activeJoystickColor;
                _isJoystickActive = true;
            }
            else
            {
                _joystick.color = _inActiveJoystickColor;
                _isJoystickActive = false;
            }
        }
    }
}
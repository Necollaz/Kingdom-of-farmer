using UnityEngine;
using BaseGame.Scripts.Gameplay.Common.Visuals;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Behaviours
{
    public class HeroAnimator : MonoBehaviour, IDamageTakenAnimator
    {
        private static readonly int HorizontalHash = Animator.StringToHash("horizontal");
        private static readonly int VerticalHash = Animator.StringToHash("vertical");
        private static readonly int AttackHash = Animator.StringToHash("attack");
        private static readonly int DiedHash = Animator.StringToHash("died");
        private static readonly int IsMovingHash = Animator.StringToHash("isMoving");
        
        [SerializeField] private Animator _animator;

        public void UpdateMovement(Vector3 direction)
        {
            float horizontal = direction.x;
            float vertical = direction.z;
            
            _animator.SetFloat(HorizontalHash, horizontal);
            _animator.SetFloat(VerticalHash, vertical);
            
            bool isMoving = direction.sqrMagnitude > 0.01f;
            
            _animator.SetBool(IsMovingHash, isMoving);
        }
        
        public void PlayAttack() => _animator.SetTrigger(AttackHash);
        
        public void PlayDied() => _animator.SetTrigger(DiedHash);

        public void PlayDamageTaken()
        {
            
        }

        public void ResetAll()
        {
            _animator.ResetTrigger(AttackHash);
            _animator.ResetTrigger(DiedHash);
        }
    }
}
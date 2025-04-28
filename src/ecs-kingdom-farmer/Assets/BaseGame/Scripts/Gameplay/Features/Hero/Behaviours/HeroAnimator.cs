using UnityEngine;
using BaseGame.Scripts.Gameplay.Common.Visuals;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Behaviours
{
    public class HeroAnimator : MonoBehaviour, IDamageTakenAnimator
    {
        private static readonly int AttackHash = Animator.StringToHash("attack");
        private static readonly int DiedHash = Animator.StringToHash("died");
        private static readonly int IsMovingHash = Animator.StringToHash("isMoving");
        //private static readonly int OverlayIntensityProperty = Shader.PropertyToID("_OverlayIntensity");
        
        [SerializeField] private Animator _animator;
        
        public void PlayMove() => _animator.SetBool(IsMovingHash, true);

        public void PlayIdle() => _animator.SetBool(IsMovingHash, false);

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
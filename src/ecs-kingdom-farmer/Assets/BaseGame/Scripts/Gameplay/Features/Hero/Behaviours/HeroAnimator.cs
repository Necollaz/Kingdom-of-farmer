using UnityEngine;
using BaseGame.Scripts.Gameplay.Common.Visuals;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Behaviours
{
    public class HeroAnimator : MonoBehaviour, IDamageTakenAnimator
    {
        private static readonly int OverlayIntensityProperty = Shader.PropertyToID("_OverlayIntensity");
        
        private readonly int _isMovingHash = Animator.StringToHash("IsMoving");
        private readonly int _attackHash = Animator.StringToHash("attack");
        private readonly int _diedHash = Animator.StringToHash("died");

        public Animator Animator;

        public void PlayMove() => Animator.SetBool(_isMovingHash, true);

        public void PlayIdle() => Animator.SetBool(_isMovingHash, false);

        public void PlayAttack() => Animator.SetTrigger(_attackHash);
        
        public void PlayDied() => Animator.SetTrigger(_diedHash);

        public void PlayDamageTaken()
        {
            
        }

        public void ResetAll()
        {
            Animator.ResetTrigger(_attackHash);
            Animator.ResetTrigger(_diedHash);
        }
    }
}
using BaseGame.Scripts.Gameplay.Common.Visuals;
using UnityEngine;

namespace BaseGame.Scripts.Gameplay.Features.Enemy.Behaviours
{
    public class EnemyAnimator : MonoBehaviour, IDamageTakenAnimator
    {
        private static readonly int OverlayIntensityProperty = Shader.PropertyToID("_OverlayIntensity");
        
        private readonly int _diedHash = Animator.StringToHash("died");

        public Animator Animator;

        public void PlayDied() => Animator.SetTrigger(_diedHash);
        
        public void PlayDamageTaken()
        {
            
        }

        public void ResetAll()
        {
            Animator.ResetTrigger(_diedHash);
        }
    }
}
using UnityEngine;
using BaseGame.Scripts.Common.Entity;
using BaseGame.Scripts.Common.Extensions;
using BaseGame.Scripts.Gameplay.Features.Hero.Behaviours;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : MonoBehaviour
    {
        [SerializeField] private HeroAnimator _heroAnimator;
        [SerializeField] private float _speed = 2;
        
        private GameEntity _entity;
        private void Awake()
        {
            _entity = CreateEntity.Empty().AddTransform(transform).AddWorldPosition(transform.position).AddDirection(Vector3.zero).AddSpeed(_speed).AddHeroAnimator(_heroAnimator).With(x => x.isHero = true);
        }
    }
}
using UnityEngine;
using BaseGame.Scripts.Common.Entity;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Registrars
{
    public class HeroRegistrar : MonoBehaviour
    {
        public float Speed = 2;
        
        private GameEntity _entity;
        private void Awake()
        {
            _entity = CreateEntity.Empty().AddWorldPosition(transform.position).AddDirection(Vector3.zero).AddSpeed(Speed);
        }
    }
}
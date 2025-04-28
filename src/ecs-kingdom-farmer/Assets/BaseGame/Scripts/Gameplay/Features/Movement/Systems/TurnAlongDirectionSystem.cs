using UnityEngine;
using Entitas;
using BaseGame.Scripts.Gameplay.Common.Time;

namespace BaseGame.Scripts.Gameplay.Features.Movement.Systems
{
    public class TurnAlongDirectionSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _heroes;
        
        public TurnAlongDirectionSystem(GameContext gameContext, ITimeService timeService)
        {
            _time = timeService;
            _heroes = gameContext.GetGroup(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.Transform, GameMatcher.Direction, GameMatcher.RotationSmooth, GameMatcher.Moving));
        }
        
        public void Execute()
        {
            foreach (GameEntity hero in _heroes)
            {
                Vector3 direction = hero.direction.Value;
                
                if (direction.sqrMagnitude <= 0.01f) 
                    continue;

                direction.y = 0f;
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                hero.transform.Value.rotation = Quaternion.Slerp(hero.transform.Value.rotation, targetRotation, hero.rotationSmooth.Value * _time.DeltaTime);
            }
        }
    }
}
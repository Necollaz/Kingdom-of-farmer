using Entitas;
using UnityEngine;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Systems
{
    public class SetHeroDirectionByInput : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<GameEntity> _inputs;

        public SetHeroDirectionByInput(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher.Hero);
            _inputs = game.GetGroup(GameMatcher.Input);
        }
        
        public void Execute()
        {
            GameEntity inputEntity = _inputs.GetSingleEntity();
            bool moving = inputEntity.hasAxisInput;
            Vector3 direction = moving ? inputEntity.AxisInput.normalized : Vector3.zero;
            
            foreach (GameEntity hero in _heroes)
            {
                hero.ReplaceDirection(direction);
                hero.isMoving = moving;
            }
        }
    }
}
using Entitas;
using UnityEngine;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Systems
{
    public class AnimateHeroMovementSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;

        public AnimateHeroMovementSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.HeroAnimator));
        }
        
        public void Execute()
        {
            foreach(GameEntity hero in _heroes)
            {
                Vector3 direction = hero.direction.Value;
                
                hero.HeroAnimator.UpdateMovement(direction);
                
                /*if(hero.isMoving)
                    hero.HeroAnimator.PlayMove();
                else
                    hero.HeroAnimator.PlayIdle();*/
            }
        }
    }
}

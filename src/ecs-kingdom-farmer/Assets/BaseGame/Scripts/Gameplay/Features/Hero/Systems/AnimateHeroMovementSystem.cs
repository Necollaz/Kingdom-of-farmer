using Entitas;

namespace BaseGame.Scripts.Gameplay.Features.Hero.Systems
{
    public class AnimateHeroMovementSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        
        public AnimateHeroMovementSystem(GameContext game)
        {
            _heroes = game.GetGroup(GameMatcher.AllOf(GameMatcher.Hero, GameMatcher.Direction, GameMatcher.HeroAnimator));
        }
        
        public void Execute()
        {
            foreach(GameEntity hero in _heroes)
            {
                bool isMoving = hero.direction.Value.sqrMagnitude > 0.01f;
                
                if (isMoving)
                    hero.heroAnimator.Value.PlayMove();
                else
                    hero.heroAnimator.Value.PlayIdle();
            }
        }
    }
}
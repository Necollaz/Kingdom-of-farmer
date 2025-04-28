using BaseGame.Scripts.Gameplay.Common.Time;
using BaseGame.Scripts.Gameplay.Features.Hero.Systems;

namespace BaseGame.Scripts.Gameplay.Features.Hero
{
    public class HeroFeature : Feature
    {
        public HeroFeature(GameContext game)
        {
            Add(new SetHeroDirectionByInput(game));
            Add(new AnimateHeroMovementSystem(game));
        }
    }
}
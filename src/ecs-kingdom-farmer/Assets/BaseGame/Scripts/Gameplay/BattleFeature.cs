using BaseGame.Scripts.Gameplay.Common.Time;
using BaseGame.Scripts.Gameplay.Features.Hero;
using BaseGame.Scripts.Gameplay.Features.Hero.Systems;
using BaseGame.Scripts.Gameplay.Features.Movement;
using BaseGame.Scripts.Gameplay.Input;
using BaseGame.Scripts.Gameplay.Input.Service;

namespace BaseGame.Scripts.Gameplay
{
    public class BattleFeature : Feature
    {
        public BattleFeature(GameContext gameContext, ITimeService timeService, IInputService inputService)
        {
            Add(new InputFeature(gameContext, inputService));
            Add(new HeroFeature(gameContext));
            Add(new MovementFeature(gameContext, timeService));
        }
    }
}
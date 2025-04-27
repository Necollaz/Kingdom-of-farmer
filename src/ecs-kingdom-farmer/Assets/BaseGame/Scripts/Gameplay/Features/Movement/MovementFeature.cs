using BaseGame.Scripts.Gameplay.Common.Time;
using BaseGame.Scripts.Gameplay.Features.Movement.Systems;

namespace BaseGame.Scripts.Gameplay.Features.Movement
{
    public class MovementFeature : Feature
    {
        public MovementFeature(GameContext gameContext, ITimeService timeService)
        {
            Add(new DirectionalDeltaMoveSystem(gameContext, timeService));
            Add(new UpdateTransformPositionSystem(gameContext));
        }
    }
}
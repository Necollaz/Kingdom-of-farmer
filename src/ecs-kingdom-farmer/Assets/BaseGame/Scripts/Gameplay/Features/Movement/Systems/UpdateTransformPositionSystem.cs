using Entitas;

namespace BaseGame.Scripts.Gameplay.Features.Movement.Systems
{
    public class UpdateTransformPositionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;

        public UpdateTransformPositionSystem(GameContext gameContext)
        {
            _movers = gameContext.GetGroup(GameMatcher.AllOf(GameMatcher.WorldPosition, GameMatcher.Direction));
        }
        
        public void Execute()
        {
            foreach(GameEntity mover in _movers)
            {
                mover.Transform.position = mover.WorldPosition;
            }
        }
    }
}
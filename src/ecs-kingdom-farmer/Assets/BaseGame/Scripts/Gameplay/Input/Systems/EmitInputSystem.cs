using BaseGame.Scripts.Gameplay.Input.Service;
using Entitas;
using UnityEngine;

namespace BaseGame.Scripts.Gameplay.Input.Systems
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly IInputService _inputService;
        private readonly IGroup<GameEntity> _inputs;

        public EmitInputSystem(GameContext game, IInputService inputService)
        {
            _inputService = inputService;
            _inputs = game.GetGroup(GameMatcher.Input);
        }
        
        public void Execute()
        {
            foreach(GameEntity input in _inputs)
            {
                if(_inputService.HasAxisInput())
                    input.ReplaceAxisInput(new Vector3(_inputService.GetHorizontalAxis(), 0f, _inputService.GetVerticalAxis()));
                else if(input.hasAxisInput)
                    input.RemoveAxisInput();
            }
        }
    }
}
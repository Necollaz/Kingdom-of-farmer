using BaseGame.Scripts.Gameplay.Input.Service;
using BaseGame.Scripts.Gameplay.Input.Systems;

namespace BaseGame.Scripts.Gameplay.Input
{
    public class InputFeature : Feature
    {
        public InputFeature(GameContext game, IInputService inputService)
        {
            Add(new InitializeInputSystem());
            Add(new EmitInputSystem(game, inputService));
        }
    }
}
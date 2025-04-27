using Entitas;
using BaseGame.Scripts.Common.Entity;

namespace BaseGame.Scripts.Gameplay.Input.Systems
{
    public class InitializeInputSystem : IInitializeSystem
    {
        public void Initialize()
        {
            CreateEntity.Empty().isInput = true;
        }
    }
}
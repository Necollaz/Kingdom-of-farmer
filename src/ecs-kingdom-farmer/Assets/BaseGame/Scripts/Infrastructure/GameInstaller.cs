using Zenject;
using BaseGame.Scripts.Gameplay.Common.Time;
using BaseGame.Scripts.Gameplay.Input.Service;

namespace BaseGame.Scripts.Infrastructure
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
            Container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();
            Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
        }
    }
}
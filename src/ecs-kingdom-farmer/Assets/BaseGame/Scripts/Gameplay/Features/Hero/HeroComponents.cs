using Entitas;
using BaseGame.Scripts.Gameplay.Features.Hero.Behaviours;

namespace BaseGame.Scripts.Gameplay.Features.Hero
{
    [Game] public class Hero : IComponent { }
    [Game] public class HeroAnimatorComponent : IComponent { public HeroAnimator Value; }
}
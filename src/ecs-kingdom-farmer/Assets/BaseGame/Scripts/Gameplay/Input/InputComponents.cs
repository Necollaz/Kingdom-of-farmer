using Entitas;
using UnityEngine;

namespace BaseGame.Scripts.Gameplay.Input
{
    [Game] public class Input : IComponent { }
    [Game] public class AxisInput : IComponent { public Vector3 Value; }
}
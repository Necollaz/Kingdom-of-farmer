using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BaseGame.Scripts.Gameplay.Common
{
    [Game, Meta] public class Id : IComponent { [PrimaryEntityIndex] public int Value; }
    
    [Game] public class WorldPosition : IComponent { public Vector3 Value; }
}
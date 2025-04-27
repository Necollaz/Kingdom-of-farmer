using System;

namespace BaseGame.Scripts.Gameplay.Common.Time
{
    public interface ITimeService
    {
        float DeltaTime { get; }
        DateTime UtcNow { get; }

        void StopTime();

        void StartTime();
    }
}
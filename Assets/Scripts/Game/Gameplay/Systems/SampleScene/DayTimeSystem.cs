using Game.Core.Base;
using Game.Gameplay.Models.SampleScene;
using JetBrains.Annotations;
using UnityEngine;

namespace Game.Gameplay.Systems.SampleScene
{
    [UsedImplicitly]
    public class DayTimeSystem : IUpdateSystem
    {
        private const int DayTime = 24;
        private const int DegreesInCircle = 360;
        private const float MidnightSunAngle = 90f;

        private readonly DayTime _dayTime;

        public DayTimeSystem(DayTime dayTime)
        {
            _dayTime = dayTime;
        }
        
        public void Update()
        {
            _dayTime.CurrentTime += Time.deltaTime;

            var currentDayTime = _dayTime.CurrentTime % DayTime;
            _dayTime.Time.Value = currentDayTime;

            _dayTime.SunAngle.Value = DegreesInCircle * (currentDayTime / DayTime) - MidnightSunAngle;
        }
    }
}
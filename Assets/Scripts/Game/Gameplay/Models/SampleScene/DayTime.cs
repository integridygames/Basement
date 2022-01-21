using Game.Core;
using JetBrains.Annotations;

namespace Game.Gameplay.Models.SampleScene
{
    [UsedImplicitly]
    public class DayTime
    {
        public float CurrentTime;
        
        // Важно объявлять реактивные поля как readonly
        public readonly RxField<float> Time = 0f;
        
        public readonly RxField<float> SunAngle = 0f;
    }
}
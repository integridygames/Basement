using System;
using Game.Core.Base;
using Game.Gameplay.Models.SampleScene;
using Game.Gameplay.Views.SampleScene;
using JetBrains.Annotations;
using Zenject;

namespace Game.Gameplay.Controllers.SampleScene
{
    [UsedImplicitly] // Нужен чтобы ide не жаловалась, что класс не используется явно
    public class DayTimeController : ControllerBase<ChangeTimeUiView>, IInitializable, IDisposable
    {
        private const float HalfDayTime = 12f;
        
        private readonly DayTime _dayTime;

        public DayTimeController(ChangeTimeUiView changeTimeUiView, DayTime dayTime) : base(changeTimeUiView)
        {
            _dayTime = dayTime;
        }

        public void Initialize()
        {
            View.OnChangeTime += OnChangeTimeHandler;
        }

        public void Dispose()
        {
            View.OnChangeTime -= OnChangeTimeHandler;
        }
        
        private void OnChangeTimeHandler()
        {
            _dayTime.CurrentTime += HalfDayTime;
        }
    }
}
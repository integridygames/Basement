using System;
using Game.Core.Base;
using Game.Gameplay.Models.SampleScene;
using Game.Gameplay.Views.SampleScene;
using JetBrains.Annotations;
using Zenject;

namespace Game.Gameplay.Controllers.SampleScene
{
    [UsedImplicitly] // Нужен чтобы ide не жаловалась, что класс не используется явно
    public class DayTimeController : ControllerBase<DayTime>, IInitializable, IDisposable
    {
        private const float HalfDayTime = 12f;
        
        private readonly TimeUiView _timeUiView;
        private readonly SunView _sunView;
        private readonly ChangeTimeUiView _changeTimeUiView;

        public DayTimeController(DayTime data, TimeUiView timeUiView, SunView sunView, ChangeTimeUiView changeTimeUiView) : base(data)
        {
            _timeUiView = timeUiView;
            _sunView = sunView;
            _changeTimeUiView = changeTimeUiView;
        }

        public void Initialize()
        {
            Data.Time.OnUpdate += OnTimeUpdateHandler;
            Data.SunAngle.OnUpdate += OnAngleUpdateHandler;
            _changeTimeUiView.OnChangeTime += OnChangeTimeHandler;
        }

        public void Dispose()
        {
            Data.Time.OnUpdate -= OnTimeUpdateHandler;
            Data.SunAngle.OnUpdate -= OnAngleUpdateHandler;
            _changeTimeUiView.OnChangeTime -= OnChangeTimeHandler;
        }

        private void OnTimeUpdateHandler(float time)
        {
            _timeUiView.SetTime(time);
        }

        private void OnAngleUpdateHandler(float angle)
        {
            _sunView.SetAngle(angle);
        }

        private void OnChangeTimeHandler()
        {
            Data.CurrentTime += HalfDayTime;
        }
    }
}
using Game.Gameplay.Views.SampleScene;
using UnityEngine;
using Zenject;

namespace Game.Installers.SampleScene
{
    public class MonoBehaviorInstaller : MonoInstaller
    {
        [SerializeField] private TimeUiView _timeUiView;
        [SerializeField] private SunView _sunView;
        [SerializeField] private ChangeTimeUiView _changeTimeUiView;

        public override void InstallBindings()
        {
            Container.Bind<TimeUiView>()
                .FromInstance(_timeUiView)
                .AsSingle();
            
            Container.Bind<SunView>()
                .FromInstance(_sunView)
                .AsSingle();

            Container.Bind<ChangeTimeUiView>()
                .FromInstance(_changeTimeUiView)
                .AsSingle();
        }
    }
}
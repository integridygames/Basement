using Game.Extensions;
using Game.Gameplay.Systems.SampleScene;
using Zenject;

namespace Game.Installers.SampleScene
{
    public class SystemsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindUpdateSystem<DayTimeSystem>();
        }
    }
}
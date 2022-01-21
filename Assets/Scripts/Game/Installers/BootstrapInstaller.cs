using Game.Core;
using Zenject;

namespace Game.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindGameStartup();
        }

        private void BindGameStartup()
        {
            Container.BindInterfacesAndSelfTo<GameStartup>()
                .AsSingle()
                .NonLazy();
        }
    }
}
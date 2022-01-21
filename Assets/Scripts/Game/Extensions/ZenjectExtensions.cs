using Game.Core;
using Game.Core.Base;
using Zenject;

namespace Game.Extensions
{
    public static class ZenjectExtensions
    {
        public static void BindInitializeSystem<TSystem>(this DiContainer container)
            where TSystem : IInitializeSystem
        {
            container.Bind<IInitializeSystem>()
                .To<TSystem>()
                .AsSingle()
                .WhenInjectedInto<GameStartup>();
        }
        
        public static void BindUpdateSystem<TSystem>(this DiContainer container)
            where TSystem : IUpdateSystem
        {
            container.Bind<IUpdateSystem>()
                .To<TSystem>()
                .AsSingle()
                .WhenInjectedInto<GameStartup>();
        }
        
        public static void BindFixedSystem<TSystem>(this DiContainer container)
            where TSystem : IFixedSystems
        {
            container.Bind<IFixedSystems>()
                .To<TSystem>()
                .AsSingle()
                .WhenInjectedInto<GameStartup>();
        }
    }
}
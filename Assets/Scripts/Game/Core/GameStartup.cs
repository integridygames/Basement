using System.Collections.Generic;
using Game.Core.Base;
using JetBrains.Annotations;
using Zenject;

namespace Game.Core
{
    [UsedImplicitly]
    public class GameStartup : IInitializable, ITickable, IFixedTickable
    {
        private readonly List<IInitializeSystem> _initializeSystems;
        private readonly List<IUpdateSystem> _updateSystems;
        private readonly List<IFixedSystems> _fixedSystems;

        public GameStartup(List<IInitializeSystem> initializeSystems, List<IUpdateSystem> updateSystems,
            List<IFixedSystems> fixedSystems)
        {
            _initializeSystems = initializeSystems;
            _updateSystems = updateSystems;
            _fixedSystems = fixedSystems;
        }

        public void Initialize()
        {
            for (var i = 0; i < _initializeSystems.Count; i++)
            {
                _initializeSystems[i].Initialize();
            }
        }

        public void Tick()
        {
            for (var i = 0; i < _updateSystems.Count; i++)
            {
                _updateSystems[i].Update();
            }
        }

        public void FixedTick()
        {
            for (var i = 0; i < _fixedSystems.Count; i++)
            {
                _fixedSystems[i].FixedUpdate();
            }
        }
    }
}
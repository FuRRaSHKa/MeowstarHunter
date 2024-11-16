using HalloGames.Architecture.Services;
using System.Collections.Generic;

namespace HalloGames.Architecture.GameLoop
{
    public class UpdateLoop : IService
    {
        private List<ITickable> _subscibers = new List<ITickable>();

        public void Register(ITickable tickable)
        {
            if (!_subscibers.Contains(tickable))
                _subscibers.Add(tickable);
        }

        public void Unregister(ITickable tickable)
        {
            _subscibers.Remove(tickable);
        }

        public void Tick(float dt)
        {
            for(int i = 0;  i < _subscibers.Count; i++)
            {
                _subscibers[i].Tick(dt);
            }
        }
    }
}

using UnityEngine;

namespace Game.Scripts.GameWorld.BuildingGrid
{
    public class GridInstaller : MonoBehaviour
    {
        [SerializeField] private Grid.Settings _settings;

        public Grid.Settings Settings => _settings; 
    }
}



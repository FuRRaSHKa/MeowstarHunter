using UnityEngine;

namespace Game.Scripts.GameWorld.BuildingGrid
{
    public class GridInstaller : MonoBehaviour
    {
        [SerializeField] private GridSettings _settings;

        public GridSettings Settings => _settings; 
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.GameWorld.BuildingGrid
{
    public partial class Grid
    {
        [System.Serializable]
        public class Settings
        {
            [SerializeField] private Vector2 _minPos;
            [SerializeField] private Vector2Int _size;
            [SerializeField] private Vector2 _tileSize;
        
            public Vector2 MaxPos => _minPos;
            public Vector2 Size => _size;
            public Vector2 TileSize => _tileSize;
        }
    }
}

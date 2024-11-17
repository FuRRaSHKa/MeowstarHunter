using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.GameWorld.BuildingGrid
{
    public class GridDebugDrawer : MonoBehaviour
    {
        [SerializeField] private GridSettings _settings;

        private void OnDrawGizmos()
        {
            if (_settings == null)
                return;

            DrawGrid();
        }

        private void DrawGrid()
        {
            var settings = _settings;
            var maxPos = settings.MaxPos;
            var size = settings.Size;
            var tileSize = settings.TileSize;
            for(int x = 0; x < size.x; x++)
            {
                for(int y = 0; y < size.y; y++)
                {
                    var pos = Vector2.Scale(new Vector2(x, y), tileSize) + maxPos;
                    DrawSquare(pos + tileSize / 2, tileSize);
                }
            }
        }

        private void DrawSquare(Vector3 center, Vector2 size)
        {
            Vector3 v3Size = size;
            v3Size.z = 1;

            Gizmos.DrawWireCube(center, v3Size);
        }
    }
}
